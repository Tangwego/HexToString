using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetHex.Utils
{
    public class HexUtils
    {
        //E68891E788B1E4BDA0
        public String fromString(String input, String encoding) {
            byte[] buffer = getHexBytes(rmspace(input));
            if (buffer == null) {
                return "请输入正确的十六进制字符.";
            }
            String result = String.Empty;
            try
            {
                result = System.Text.Encoding.GetEncoding(encoding).GetString(buffer);
            }
            catch (Exception e) {
                result = e.Message;
            }
            return result;
        }
        //标准十六进制  48 65 6c 6c 6f 2c 43 23 21 21 21
        public String getStringFromHex(String hex, String encoding) 
        {
            String result = String.Empty;
            String[] values = hex.Split(' ');
            byte[] buffer = new byte[values.Length];

            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = Convert.ToByte(values[i], 16);
            }
            try
            {
                result = System.Text.Encoding.GetEncoding(encoding).GetString(buffer);
            }
            catch (Exception e) {
                result = e.Message;
            }
            
            return result;
        }

        public byte[] getHexBytes(String hexVal) {
            if (!isHexString(hexVal)) return null;
            if (hexVal.Length / 2 == 0) {
                hexVal += " ";
            }
            byte[] buffer = new byte[hexVal.Length / 2];
            for (int i = 0; i < buffer.Length; i++) {
                buffer[i] = Convert.ToByte((hexVal.Substring(i*2,2)),16);
            }
            return buffer;
        }

        public Boolean isHex(char ch) 
        {
            return (ch >= '0' && ch <= '9') || (ch >= 'A' && ch <= 'F') || (ch >= 'a' && ch <= 'f') || (ch == ' ');
        }

        public Boolean isHexString(String str)
        {
            int i = 0;
            Boolean ret = true;
            char[] values = str.ToCharArray();
            for (i = 0; i < values.Length; i++) {
                if (!isHex(values[i])){
                    ret = false;
                    break;
                }
            }
            return ret;
        }

        public String rmspace(String str) {
            char[] tmp = str.ToCharArray();
            String ret = String.Empty;
            for (int i = 0; i < tmp.Length; i++) 
            {
                if (tmp[i] == ' ' || tmp[i] == '\n' || tmp[i] == '\r')
                {
                    continue;
                }
                else {
                    ret += tmp[i];
                }
            }
            return ret;
        }

        
    }
}
