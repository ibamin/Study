```csharp
using System;
using System.Runtime.InteropServices;

public class Program
    {
        [DllImport("kernel32.dll")] // kernel32.dll에서 Sleep 함수를 import
        public static extern void Sleep(uint dwMilliseconds); // Sleep 함수 선언 
        
        [DllImport("kernel32.dll")] // kernel32.dll에서 GetLastError 함수를 import  
        public static extern uint GetLastError(); // GetLastError 함수 선언

        public static void Main()
        {
            uint errorCode = GetLastError(); // 마지막 에러 코드 반환
            Sleep(3000); // 3초 대기
        }
    }
```