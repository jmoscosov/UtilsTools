using RGiesecke.DllExport;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace JMLogger
{
    public class JMLogger
    {
        private const byte CONTINUE = 0;

        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        public static unsafe byte Incoming(byte** message)
        {
            try
            {
                var msg = NDCMessageIn.FromMessagePointer(message);

                if (msg != null)
                {
                    var msgStr = msg.ToString();
                    Logger.Log($"-->  {msgStr}");

                }
            }
            catch (Exception ex)
            {
                Logger.Log($"EXCEPTION: {ex.Message}");
            }

            return CONTINUE;
        }

        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        public static unsafe byte Outgoing(byte** message)
        {
            try
            {
                var msg = NDCMessageOut.FromMessagePointer(message);

                if (msg != null)
                {
                    var msgStr = msg.ToString();
                    Logger.Log($"<--  {msgStr}");
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"EXCEPTION: {ex.Message}");
            }

            return CONTINUE;
        }

        private static string ReassembleMessage(string[] arr)
        {
            Logger.Log("Re-assembling message for AANDC");

            var sb = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0)
                    sb.Append((char)NDCMessage.FS);

                sb.Append(arr[i]);
            }

            var message = sb.ToString();

            Logger.Log($"Message was modified: {message}");

            return message;
        }

        private static string GetDataValue(string newValue, string currentValue = "")
        {
            if (string.IsNullOrEmpty(newValue))
                return string.Empty;

            if (string.IsNullOrEmpty(currentValue))
                return newValue.Replace("?", "");

            string data = null;
            string mask = null;

            if (newValue.Length < currentValue.Length)
            {
                data = currentValue;
                mask = newValue + new string('\0', currentValue.Length - newValue.Length);
            }
            else if (currentValue.Length < newValue.Length)
            {
                data = currentValue + new string('\0', newValue.Length - currentValue.Length);
                mask = newValue;
            }
            else
            {
                data = currentValue;
                mask = newValue;
            }

            if (!string.IsNullOrEmpty(newValue) && !string.IsNullOrEmpty(currentValue))
            {
                var sb = new StringBuilder();

                for (int i = 0; i < mask.Length; i++)
                {
                    if (mask[i] == '?')
                    {
                        if (data[i] != '\0')
                            sb.Append(data[i]);
                    }
                    else
                    {
                        if (mask[i] != '\0')
                            sb.Append(mask[i]);
                    }
                }

                return sb.ToString();
            }

            return newValue.Replace("?", "");
        }
    }
}
