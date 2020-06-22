using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        public static int[] RandomArray(){
            int[] IntArray = new int[10];
            Random Rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                IntArray[i] = Rand.Next(5,25);
                // Console.WriteLine(IntArray[i]);
            }
            int min = IntArray[0];
            int max = IntArray[0];
            int sum = 0;
            for (int i = 0; i < IntArray.Length; i++)
            {
                sum += IntArray[i];

                if(IntArray[i] < min){
                    min = IntArray[i];
                }
                if(IntArray[i] > max){
                    max = IntArray[i];                }
            }

            Console.WriteLine($"Min is {min}, Max is {max}, Sum is {sum}");
            //OR 
            // Console.WriteLine("Min is {0}, Max is {1}, Sum is {3}", min, max, sum);
            return IntArray;
        }
// =========================TossCoin================================
// Create a function called TossCoin() that returns a string
// Have the function print "Tossing a Coin!"
// Randomize a coin toss with a result signaling either side of the coin 
// Have the function print either "Heads" or "Tails"
// Finally, return the result
        public static string TossCoin(){
            // Console.WriteLine("Tossing a Coin!");
            Random Rand = new Random();
            string result = "";
            if(Rand.Next(10) <= 5 ){ // OR if(Rand.Next(2) == 1)
                result = "Tails";
            }
            else{
                result = "Heads";
            }
            // Console.WriteLine(result);

            return result;
        }
// ===================================TossMultipleCoins==========================================
//Create another function called TossMultipleCoins(int num) that returns a Double
// Have the function call the tossCoin function multiple times based on num value
// Have the function return a Double that reflects the ratio of head toss to total toss


        public static Double TossMultipleCoins(int num){
            Double headTimes = 0;
            for (int i = 1; i <= num; i++)
            {
                TossCoin();
                string outcome = TossCoin();
                if(outcome == "Heads"){
                    headTimes += 1;
                }
            }
            Console.WriteLine($" The Ratio: {headTimes/num}");
            Console.WriteLine($"The coin was tossed {num} times and got Heads {headTimes} times - {num} : {headTimes} ");

            return headTimes/num ; 
        }
// =====================================Names================================================
//Build a function Names that returns a list of strings.  In this function:
// Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
// Shuffle the list and print the values in the new order
// Return a list that only includes names longer than 5 characters
        public static List<string> Names(){

            List<string> Names  = new List<string>();
            Names.Add("Todd");
            Names.Add("Charlie");
            Names.Add("Tiffany");
            Names.Add("Geneva");
            Names.Add("You");
            Names.Add("Alexandra");
            Names.Add("Latifah");
            
            Random Rand = new Random();
            string temp = "";
            for (int i = 0; i < Names.Count ; i++)
                {
                    int indx = Rand.Next(Names.Count);
                    temp = Names[i];
                    Names[i] = Names[indx];
                    Names[indx] = temp;
                    Console.WriteLine(Names[indx]);
                }

            List<string> longNames = new List<string>();
            {
            for (int i = 0; i < Names.Count; i++)
                if(Names[i].Length > 5){
                    longNames.Add(Names[i]);
                    // Console.WriteLine(Names[i]);
                }

            }
            return Names;
        } 
        static void Main(string[] args)
        {
            // RandomArray();
            // TossCoin();
            // TossMultipleCoins(80);
            Names();
        }
    }
}
