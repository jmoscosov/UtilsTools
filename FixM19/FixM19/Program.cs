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
            Microsoft.Win32.RegistryKey key,key2;
            key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\ATM\\DEVINFO\\CDM");
            key2 = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\NCR\\Advance NDC\\supervisor");

            try
            {
                key.SetValue("ShutterLockCheckInPresent", "0", Microsoft.Win32.RegistryValueKind.DWord);
                key2.SetValue("EnableAERFlagDuringSimSupervisor", "0", Microsoft.Win32.RegistryValueKind.DWord);
                key2.SetValue("SuppressSupervisorAERMessages", "2", Microsoft.Win32.RegistryValueKind.DWord);


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
            
            key.Close();
        }
    }
}
