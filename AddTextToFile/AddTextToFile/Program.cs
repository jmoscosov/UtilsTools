using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddTextToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args[0].Length <= 0)
            {
                Console.WriteLine("Content invalid");
            }else
            {
                Console.WriteLine("Texto to added: " + args[0]);
                if (args[1].Length <= 0)
                {
                    Console.WriteLine("Invalid Path");
                }
                Console.WriteLine("Path is : " + args[1]);

            }
           // File.AppendAllText(@"C:\Program Files\NCR APTRA\Advance NDC\Data\UCDIini.txt", "This is the new text" + Environment.NewLine);
            string strFileContents = "";
            string strDataToAppend = args[0];
            StreamReader srReader = null;
            StreamWriter swWriter = null;
            try
            {
               
                //File.SetAttributes(@"C:\Program Files\NCR APTRA\Advance NDC\Data\UCDIini.txt", FileAttributes.Normal);
                File.SetAttributes(args[1], FileAttributes.Normal);
                srReader = new StreamReader(args[1]);
                //srReader = new StreamReader(@"C:\Program Files\NCR APTRA\Advance NDC\Data\UCDIini.txt");
                strFileContents = srReader.ReadToEnd();
                srReader.Close();
                Console.WriteLine("READER OK");

                if(args[2] == "NL")
                {
                    strFileContents = strDataToAppend + Environment.NewLine + strFileContents;
                }else
                {
                    strFileContents = strDataToAppend + strFileContents;
                }
                //strFileContents = strDataToAppend + Environment.NewLine + strFileContents;
                //swWriter = new StreamWriter(@"C:\Program Files\NCR APTRA\Advance NDC\Data\UCDIini.txt", false);
                swWriter = new StreamWriter(args[1], false);
                // File.SetAttributes(file, FileAttributes.Normal);
                swWriter.Write(strFileContents);
                swWriter.Flush();
            }
            catch (Exception objException)
            {
                throw (objException);
            }
            finally
            {
                swWriter.Close();
            }
        }
    }
}
