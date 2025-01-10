# Day 1: P/Invoke 기초와 PowerShell 보안 - 문제 해답

## 실습 문제 1: GetSystemInfo API 활용
문제: GetSystemInfo API를 사용하여 시스템의 프로세서 수와 페이지 크기를 출력하는 스크립트를 작성하시오.

### 해답:
```powershell
$code = @"
using System;
using System.Runtime.InteropServices;

public class SystemInfoUtil {
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_INFO {
        public ushort wProcessorArchitecture;
        public ushort wReserved;
        public uint dwPageSize;
        public IntPtr lpMinimumApplicationAddress;
        public IntPtr lpMaximumApplicationAddress;
        public IntPtr dwActiveProcessorMask;
        public uint dwNumberOfProcessors;
        public uint dwProcessorType;
        public uint dwAllocationGranularity;
        public ushort wProcessorLevel;
        public ushort wProcessorRevision;
    }

    [DllImport("kernel32.dll")]
    public static extern void GetSystemInfo(out SYSTEM_INFO lpSystemInfo);
}
"@

Add-Type -TypeDefinition $code

$sysInfo = New-Object SystemInfoUtil+SYSTEM_INFO
[SystemInfoUtil]::GetSystemInfo([ref]$sysInfo)

Write-Host "프로세서 개수: $($sysInfo.dwNumberOfProcessors)"
Write-Host "페이지 크기: $($sysInfo.dwPageSize) bytes"
```

### 설명:
- SYSTEM_INFO 구조체를 정의하여 시스템 정보를 저장
- GetSystemInfo API를 호출하여 시스템 정보를 가져옴
- 결과값에서 프로세서 수와 페이지 크기를 추출하여 출력

## 실습 문제 2: 사용자 이름 가져오기
문제: 현재 사용자의 전체 이름을 가져오는 Windows API를 P/Invoke로 호출하는 스크립트를 작성하시오.

### 해답:
```powershell
$code = @"
using System;
using System.Runtime.InteropServices;

public class UserInfo {
    [DllImport("secur32.dll", CharSet=CharSet.Auto)]
    public static extern int GetUserNameEx(
        int nameFormat,
        System.Text.StringBuilder lpNameBuffer,
        ref uint lpnSize);

    public static string GetFullName() {
        uint size = 0;
        GetUserNameEx(3, null, ref size); // 3 = NameDisplay

        System.Text.StringBuilder sb = new System.Text.StringBuilder((int)size);
        if (GetUserNameEx(3, sb, ref size) == 0) {
            throw new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error());
        }
        return sb.ToString();
    }
}
"@

Add-Type -TypeDefinition $code

try {
    $fullName = [UserInfo]::GetFullName()
    Write-Host "사용자 전체 이름: $fullName"
} catch {
    Write-Host "에러 발생: $_"
}
```

### 설명:
- secur32.dll의 GetUserNameEx API를 사용
- NameDisplay 포맷(3)을 사용하여 전체 이름 가져오기
- 버퍼 크기를 먼저 확인한 후 실제 이름 가져오기
- 에러 처리 포함

## 실습 문제 3: 메모리 할당 및 해제
문제: VirtualAlloc API를 사용하여 메모리를 할당하고 해제하는 스크립트를 작성하시오.

### 해답:
```powershell
$code = @"
using System;
using System.Runtime.InteropServices;

public class MemoryManager {
    [DllImport("kernel32.dll", SetLastError=true)]
    public static extern IntPtr VirtualAlloc(
        IntPtr lpAddress,
        uint dwSize,
        uint flAllocationType,
        uint flProtect);

    [DllImport("kernel32.dll", SetLastError=true)]
    public static extern bool VirtualFree(
        IntPtr lpAddress,
        uint dwSize,
        uint dwFreeType);

    // 메모리 보호 상수
    public const uint MEM_COMMIT = 0x1000;
    public const uint MEM_RESERVE = 0x2000;
    public const uint MEM_RELEASE = 0x8000;
    public const uint PAGE_READWRITE = 0x04;
}
"@

Add-Type -TypeDefinition $code

# 메모리 할당 (1MB)
$size = 1MB
$memory = [MemoryManager]::VirtualAlloc(
    [IntPtr]::Zero,
    $size,
    [MemoryManager]::MEM_COMMIT -bor [MemoryManager]::MEM_RESERVE,
    [MemoryManager]::PAGE_READWRITE
)

if ($memory -eq [IntPtr]::Zero) {
    throw "메모리 할당 실패"
}

Write-Host "메모리 할당 성공: $memory"

# 메모리 해제
$freed = [MemoryManager]::VirtualFree($memory, 0, [MemoryManager]::MEM_RELEASE)
if (-not $freed) {
    throw "메모리 해제 실패"
}

Write-Host "메모리 해제 성공"
```

### 설명:
- VirtualAlloc으로 1MB 메모리 할당
- 읽기/쓰기 권한으로 메모리 할당
- 사용 후 VirtualFree로 메모리 해제
- 에러 처리 포함

## 실습 문제 4: 프로세스 권한 체크
문제: 현재 실행 중인 프로세스의 핸들을 가져오고 권한을 체크하는 스크립트를 작성하시오.

