using System;

namespace assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool IsLeapYear(int year) {
            if(year % 4 == 0) {
                if(year % 100 == 0){
                    return year % 400 == 0;
                } else{
                    return true;
                }
            } else {
                return false;
            }
        }



    }
}
