using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace wuakiller{
    public class wuakiller{
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