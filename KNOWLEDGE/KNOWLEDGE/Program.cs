using System;
namespace Knowledge
{

    class Program
    {

        static void Main(string[] args)
        {


            string learnerName = "";
            string governmentName = "Jayla Janae Corley";
            int learnerAge = 23;
            bool isJaylasBirthday = false;
     

            Console.Title = "knowledge 0.1";
        
            //Console.ForegroundColor = ConsoleColor.ConsoleColor.Green;

            Console.WriteLine("welcome to Knowledge. i'm eden, what's your name?");
            learnerName = Console.ReadLine();
            Console.WriteLine("ahh you're name is " + learnerName + ", i thought your name was " + governmentName + ".\nso what's good Jaylerrr? talk to me");
            Console.ReadLine();
            Console.WriteLine("i heard you have birfday coming up, is that true?");
            Console.ReadLine();
            Console.WriteLine("why i know it's true, you is " + learnerAge + " and finna be 24 in 14 days!! WHOOO ;)");
            Console.WriteLine("talk soon girl");
        }
    }






}



