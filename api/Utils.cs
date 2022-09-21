namespace Api
{
    class Utils
    {
        //  formatted log
        public static void Log(string s, params object[] args)
        {
            System.Console.WriteLine(string.Format(s, args));
        }

        //  unformatted log 
        public static void Log(string s)
        {
            System.Console.WriteLine(s);
        }
    }
}