### 해답:
```powershell
$code = @"
using System;
using System.Runtime.InteropServices;

public class ProcessPrivileges {
    [DllImport("kernel32.dll")]
    public static extern IntPtr GetCurrentProcess();

    [DllImport("advapi32.dll", SetLastError=true)]
    public static extern bool OpenProcessToken(
        IntPtr ProcessHandle,
        uint DesiredAccess,
        out IntPtr TokenHandle);

    [DllImport("advapi32.dll", SetLastError=true)]
    public static extern bool GetTokenInformation(
        IntPtr TokenHandle,
        int TokenInformationClass,
        IntPtr TokenInformation,
        uint TokenInformationLength,
        out uint ReturnLength);

    [DllImport("kernel32.dll", SetLastError=true)]
    public static extern bool CloseHandle(IntPtr hObject);

    public const uint TOKEN_QUERY = 0x0008;
    public const int TokenElevation = 20;
}
"@

Add-Type -TypeDefinition $code

$processHandle = [ProcessPrivileges]::GetCurrentProcess()
$tokenHandle = [IntPtr]::Zero
$result = [ProcessPrivileges]::OpenProcessToken($processHandle, 
    [ProcessPrivileges]::TOKEN_QUERY, [ref]$tokenHandle)

if ($result) {
    try {
        $elevationResult = [IntPtr]::Zero
        $returnLength = 0
        $elevationResultSize = 4

        $elevationResult = [System.Runtime.InteropServices.Marshal]::AllocHGlobal($elevationResultSize)
        
        $result = [ProcessPrivileges]::GetTokenInformation(
            $tokenHandle,
            [ProcessPrivileges]::TokenElevation,
            $elevationResult,
            $elevationResultSize,
            [ref]$returnLength)

        if ($result) {
            $isElevated = [System.Runtime.InteropServices.Marshal]::ReadInt32($elevationResult) -ne 0
            Write-Host "프로세스 권한 상승 여부: $isElevated"
        }
    }
    finally {
        [System.Runtime.InteropServices.Marshal]::FreeHGlobal($elevationResult)
        [ProcessPrivileges]::CloseHandle($tokenHandle)
    }
}
```

### 설명:
- 현재 프로세스의 핸들 획득
- 프로세스 토큰 열기
- 토큰 정보에서 권한 상승 여부 확인
- 적절한 리소스 정리 포함

## 실습 문제 5: 중요 프로세스 식별
문제: IsProcessCritical API를 사용하여 시스템 중요 프로세스를 식별하는 스크립트를 작성하시오.

### 해답:
```powershell
$code = @"
using System;
using System.Runtime.InteropServices;

public class CriticalProcess {
    [DllImport("kernel32.dll", SetLastError=true)]
    public static extern bool IsProcessCritical(
        IntPtr hProcess,
        out bool Critical);

    [DllImport("kernel32.dll", SetLastError=true)]
    public static extern IntPtr OpenProcess(
        uint dwDesiredAccess,
        bool bInheritHandle,
        uint dwProcessId);

    public const uint PROCESS_QUERY_INFORMATION = 0x0400;
}
"@

Add-Type -TypeDefinition $code

function Test-ProcessCritical {
    param (
        [Parameter(Mandatory=$true)]
        [int]$ProcessId
    )

    $handle = [CriticalProcess]::OpenProcess(
        [CriticalProcess]::PROCESS_QUERY_INFORMATION,
        $false,
        $ProcessId)

    if ($handle -eq [IntPtr]::Zero) {
        Write-Host "프로세스 열기 실패: $ProcessId"
        return $false
    }

    try {
        $isCritical = $false
        $result = [CriticalProcess]::IsProcessCritical($handle, [ref]$isCritical)
        
        if ($result) {
            return $isCritical
        }
        return $false
    }
    finally {
        [CriticalProcess]::CloseHandle($handle)
    }
}

# 모든 프로세스 검사
Get-Process | ForEach-Object {
    $isCritical = Test-ProcessCritical -ProcessId $_.Id
    if ($isCritical) {
        Write-Host "중요 프로세스 발견: $($_.ProcessName) (PID: $($_.Id))"
    }
}
```

### 설명:
- IsProcessCritical API를 사용하여 프로세스의 중요도 확인
- 모든 실행 중인 프로세스를 검사
- 중요 프로세스 식별 및 보고
- 적절한 에러 처리 포함

## 심화 과제 힌트

### 1. 프로세스 메모리 덤프 도구
- MiniDumpWriteDump API 사용
- 프로세스 권한 확인
- 덤프 파일 저장 경로 처리

### 2. 파일 시스템 모니터링 도구
- ReadDirectoryChangesW API 활용
- 이벤트 필터링
- 로깅 구현

### 3. 네트워크 연결 모니터링 도구
- GetExtendedTcpTable API 사용
- 연결 상태 모니터링
- 통계 수집

## 주의사항
- 모든 리소스는 반드시 해제
- 에러 처리 구현 필수
- 권한 검사 수행
- 입력값 검증 실시