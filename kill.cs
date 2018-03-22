using System;


class kill
{
     static void Main()
    {
        int pname = 1;
//        Process[] pname = Process.GetProcessesByName("notepad");
        if(pname.Length == 1){
            MessageBox.Show("Dot Net Perls");
        }
/*        if(pname == 1){
            Console.WriteLine("1");
        }
        else{
            Console.WriteLine("0");
        }*/
    }
}
/*        Process[] pname = Process.GetProcessesByName("notepad");
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
*/