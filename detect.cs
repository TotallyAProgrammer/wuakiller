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