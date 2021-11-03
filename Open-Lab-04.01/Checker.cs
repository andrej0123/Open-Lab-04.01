using System;

namespace Open_Lab_04._01
{
    public class Checker
    {
        public bool DoubleLetters(string str)
        {
            {
                for (int i = 0; i < str.Length -1; i++)
                {
                    char c = str[i];
                 
                    if (c == str[i + 1])
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}
