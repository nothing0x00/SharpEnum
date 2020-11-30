using System;
using System.IO;

namespace enumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
 _____ _                      _____                      
/  ___| |                    |  ___|                     
\ `--.| |__   __ _ _ __ _ __ | |__ _ __  _   _ _ __ ___  
 `--. \ '_ \ / _` | '__| '_ \|  __| '_ \| | | | '_ ` _ \ 
/\__/ / | | | (_| | |  | |_) | |__| | | | |_| | | | | | |
\____/|_| |_|\__,_|_|  | .__/\____/_| |_|\__,_|_| |_| |_|
                       | |                               
                       |_|                               
");
            Console.WriteLine("");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------");
            Console.WriteLine("[*] System Information");
            Console.WriteLine("------------------------------");
            Console.ResetColor();
            sysinfo();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------");
            Console.WriteLine("[*] Host and User Information");
            Console.WriteLine("------------------------------");
            Console.ResetColor();
            hostUserName();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------");
            Console.WriteLine("[*] Network Information");
            Console.WriteLine("------------------------------");
            Console.ResetColor();
            network();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------");
            Console.WriteLine("[*] Process Information");
            Console.WriteLine("------------------------------");
            Console.ResetColor();
            processes();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------");
            Console.WriteLine("[*] Searching for Cleartext Credentials");
            Console.WriteLine("------------------------------");
            Console.ResetColor();
            cleartext();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------");
            Console.WriteLine("[*] Searching for Unquoted Service Paths");
            Console.WriteLine("------------------------------");
            Console.ResetColor();
            unquoted();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------");
            Console.WriteLine("[*] Checking AlwaysInstallElevated Registry Key Values");
            Console.WriteLine("------------------------------");
            Console.ResetColor();
            alwaysElevated();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------");
            Console.WriteLine("[*] COMPLETE!");
            Console.WriteLine("------------------------------");
            Console.ResetColor();
        }
        public static void sysinfo()
        {
            object command = "systeminfo | findstr /B /C:\"OS Name\" /C:\"OS Version\"";
            try
            {
                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command);

                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();

                string result = proc.StandardOutput.ReadToEnd();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        public static void hostUserName()
        {
            object command1 = "hostname";
            object command2 = "whoami";
            object command3 = "net user";
            object command4 = "net user /domain";
            object command5 = "net localgroup";
            object command6 = "net group";
            try
            {
                System.Diagnostics.ProcessStartInfo procStartInfo1 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command1);
                System.Diagnostics.ProcessStartInfo procStartInfo2 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command2);
                System.Diagnostics.ProcessStartInfo procStartInfo3 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command3);
                System.Diagnostics.ProcessStartInfo procStartInfo4 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command4);
                System.Diagnostics.ProcessStartInfo procStartInfo5 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command5);
                System.Diagnostics.ProcessStartInfo procStartInfo6 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command6);

                procStartInfo1.RedirectStandardOutput = true;
                procStartInfo2.RedirectStandardOutput = true;
                procStartInfo3.RedirectStandardOutput = true;
                procStartInfo4.RedirectStandardOutput = true;
                procStartInfo5.RedirectStandardOutput = true;
                procStartInfo6.RedirectStandardOutput = true;

                procStartInfo1.UseShellExecute = false;
                procStartInfo2.UseShellExecute = false;
                procStartInfo3.UseShellExecute = false;
                procStartInfo4.UseShellExecute = false;
                procStartInfo5.UseShellExecute = false;
                procStartInfo6.UseShellExecute = false;

                procStartInfo1.CreateNoWindow = true;
                procStartInfo2.CreateNoWindow = true;
                procStartInfo3.CreateNoWindow = true;
                procStartInfo4.CreateNoWindow = true;
                procStartInfo5.CreateNoWindow = true;
                procStartInfo6.CreateNoWindow = true;

                System.Diagnostics.Process proc1 = new System.Diagnostics.Process();
                System.Diagnostics.Process proc2 = new System.Diagnostics.Process();
                System.Diagnostics.Process proc3 = new System.Diagnostics.Process();
                System.Diagnostics.Process proc4 = new System.Diagnostics.Process();
                System.Diagnostics.Process proc5 = new System.Diagnostics.Process();
                System.Diagnostics.Process proc6 = new System.Diagnostics.Process();

                proc1.StartInfo = procStartInfo1;
                proc2.StartInfo = procStartInfo2;
                proc3.StartInfo = procStartInfo3;
                proc4.StartInfo = procStartInfo4;
                proc5.StartInfo = procStartInfo5;
                proc6.StartInfo = procStartInfo6;

                proc1.Start();
                proc2.Start();
                proc3.Start();
                proc4.Start();
                proc5.Start();
                proc6.Start();

                string result1 = proc1.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hostname");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result1);
                Console.WriteLine("------------------------------");
                string result2 = proc2.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("User Account");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result2);
                Console.WriteLine("------------------------------");
                string result3 = proc3.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Local User Account Permissions");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result3);
                Console.WriteLine("------------------------------");
                string result4 = proc4.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Domain User Account Permissions");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result4);
                Console.WriteLine("------------------------------");
                string result5 = proc5.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Local User Group Memberships");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result5);
                Console.WriteLine("------------------------------");
                string result6 = proc6.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Domain User Group Memberships");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result6);
                Console.WriteLine("------------------------------");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void network()
        {
            object command1 = "ipconfig /all";
            object command2 = "arp -A";
            object command3 = "netstat -ano";
            object command4 = "netsh advfirewall show allprofiles state";
            object command5 = "netsh firewall show config";
            object command6 = "type C:\\Windows\\System32\\drivers\\etc\\hosts";

            try
            {
                System.Diagnostics.ProcessStartInfo procStartInfo1 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command1);
                System.Diagnostics.ProcessStartInfo procStartInfo2 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command2);
                System.Diagnostics.ProcessStartInfo procStartInfo3 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command3);
                System.Diagnostics.ProcessStartInfo procStartInfo4 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command4);
                System.Diagnostics.ProcessStartInfo procStartInfo5 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command5);
                System.Diagnostics.ProcessStartInfo procStartInfo6 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command6);

                procStartInfo1.RedirectStandardOutput = true;
                procStartInfo2.RedirectStandardOutput = true;
                procStartInfo3.RedirectStandardOutput = true;
                procStartInfo4.RedirectStandardOutput = true;
                procStartInfo5.RedirectStandardOutput = true;
                procStartInfo6.RedirectStandardOutput = true;

                procStartInfo1.UseShellExecute = false;
                procStartInfo2.UseShellExecute = false;
                procStartInfo3.UseShellExecute = false;
                procStartInfo4.UseShellExecute = false;
                procStartInfo5.UseShellExecute = false;
                procStartInfo6.UseShellExecute = false;

                procStartInfo1.CreateNoWindow = true;
                procStartInfo2.CreateNoWindow = true;
                procStartInfo3.CreateNoWindow = true;
                procStartInfo4.CreateNoWindow = true;
                procStartInfo5.CreateNoWindow = true;
                procStartInfo6.CreateNoWindow = true;

                System.Diagnostics.Process proc1 = new System.Diagnostics.Process();
                System.Diagnostics.Process proc2 = new System.Diagnostics.Process();
                System.Diagnostics.Process proc3 = new System.Diagnostics.Process();
                System.Diagnostics.Process proc4 = new System.Diagnostics.Process();
                System.Diagnostics.Process proc5 = new System.Diagnostics.Process();
                System.Diagnostics.Process proc6 = new System.Diagnostics.Process();

                proc1.StartInfo = procStartInfo1;
                proc2.StartInfo = procStartInfo2;
                proc3.StartInfo = procStartInfo3;
                proc4.StartInfo = procStartInfo4;
                proc5.StartInfo = procStartInfo5;
                proc6.StartInfo = procStartInfo6;

                proc1.Start();
                proc2.Start();
                proc3.Start();
                proc4.Start();
                proc5.Start();
                proc6.Start();

                string result1 = proc1.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Local Network Interfaces");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result1);
                Console.WriteLine("------------------------------");
                string result2 = proc2.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ARP Tables");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result2);
                Console.WriteLine("------------------------------");
                string result3 = proc3.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Open Network Interfaces");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result3);
                Console.WriteLine("------------------------------");
                string result4 = proc4.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Firewall Status");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result4);
                Console.WriteLine("------------------------------");
                string result5 = proc5.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Firewall Configuration");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result5);
                Console.WriteLine("------------------------------");
                string result6 = proc6.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hosts File Content");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result6);
                Console.WriteLine("------------------------------");
            }
            catch (Exception e)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine(e);
                Console.WriteLine("------------------------------");
            }
        }
        public static void processes()
        {
            string command1 = "tasklist /V";
            string command2 = "net start";
            string command3 = "wmic qfe get Caption,Description,HotFixID,InstalledOn";
            string command4 = "wmic service list brief";
            string command5 = "dir C:\\\"Program Files\"";
            string command6 = "dir C:\\\"Program Files (x86)\"";

            try
            {
                System.Diagnostics.ProcessStartInfo procStartInfo1 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command1);
                System.Diagnostics.ProcessStartInfo procStartInfo2 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command2);
                System.Diagnostics.ProcessStartInfo procStartInfo3 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command3);
                System.Diagnostics.ProcessStartInfo procStartInfo4 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command4);
                System.Diagnostics.ProcessStartInfo procStartInfo5 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command5);
                System.Diagnostics.ProcessStartInfo procStartInfo6 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command6);

                procStartInfo1.RedirectStandardOutput = true;
                procStartInfo2.RedirectStandardOutput = true;
                procStartInfo3.RedirectStandardOutput = true;
                procStartInfo4.RedirectStandardOutput = true;
                procStartInfo5.RedirectStandardOutput = true;
                procStartInfo6.RedirectStandardOutput = true;

                procStartInfo1.UseShellExecute = false;
                procStartInfo2.UseShellExecute = false;
                procStartInfo3.UseShellExecute = false;
                procStartInfo4.UseShellExecute = false;
                procStartInfo5.UseShellExecute = false;
                procStartInfo6.UseShellExecute = false;

                procStartInfo1.CreateNoWindow = true;
                procStartInfo2.CreateNoWindow = true;
                procStartInfo3.CreateNoWindow = true;
                procStartInfo4.CreateNoWindow = true;
                procStartInfo5.CreateNoWindow = true;
                procStartInfo6.CreateNoWindow = true;

                System.Diagnostics.Process proc1 = new System.Diagnostics.Process();
                System.Diagnostics.Process proc2 = new System.Diagnostics.Process();
                System.Diagnostics.Process proc3 = new System.Diagnostics.Process();
                System.Diagnostics.Process proc4 = new System.Diagnostics.Process();
                System.Diagnostics.Process proc5 = new System.Diagnostics.Process();
                System.Diagnostics.Process proc6 = new System.Diagnostics.Process();

                proc1.StartInfo = procStartInfo1;
                proc2.StartInfo = procStartInfo2;
                proc3.StartInfo = procStartInfo3;
                proc4.StartInfo = procStartInfo4;
                proc5.StartInfo = procStartInfo5;
                proc6.StartInfo = procStartInfo6;

                proc1.Start();
                proc2.Start();
                proc3.Start();
                proc4.Start();
                proc5.Start();
                proc6.Start();

                string result1 = proc1.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Local Tasks");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result1);
                Console.WriteLine("------------------------------");
                string result2 = proc2.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Startup Programs");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result2);
                Console.WriteLine("------------------------------");
                string result3 = proc3.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Installed Patches");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result3);
                Console.WriteLine("------------------------------");
                string result4 = proc4.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Currently Running Services");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result4);
                Console.WriteLine("------------------------------");
                string result5 = proc5.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Program Files Directory Content");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result5);
                Console.WriteLine("------------------------------");
                string result6 = proc6.StandardOutput.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Program Files (x86) Directory Content");
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result6);
                Console.WriteLine("------------------------------");
            }
            catch (Exception e)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine(e);
                Console.WriteLine("------------------------------");
            }
        }
        public static void cleartext()
        {
            string[] files = { @"C:\unattend.xml", @"C:\Windows\Panther\Unattend.xml", @"C:\Windows\Panther\Unattend\Unattend.xml", @"C:\Windows\system32\sysprep.inf", @"C:\Windows\system32\sysprep\sysprep.xml" };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Looking for Cleartext Passwords in Common Files...");
            Console.ResetColor();
            foreach (string f in files)
            {
                if (File.Exists(f))
                {
                    Console.WriteLine(f + " Exists!");
                    string text = File.ReadAllText(f);
                    Console.WriteLine(text);
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Searching Registry Keys...");
            Console.ResetColor();
            string[] registries = { @"HKLM\SOFTWARE\Microsoft\Windows NT\Currentversion\Winlogon", @"HKLM\SYSTEM\Current\ControlSet\Services\SNMP", @"HKCU\Software\SimonTatham\PuTTY\Sessions", @"HKCU\Software\ORL\WinVNC3\Password", @"HKEY_LOCAL_MACHINE\SOFTWARE\RealVNC\WinVNC4" };
            foreach (string reg in registries)
            {
                string command = "reg query \"" + reg + "\"";
                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command);
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                string result = proc.StandardOutput.ReadToEnd();
                Console.WriteLine("------------------------------");
                Console.WriteLine(command);
                Console.WriteLine(result);
                Console.WriteLine("------------------------------");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dumping cmdkey Info...");
            Console.ResetColor();
            string command1 = "cmdkey /list";
            System.Diagnostics.ProcessStartInfo procStartInfo1 = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command1);
            procStartInfo1.RedirectStandardOutput = true;
            procStartInfo1.UseShellExecute = false;
            procStartInfo1.CreateNoWindow = true;
            System.Diagnostics.Process proc1 = new System.Diagnostics.Process();
            proc1.StartInfo = procStartInfo1;
            proc1.Start();
            string result1 = proc1.StandardOutput.ReadToEnd();
            Console.WriteLine("------------------------------");
            Console.WriteLine(command1);
            Console.WriteLine(result1);
            Console.WriteLine("------------------------------");
        }
        public static void unquoted()
        {
            string command = @"wmic service get name,displayname,pathname,startmode | findstr / i “auto” | findstr / i / v “c:windows\\” | findstr / i / v “””";
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command);
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            string result = proc.StandardOutput.ReadToEnd();
            Console.WriteLine("------------------------------");
            Console.WriteLine(result);
            Console.WriteLine("------------------------------");
        }
        public static void alwaysElevated()
        {
            string[] commands = { @"reg query HKCU\SOFTWARE\Policies\Microsoft\Windows\Installer /v AlwaysInstallElevated", @"reg query HKLM\SOFTWARE\Policies\Microsoft\Windows\Installer /v AlwaysInstallElevated" };
            foreach (string command in commands)
            {
                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command);
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                string result = proc.StandardOutput.ReadToEnd();
                Console.WriteLine("------------------------------");
                Console.WriteLine(result);
                Console.WriteLine("------------------------------");
                Console.WriteLine("");
            }

        }
    }
}
