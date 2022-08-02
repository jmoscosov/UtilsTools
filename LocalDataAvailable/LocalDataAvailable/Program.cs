using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalScreens
{
    class Program
    {
         static void Main(string[] args)
        {
            Microsoft.Win32.RegistryKey key;
            Logger.Log($" JM185384 - Begin Procedure");
            Logger.Log($" JM185384 - Setting Registry");
            Environment.ExitCode = (int)exitCodes.Errors.success;
            key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node");
            if (key == null)
            {
                Logger.Log($" JM185384 - Configuring W7");
                try
                {
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\NCR\\Advance NDC");
                    Logger.Log($"Done!!");
                    Logger.Log($"Environment.ExitCode = {Environment.ExitCode}");
                }
                catch (System.UnauthorizedAccessException ex)
                {
                    Logger.Log($" JM185384 - UnauthorizedAccessException Advance NDC registry");
                    Environment.ExitCode = (int)exitCodes.Errors.failed;
                    Logger.Log($"Environment.ExitCode = {Environment.ExitCode}");

                }
               
            }
            else
            {
                Logger.Log($" JM185384 - Configuring W10");
                try
                {
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\NCR\\Advance NDC");
                    Logger.Log($"Done!!");
                    Logger.Log($"Environment.ExitCode = {Environment.ExitCode}");
                }
                catch (System.UnauthorizedAccessException ex)
                {

                    Logger.Log($" JM185384 - UnauthorizedAccessException Advance NDC registry");
                    Environment.ExitCode = (int)exitCodes.Errors.failed;
                    Logger.Log($"Environment.ExitCode = {Environment.ExitCode}");
                }
               
            }
            try
            {
                key.SetValue("Local Data Available", "1", Microsoft.Win32.RegistryValueKind.DWord);
            }
            catch (UnauthorizedAccessException ex)
            {
                Logger.Log($"UnauthorizedAccessException: {ex.Source}");
                Environment.ExitCode = (int)exitCodes.Errors.failed;
                Logger.Log($"Environment.ExitCode = {Environment.ExitCode}");
            }
            catch (System.Security.SecurityException ex)
            {
                Logger.Log($"SecurityException source: {ex.Source}");
                Environment.ExitCode = (int)exitCodes.Errors.failed;
                Logger.Log($"Environment.ExitCode = {Environment.ExitCode}");
            }
            catch (Exception ex)
            {
                Logger.Log($"Exception source: {ex.Source}");
                Environment.ExitCode = (int)exitCodes.Errors.failed;
                Logger.Log($"Environment.ExitCode = {Environment.ExitCode}");
            }
            finally
            {
                key.Close();
            }

            Logger.Log($"Environment.ExitCode = {Environment.ExitCode}");
            Environment.Exit(Environment.ExitCode);
        }
    }
}
