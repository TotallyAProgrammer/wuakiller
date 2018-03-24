using System;
using System.Windows.Forms;
using System.Diagnostics;


class kill
{
     static void Main()
    {
        String procmain = "Windows10UpgraderApp";
        DialogResult result1 = MessageBox.Show("Kill Process?", procmain /*procmain*/, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        if(result1 == DialogResult.No){
            return;
        }
        else if(result1 == DialogResult.Cancel){
            return;
        }
        else{
        }
        Process[] procnm = Process.GetProcessesByName("Windows10UpgraderApp");
        if(procnm.Length == 1){
            procnm[0].Kill();
            MessageBox.Show("Live, Now Dead.");
        }
        else{
            MessageBox.Show("Not live, Not dead.");
        }
        Process[] procdetect = Process.GetProcessesByName("Windows10UpgraderApp");
        if(procdetect.Length == 1){
            MessageBox.Show("Still Live, Not Dead");
        }
        else{
            MessageBox.Show("Dead, Killed.");
        }
    }
}