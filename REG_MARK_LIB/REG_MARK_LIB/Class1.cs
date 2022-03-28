using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REG_MARK_LIB
{
    public class Class1
    {
        public Boolean CheckMark(String mark)
        {
            char[] bukv = { 'А', 'В', 'Е', 'К', 'М', 'Н', 'О', 'Р', 'С', 'Т', 'У', 'Х', 'A', 'B', 'E', 'K', 'M', 'H', 'O','P','C','T','Y','X'};

            if ( mark.Length == 9 && bukv.Contains(mark.ToCharArray()[0]))
                return true;
            else
                return false;
        }

        public String GetNextMarkAfter(String mark)
        {
            char[] bukv = { 'А', 'В', 'Е', 'К', 'М', 'Н', 'О', 'Р', 'С', 'Т', 'У', 'Х' };
            if (CheckMark(mark))
            {
                return mark;
                
            }
            int seria = int.Parse(mark.Substring(1, 3));
            string num = mark.Substring(2, 4);
            ++seria;

            string a = mark[0].ToString();

            if(true)
            {
                return mark;
            }
        }


        public String GetNextMarkAfterInRange(String prevMark, String rangeStart, String rangeEnd)
        {
            char[] bukv = { 'А', 'В', 'Е', 'К', 'М', 'Н', 'О', 'Р', 'С', 'Т', 'У', 'Х' };
            if (true)
            {
                return prevMark;
            }
            else
                return "Ошибка";
        }



        public int GetCombinationsCountInRange(String mark1, String mark2)
        {
            return Convert.ToInt32(mark2.ToCharArray()[0]);
        }
    }
}
