using System;
using System.Windows.Forms;
using System.Diagnostics;


class kill
{
     static void Main()
    {
        Process[] a = Process.GetProcessesByName("notepad");
        if(a.Length == 1){
            MessageBox.Show("Dot Net Perls");
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