using System;

namespace jhClassLibrary
{
    public class MyLib
    {
        public static int Count(char deli, string str)            //str문자열의 deli 구분자 개수 
        {
            string[] Str = str.Split(deli);
            int n = Str.Length;
            return n - 1;

        }
        public static string getToken(int index, char deli, string str)
        {
            string[] Str = str.Split(deli);
            string ret = Str[index];
            return ret;

        }
    }
}
