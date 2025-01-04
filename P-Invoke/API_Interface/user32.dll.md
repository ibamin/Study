```csharp
using System;
using System.Runtime.IteropServices;

public class Program
{
    [DllImport("user32.dll",CharSet=CharSet.Unicode)]
    public static extern int MessageBox(IntPtr hwnd,string lptext,string caption, uint type);
    // type : 0 ( ok / cancle ) , 1 ( ok ) , 2 ( cancle )
    [DllImport("user32.dll",ChaeSet=CharSet.Unicode)]
    public static extern IntPtr FindWindow(string classname,string windowtitle);

    [DllImport("user32.dll")]
    public static extern bool ShowWindow(IntPtr hwnd,int cmdshow);
    //cmdshow : 0 ( hidden ) , 5 ( Show )

    [StructLayout(LayoutKind.Sequential)]
    public struct POINT{
        public int x;
        public int y;
    }
    [DllImport("user32.dll")]
    public static extern bool GetCursorPos(out POINT lpPoint);
    //- 네이티브 구조체 기반 정보를 가져오기 위해 .NET 구조체를 선언합니다.
    //- 네이티브 구조체와 .NET 구조체의 메모리 배치를 동일하게 하기 위해 `[StructLayout]`을 사용하며, 필드 순서를 보장합니다.
    //- 매개변수에 `out` 키워드를 붙여 네이티브 함수가 반환하는 구조체 데이터를 .NET 구조체에 직접 쓰도록 합니다.
    //- 이 방식은 네이티브 구조체(`POINT`)와 .NET 구조체의 호환성을 유지하며, 데이터를 올바르게 교환할 수 있게 해줍니다.
}
```