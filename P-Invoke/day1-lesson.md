# Day 1: P/Invoke 기초와 PowerShell 보안

## 1. P/Invoke(Platform Invocation Services) 개요

### 1.1 P/Invoke란?
- 관리 코드에서 비관리 코드(native DLL)를 호출하기 위한 기술
- Windows API, 써드파티 DLL 등의 네이티브 함수 활용 가능
- PowerShell에서 .NET Framework를 통해 P/Invoke 사용

### 1.2 P/Invoke가 보안에서 중요한 이유
- 시스템 수준의 작업 수행 가능
- 메모리 직접 접근 및 조작
- 프로세스/스레드 제어
- 네트워크 패킷 조작
- 시스템 후킹 구현

## 2. PowerShell에서 P/Invoke 사용하기

### 2.1 기본 구문
```powershell
# Add-Type을 사용한 P/Invoke 정의
$code = @"
using System;
using System.Runtime.InteropServices;

public class NativeMethods {
    [DllImport("kernel32.dll")]
    public static extern IntPtr GetModuleHandle(string lpModuleName);
}
"@

Add-Type -TypeDefinition $code

# 함수 호출
$handle = [NativeMethods]::GetModuleHandle("kernel32.dll")
```

### 2.2 주요 속성 설명
- DllImport: 호출할 DLL 지정
- CallingConvention: 함수 호출 규약
- CharSet: 문자열 처리 방식
- SetLastError: 오류 처리 방식

## 3. 데이터 마샬링

### 3.1 기본 데이터 타입 매핑
```powershell
# 문자열 마샬링 예제
$code = @"
using System;
using System.Runtime.InteropServices;

public class MessageBoxExample {
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
}
"@

Add-Type -TypeDefinition $code

# 메시지 박스 표시
[MessageBoxExample]::MessageBox([IntPtr]::Zero, "Hello", "Title", 0)
```

### 3.2 구조체 마샬링
```powershell
$code = @"
using System;
using System.Runtime.InteropServices;

public struct SYSTEM_INFO
{
    public ushort processorArchitecture;
    public ushort reserved;
    public uint pageSize;
    public IntPtr minimumApplicationAddress;
    public IntPtr maximumApplicationAddress;
    public IntPtr activeProcessorMask;
    public uint numberOfProcessors;
    public uint processorType;
    public uint allocationGranularity;
    public ushort processorLevel;
    public ushort processorRevision;
}

public class Kernel32 {
    [DllImport("kernel32.dll")]
    public static extern void GetSystemInfo(out SYSTEM_INFO lpSystemInfo);
}
"@

Add-Type -TypeDefinition $code

$systemInfo = New-Object SYSTEM_INFO
[Kernel32]::GetSystemInfo([ref]$systemInfo)

Write-Host "Processor Architecture: $($systemInfo.processorArchitecture)"
Write-Host "Number of Processors: $($systemInfo.numberOfProcessors)"
```

## 4. 실습 문제

### 4.1 기본 API 호출
문제: GetSystemInfo API를 사용하여 시스템의 프로세서 수와 페이지 크기를 출력하는 스크립트를 작성하시오.
```powershell
$code = @"
using System;
using System.Runtime.InteropServices;
public class SystemInfo {
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_INFO
    {
        public ushort processorArchitecture;
        public ushort reserved;
        public uint pageSize;
        public IntPtr minimumApplicationAddress;
        public IntPtr maximumApplicationAddress;
        public IntPtr activeProcessorMask;
        public uint numberOfProcessors;
        public uint processorType;
        public uint allocationGranularity;
        public ushort processorLevel;
        public ushort processorRevision;
    }

        [DllImport("kernel32.dll")]
        public static extern void GetSystemInfo(out SYSTEM_INFO lpSystemInfo);
}
"@

Add-Type -TypeDefinition $code

$systemInfo = New-Object SystemInfo.SYSTEM_INFO
[SystemInfo]::GetSystemInfo([ref]$systemInfo)

$systemInfo.dwNumberOfProcessors
$systemInfo.dwPageSize
```
### 4.2 문자열 처리
문제: 현재 사용자의 전체 이름을 가져오는 Windows API를 P/Invoke로 호출하는 스크립트를 작성하시오.

### 4.3 메모리 조작
문제: VirtualAlloc API를 사용하여 메모리를 할당하고 해제하는 스크립트를 작성하시오.

### 4.4 프로세스 정보
문제: 현재 실행 중인 프로세스의 핸들을 가져오고 권한을 체크하는 스크립트를 작성하시오.

### 4.5 보안 검사
문제: IsProcessCritical API를 사용하여 시스템 중요 프로세스를 식별하는 스크립트를 작성하시오.

## 5. 보안 고려사항

### 5.1 P/Invoke 사용 시 주의점
- 메모리 누수 방지
- 적절한 권한 확인
- 문자열 버퍼 오버플로우 방지
- 에러 처리 구현

### 5.2 보안 모범 사례
- 최소 권한 원칙 적용
- 입력 값 검증
- 리소스 정리 보장
- 예외 처리 구현

## 6. 과제

### 6.1 실습 과제
위의 실습 문제 5개를 모두 풀어서 제출하세요.

### 6.2 심화 과제
다음 중 하나를 선택하여 구현하세요:
1. 프로세스 메모리 덤프 도구 구현
2. 파일 시스템 모니터링 도구 구현
3. 네트워크 연결 모니터링 도구 구현

## 7. 참고 자료
- Windows API 문서
- P/Invoke.net 웹사이트
- PowerShell 보안 가이드
- MSDN DllImport 문서

## 내일의 학습 주제 미리보기
- 프로세스 메모리 조작
- 원격 스레드 생성
- DLL 인젝션 기법