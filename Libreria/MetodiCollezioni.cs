using System;

namespace Libreria
{
    public class MetodiCollezioni
    {
        public static bool Uguali(string s1, string s2)
        {
            if (s1 == s2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Maiuscola(string s3)
        {
            int maiuscole = 0;
            for (int i = 0; i < s3.Length; i++)
            {
                if (Char.IsUpper(s3[i]) == true)
                    maiuscole++;
            }
            if (maiuscole > 0)
                return true;
            else
                return false;
        }
    }
}
