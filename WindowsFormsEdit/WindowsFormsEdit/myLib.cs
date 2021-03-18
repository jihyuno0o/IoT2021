namespace myLibrary
{ 
    class myLib
    {
        public static int Count(char deli, string str)
        {
            string[] Strs = str.Split(deli);
            int n = Strs.Length;
            return n-1;
        }

        public static string GetToken(int index, char deli, string str)
        {
            string[] arr = str.Split(deli);

            return arr[index];
        }



}
}