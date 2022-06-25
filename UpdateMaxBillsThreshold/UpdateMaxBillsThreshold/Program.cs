using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateMaxBillsThreshold
{
    class Program
    {
        static void Main(string[] args)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\NCR\\Advance NDC\\CurrencyTable\\RejectBin\\");
            key.SetValue("MaxBillsThreshold", "200");
            key.Close();
        }
    }
}
