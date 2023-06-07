using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace LocalScreens
{
    class Program
    {
        public static void Main(string[] args)
        {
            Microsoft.Win32.RegistryKey key,key2;
            if (args[0] == "/i")
            {
                Logger.Log("JM185384 - Install Command");
                Logger.Log(" JM185384 - Begin Procedure");
                Logger.Log(" JM185384 - Setting Registry");
                Environment.ExitCode = (int)exitCodes.Errors.success;
                key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\NCR\\Advance NDC");
                if (key == null)
                {
                    Logger.Log(" JM185384 - Configuring W7");
                    try
                    {
                        key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\NCR\\Advance NDC");
                        Logger.Log("Done!!");
                        Logger.Log("Environment.ExitCode =" + Environment.ExitCode);
                    }
                    catch (System.UnauthorizedAccessException ex)
                    {
                        Logger.Log(" JM185384 - UnauthorizedAccessException Advance NDC registry");
                        Environment.ExitCode = (int)exitCodes.Errors.failed;
                        Logger.Log("Environment.ExitCode =" + Environment.ExitCode);

                    }

                }
                else
                {
                    Logger.Log(" JM185384 - Configuring W10");
                    try
                    {
                        key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\NCR\\Advance NDC");
                        Logger.Log("Done!!");
                        Logger.Log("Environment.ExitCode =" + Environment.ExitCode);
                    }
                    catch (System.UnauthorizedAccessException ex)
                    {

                        Logger.Log("JM185384 - UnauthorizedAccessException Advance NDC registry");
                        Environment.ExitCode = (int)exitCodes.Errors.failed;
                        Logger.Log("Environment.ExitCode =" + Environment.ExitCode);
                    }

                }
                try
                {
                    Logger.Log("JM185384 - Setting Registry Value");
                    key.SetValue("Local Data Available", "1", Microsoft.Win32.RegistryValueKind.DWord);
                }
                catch (UnauthorizedAccessException ex)
                {
                    Logger.Log("UnauthorizedAccessException: " + ex.Source.ToString());
                    Environment.ExitCode = (int)exitCodes.Errors.failed;
                    Logger.Log("Environment.ExitCode =" + Environment.ExitCode);
                }
                catch (System.Security.SecurityException ex)
                {
                    Logger.Log("SecurityException source: " + ex.Source.ToString());
                    Environment.ExitCode = (int)exitCodes.Errors.failed;
                    Logger.Log("Environment.ExitCode =" + Environment.ExitCode);
                }
                catch (Exception ex)
                {
                    Logger.Log("Exception source:" + ex.Source.ToString());
                    Environment.ExitCode = (int)exitCodes.Errors.failed;
                    Logger.Log("Environment.ExitCode =" + Environment.ExitCode);
                }
                finally
                {
                  key.Close();
                }

                Logger.Log("Environment.ExitCode =" + Environment.ExitCode);
                Environment.Exit(Environment.ExitCode);
            }
            if (args[0] == "/u")
            {
                string strRootKey = "SOFTWARE\\WOW6432Node\\";
                string strSubKey = "NCR";
                Logger.Log("JM185384 - Uninstall Command");
                key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\NCR\\Advance NDC");
                //Microsoft.Win32.Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\NCR");
                //Logger.Log("JM185384 - RegKey Deleted");

                try
                {
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\NCR\\Advance NDC");
                    Logger.Log("JM185384 - Restore Registry Value");
                    key.SetValue("Local Data Available", "0", Microsoft.Win32.RegistryValueKind.DWord);
                    Logger.Log("JM185384 - Windows Registry Restored OK");
                }
                catch (UnauthorizedAccessException ex)
                {
                    Logger.Log("UnauthorizedAccessException: " + ex.Source.ToString());
                    Environment.ExitCode = (int)exitCodes.Errors.failed;
                    Logger.Log("Environment.ExitCode =" + Environment.ExitCode);
                }
                catch (System.Security.SecurityException ex)
                {
                    Logger.Log("SecurityException source:" + ex.Source.ToString());
                    Environment.ExitCode = (int)exitCodes.Errors.failed;
                    Logger.Log("Environment.ExitCode =" + Environment.ExitCode);
                }
                catch (Exception ex)
                {
                    Logger.Log("Exception source:" + ex.Source.ToString());
                    Environment.ExitCode = (int)exitCodes.Errors.failed;
                    Logger.Log("Environment.ExitCode =" + Environment.ExitCode);
                }
                finally
                {
                    key.Close();
                }

            }
        }
    }
}
