using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FixM19
{
    class Program
    {
        static void Main(string[] args)
        {
            Microsoft.Win32.RegistryKey key, key2;
           // key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\ATM\\DEVINFO\\CDM");
           // key2 = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\NCR\\Advance NDC\\supervisor");
            key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\NCR\\Advance NDC\\PRINTING\\RECEIPT");
            // key2 = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\NCR\\Advance NDC\\PRINTING\RECEIPT");

            //LoggerClass.Log($"Fix M19 Running");
            LoggerClass.Log($"Fix printer DN Running");
            if (args[0] == "/i")
            {

                try
                {
                    //Console.WriteLine("Install Command Fix M19");
                    Console.WriteLine("Install Command Fix printer DN");
                    //key.SetValue("ShutterLockCheckInPresent", "0", Microsoft.Win32.RegistryValueKind.DWord);
                    //key.SetValue("DisableCaptureIfPageNotTaken", "1", Microsoft.Win32.RegistryValueKind.DWord);
                    key.SetValue("DisableCaptureIfPageNotTaken", "1", Microsoft.Win32.RegistryValueKind.DWord);
                    //key2.SetValue("EnableAERFlagDuringSimSupervisor", "0", Microsoft.Win32.RegistryValueKind.DWord);
                    //key2.SetValue("SuppressSupervisorAERMessages", "2", Microsoft.Win32.RegistryValueKind.DWord);
                    //LoggerClass.Log($"Fix M19 Installation process completed");
                    LoggerClass.Log($"Fix Printer DN Installation process completed");

                }
                catch (UnauthorizedAccessException ex)
                {

                    Console.WriteLine("UnauthorizedAccessException: {0}", ex.Source);
                }
                catch (System.Security.SecurityException ex)
                {
                    Console.WriteLine("SecurityException source: {0}", ex.Source);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception source: {0}", ex.Source);
                }


            }
            else
            {
                try
                {
                    //Console.WriteLine("Uninstall Command Fix M19");
                    Console.WriteLine("Uninstall Command Fix printer DN");
                    //key.SetValue("ShutterLockCheckInPresent", "1", Microsoft.Win32.RegistryValueKind.DWord);
                    key.SetValue("DisableCaptureIfPageNotTaken", "0", Microsoft.Win32.RegistryValueKind.DWord);
                    //key2.SetValue("EnableAERFlagDuringSimSupervisor", "0", Microsoft.Win32.RegistryValueKind.DWord);
                    //key2.SetValue("SuppressSupervisorAERMessages", "0", Microsoft.Win32.RegistryValueKind.DWord);
                    LoggerClass.Log($"Fix printer DN Uninstallation process completed");

                }
                catch (UnauthorizedAccessException ex)
                {

                    Console.WriteLine("UnauthorizedAccessException: {0}", ex.Source);
                }
                catch (System.Security.SecurityException ex)
                {
                    Console.WriteLine("SecurityException source: {0}", ex.Source);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception source: {0}", ex.Source);
                }

            }
            key.Close();
           // key2.Close();
        }
    }
}
