using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class Class1
    {


        public bool CheckMark(string mark)
        {
            if (mark.Length != 9)
            {
                return false;
            }

            if (!char.IsLetter(mark[0]) ||
                mark.Substring(1, 3).Any(m => !char.IsDigit(m)) ||
                mark.Substring(4, 2).Any(m => !char.IsLetter(m)) ||
                mark.Substring(6, 3).Any(m => !char.IsDigit(m)))
            {
                return false;
            }

            return true;
        }

        public String GetVINCountry(String vin)
        {
            char[] afrika = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            char[] azia = { 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'H' };
            char[] evropa = { 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] severnaamerika = { '1', '2', '3', '4', '5' };
            char[] okeania = { '6', '7' };
            char[] uhmaamerika = { '8', '9' };

            if (afrika.Contains(vin.ToCharArray()[0]))
            {
                return "Африка";
            }
            else
            if (azia.Contains(vin.ToCharArray()[0]))
            {
                return "Азия";
            }
            else
            if (evropa.Contains(vin.ToCharArray()[0]))
            {
                return "Европа";
            }
            else
            if (severnaamerika.Contains(vin.ToCharArray()[0]))
            {
                return " Северная Америка";
            }
            else
            if (okeania.Contains(vin.ToCharArray()[0]))
            {
                return " Океания";
            }
            else
            if (uhmaamerika.Contains(vin.ToCharArray()[0]))
            {
                return "  Южная Америка";
            }
            else
                return "Ошибка";

        }

        public int GetTransportYear(String vin)
        {
            string[] initials = vin.Split(' ');
            return Convert.ToInt32(vin.ToCharArray()[9]);

        }

    }
}
