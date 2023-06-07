using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AANDC_CL;

namespace NDCBuffers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JM185384 - Setting Values AANDC");
           // int intMacMachineNumber = 0;
           // int intSecurityFlags = 0;
            string strMacMachineNumber = String.Empty;
            string strSecurityFlags = String.Empty;

            try
            {
                if (args[0].Equals("-get"))
                {

                    if ((args[1].Equals("-path")) && (args[2].Length > 0)) {

                        Logger.Log(args[2].Trim(), "Capturing Data");
                        GetCounters(args[2].Trim());
                        GetAccessData(args[2].Trim());
                        GetConfigureData(args[2].Trim());

                    }
                }
                else
                {
                    //Console.WriteLine($"El valor actual del buffer DefaultPrinter is : {NDCMessage.GetIntVal(3057).ToString()}");
                    Logger.Log($"El valor actual del buffer de impresora por default es : {NDCMessage.GetIntVal(3057).ToString()}");
                    if (args[1].Equals("-u"))
                    {
                        Logger.Log($"Uninstall : Realizando rollback de parametro en AANDC");
                        NDCMessage.PutStringVal(3057, "0");
                    }
                    else
                    {
                        NDCMessage.PutStringVal(3057, "1");
                    }
                    
                    
                    Logger.Log($"El valor despues de la modificacion del buffer de impresora por default es : {NDCMessage.GetIntVal(3057).ToString()}");
                    //Console.WriteLine($"El valor despues de la modificacion del buffer idDefaultPrinter is : {NDCMessage.GetIntVal(3057).ToString()}");

                    // NDCMessage.PutIntVal(3057, 1);
                }
                /*  intMacMachineNumber = NDCMessage.GetIntVal(4009);
                  intSecurityFlags = NDCMessage.GetIntVal(4010);

                  strMacMachineNumber = NDCMessage.GetStringVal(4009);
                  strSecurityFlags = NDCMessage.GetStringVal(4010);
                */
                /* int idNotesDispType1 = NDCMessage.GetIntVal(3091);
                 int idNotesDispType2 = NDCMessage.GetIntVal(3092);
                 int idNotesDispType3 = NDCMessage.GetIntVal(3093);
                 int idNotesDispType4 = NDCMessage.GetIntVal(3094);

                 int idNotesInType1 = NDCMessage.GetIntVal(3095);
                 int idNotesInType2 = NDCMessage.GetIntVal(3096);
                 int idNotesInType3 = NDCMessage.GetIntVal(3097);
                 int idNotesInType4 = NDCMessage.GetIntVal(3098);

                 int idNotesPurgedType1 = NDCMessage.GetIntVal(3099);
                 int idNotesPurgedType2 = NDCMessage.GetIntVal(3100);
                 int idNotesPurgedType3 = NDCMessage.GetIntVal(3101);
                 int idNotesPurgedType4 = NDCMessage.GetIntVal(3102);*/
                //Logger.Log($"MAC NUMBER : {strMacMachineNumber.ToString()} + {strSecurityFlags.ToString()} ");
                /* Logger.Log($"Notes In Cassette Type 1 :  {idNotesInType1.ToString("D5")}");
                 Logger.Log($"Notes In Cassette Type 2 :  {idNotesInType2.ToString("D5")}");
                 Logger.Log($"Notes In Cassette Type 3 :  {idNotesInType3.ToString("D5")}");
                 Logger.Log($"Notes In Cassette Type 4 :  {idNotesInType4.ToString("D5")}");
 *//*
                Console.WriteLine($"El valor del buffer intMacMachineNumber is : {intMacMachineNumber.ToString()}");
                Console.WriteLine($"El valor del buffer intSecurityFlagNumber is : {intSecurityFlags.ToString()}");

                Console.WriteLine($"El valor del buffer strMacMachineNumber is : {strMacMachineNumber.ToString()}");
                Console.WriteLine($"El valor del buffer strSecurityFlagNumber is : {strSecurityFlags.ToString()}");

                Console.WriteLine($"Notes Cassette Type 1 :  {idNotesInType1.ToString("D5")}");
                Console.WriteLine($"Notes Cassette Type 2 :  {idNotesInType2.ToString("D5")}");
                Console.WriteLine($"Notes Cassette Type 3 :  {idNotesInType3.ToString("D5")}");
                Console.WriteLine($"Notes Cassette Type 4 :  {idNotesInType4.ToString("D5")}");
                */

                /*NDCMessage.PutStringVal(4009, "005800");
                NDCMessage.PutStringVal(4010, "1100001000");
                */
                //NDCMessage.PutIntVal(4010, 1111111111);
                //NDCMessage.PutIntVal(4009, 000000);
                //Console.WriteLine($"El valor del buffer strMacMachineNumber is : {strMacMachineNumber.ToString()}");
                //Console.WriteLine($"El valor del buffer strSecurityFlagNumber is : {strSecurityFlags.ToString()}");
                /*  Console.WriteLine($"El valor del buffer strMacMachineNumber is : {strMacMachineNumber}");
                  Console.WriteLine($"El valor del buffer strSecurityFlagNumber is : {strMacMachineNumber}");*/
            }
            catch (Exception ex)
            {
                Logger.Log($"EXCEPTION CAPTURED : {ex.ToString()}");
                Console.WriteLine($"EXCEPTION CAPTURED : {ex.ToString() }");
            }
            //Console.ReadLine();


        }
        static void GetCounters(string LOGFile)
        {
            int idNotesDispType1 = NDCMessage.GetIntVal(3091);
            int idNotesDispType2 = NDCMessage.GetIntVal(3092);
            int idNotesDispType3 = NDCMessage.GetIntVal(3093);
            int idNotesDispType4 = NDCMessage.GetIntVal(3094);

            int idNotesInType1 = NDCMessage.GetIntVal(3095);
            int idNotesInType2 = NDCMessage.GetIntVal(3096);
            int idNotesInType3 = NDCMessage.GetIntVal(3097);
            int idNotesInType4 = NDCMessage.GetIntVal(3098);

            int idNotesPurgedType1 = NDCMessage.GetIntVal(3099);
            int idNotesPurgedType2 = NDCMessage.GetIntVal(3100);
            int idNotesPurgedType3 = NDCMessage.GetIntVal(3101);
            int idNotesPurgedType4 = NDCMessage.GetIntVal(3102);

            Logger.Log(LOGFile, "AANDC_Counters");
            Logger.Log(LOGFile, $"Notes Dispensed Type 1 {idNotesDispType1.ToString()}");
            Logger.Log(LOGFile, $"Notes Cassette Type 1 {idNotesInType1.ToString()}");
            Logger.Log(LOGFile, $"Notes Rejected Type 1 {idNotesPurgedType1.ToString()}");
            Logger.Log(LOGFile, $"Notes Dispensed Type 2 {idNotesDispType2.ToString()}");
            Logger.Log(LOGFile, $"Notes Cassette Type 2 {idNotesInType2.ToString()}");
            Logger.Log(LOGFile, $"Notes Rejected Type 2 {idNotesPurgedType2.ToString()}");
            Logger.Log(LOGFile, $"Notes Dispensed Type 3 {idNotesDispType3.ToString()}");
            Logger.Log(LOGFile, $"Notes Cassette Type 3 {idNotesInType3.ToString()}");
            Logger.Log(LOGFile, $"Notes Rejected Type 3 {idNotesPurgedType3.ToString()}");
            Logger.Log(LOGFile, $"Notes Dispensed Type 4 {idNotesDispType4.ToString()}");
            Logger.Log(LOGFile, $"Notes Cassette Type 4 {idNotesInType4.ToString()}");
            Logger.Log(LOGFile, $"Notes Rejected Type 4 {idNotesPurgedType4.ToString()}");
        }
        static void GetAccessData(string LOGFile)
        {
            string strMacMachineNumber = String.Empty;
            string strSecurityFlags = String.Empty;
            strMacMachineNumber = NDCMessage.GetStringVal(4009);
            strSecurityFlags = NDCMessage.GetStringVal(4010);

            Logger.Log(LOGFile, "AANDC_AccessData");
            Logger.Log(LOGFile, $"MAC NUMBER : {strMacMachineNumber.ToString() + strSecurityFlags.ToString()}");
            /*Logger.Log(LOGFile, strMacMachineNumber.ToString());
            Logger.Log(LOGFile, strSecurityFlags.ToString());*/
        }
        static void GetConfigureData(string LOGFile)
        {
            int idEJMode = NDCMessage.GetIntVal(3073);
            string strMessageMode = NDCMessage.GetStringVal(2080);
            Logger.Log(LOGFile, "AANDC_ConfigureData");
            Logger.Log(LOGFile, $"EJMode : {idEJMode.ToString()}");
            Logger.Log(LOGFile, $"MessageMode : {strMessageMode.ToString()}");
            /* Logger.Log(LOGFile, strMacMachineNumber.ToString());
             Logger.Log(LOGFile, strSecurityFlags.ToString());*/

        }
    }
}
