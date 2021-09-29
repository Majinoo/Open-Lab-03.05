using System;

namespace Open_Lab_03._05
{
    public class Comparator
    {
        public bool MatchCaseInsensitive(string str1, string str2)
        {
            str1 = str1.ToUpper();
            str2 = str2.ToUpper();
            int x = str1.CompareTo(str2);
            if (x != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
