using System;
using System.Windows.Forms;
using System.Diagnostics;


class kill
{
     static void Main()
    {
        Process[] procnm = Process.GetProcessesByName("notepad");
        if(procnm.Length == 1){
            MessageBox.Show("Live");
        }
        else{
            MessageBox.Show("Dead");
        }
    }
}
/*
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
if(pname == 1){
Console.WriteLine("1");
}
else{
Console.WriteLine("0");
}
*/