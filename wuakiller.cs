namespace .
{
    public class wuakiller
    {
        Process[] pname = Process.GetProcessesByName("notepad");
    if (pname.Length == 0)
        MessageBox.Show("nothing");
    else
        MessageBox.Show("run");
    }
}