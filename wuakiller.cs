using System;

namespace wuakiller{
    public class wuakiller{
        int pname = 0;
        Process[] pname = Process.GetProcessesByName("notepad");
        if(pname.Length = 1){
            MessageBox(
                 (LPCTSTR)L"nothing"
                );
        }
        else{
            MessageBox(
                 (LPCTSTR)L"running"
                );
        }
}
}