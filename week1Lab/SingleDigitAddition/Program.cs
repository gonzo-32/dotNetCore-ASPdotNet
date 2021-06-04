using System;

namespace SingleDigitAddition
{
    class Program
    {
        private static readonly Random getrandomInt = new Random();
        static void Main(string[] args)
        {
            int min = 0;
            int max = 11;

            while(true) {
                int num1 = RandomNumber(min, max);

                int num2 = RandomNumber(min, max);
        
                string q = "Question: " + num1 + " + " + num2 + " = ";

                Console.WriteLine(q);

                int ans = Convert.ToInt32(Console.ReadLine());

                if(ans == num1+num2) {
                    Console.WriteLine("CORRECT");

                    Console.WriteLine("Next Question (y,n): ");

                    string res = Console.ReadLine();

                    if(res.Equals("y") || res.Equals("Y")){
                        Console.WriteLine("-----------------------------------------");
                    }
                    else{
                        
                        Console.WriteLine("Program Close!!");
                        break;
                    }
                }
                else {
                    int val = num1+num2;
                    string correctAns = val.ToString();
                    Console.WriteLine("INCORRECT!!! " + "The Correct answer is " + correctAns);
                    
                    Console.WriteLine("Try Again?? (y,n): ");

                    string res = Console.ReadLine();

                    if(res.Equals("y") || res.Equals("Y")){
                        Console.WriteLine("-----------------------------------------");
                    }
                    else{
                        
                        Console.WriteLine("Program Close!!");
                        break;
                    }
                }

            }
        }

        public static int RandomNumber(int min, int max){
            return getrandomInt.Next(min, max);
        }
    }
}
