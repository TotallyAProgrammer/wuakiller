using System;

namespace wuakiller{
    public class wuakiller{
        bool pname;
        Process[] pname = Process.GetProcessesByName("notepad");
        if (pname.Length == 0){
            MessageBox(
                 NULL,
                 (LPCWSTR)L"nothing"
    //             MB_CANCELTRYCONTINUE
                );
        }
        else{
            MessageBox(
                 NULL,
                 (LPCWSTR)L"run"
    //             MB_CANCELTRYCONTINUE
                );
        }
}
}