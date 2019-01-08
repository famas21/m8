using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace m8
{
    class Program
    {
        static void Main(string[] args)
        {
            //preserve current console text color 
            
            
            ConsoleColor bcolor = Console.BackgroundColor;

            printthenameofapp();

            //creat random object 
            Random rendomObject = new Random();

            Console.BackgroundColor = bcolor;
            SpeechSynthesizer synth = new SpeechSynthesizer();


            while (true)
            {
                string questionString = getqfromuser();



                //see if q = 0 
                if (questionString.Length == 0)

                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    
                    Console.WriteLine("you need to type a qustion fool!");
                    synth.Speak("you need to type a qustion fool!");
                    continue;
                }

                //see if the user typed 'quit' as q
                else if (questionString.ToLower() == "quit")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    

                    Console.WriteLine("bye");
                    break;


                }
                else
                {

                    int numberofsecoundtosleep = rendomObject.Next(3) + 1;

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("thinking . . .");
                    Thread.Sleep(numberofsecoundtosleep * 1000);


                    Random random = new Random();

                    int randnumb = rendomObject.Next(4);

                    switch (randnumb)
                    {
                        case 0:
                            Console.WriteLine("yes!!!");
                            synth.Speak("yes!!!");
                            
                            break;
                        case 1:
                            Console.WriteLine("noo!");
                            synth.Speak("noo!");
                            
                            break;
                        case 2:
                            
                            Console.WriteLine("OMG no!!");
                            synth.Speak("OMG no!!");
                            break;
                        case 3:
                            
                            Console.WriteLine("Holyshit yes");
                            synth.Speak("Holyshit yes");
                            break;
                    }
                }
            }
        }
        /// <summary>
        /// to prin the name of the app  
        /// </summary>
        static void printthenameofapp()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            //change console color 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("M8");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Hi, I'm m8, What is your name?");
            synth.Speak("Hi, I'm m8, What is your name?");
            
            
            
        }
        /// <summary>
        /// ask and read
        /// </summary>
        /// <returns></returns>
        static string getqfromuser()
        {

            //ask the user 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Ask a question? ");

            Console.ForegroundColor = ConsoleColor.White;


            //take input from the user
            string questionString = Console.ReadLine();

            return questionString;
            
        }
    }
}
