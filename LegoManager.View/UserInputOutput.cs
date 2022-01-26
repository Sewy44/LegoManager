using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoManager.View
{
    public class UserInputOutput
    {
        public string ReadString(string prompt)
        {
            string userInput = "";
             
            while(userInput == "")
            {
                Console.WriteLine(prompt);
                userInput = Console.ReadLine().Trim();

                if(userInput == "")
                {
                    Console.WriteLine("\nThat was not a valid input. Please try again.\n");
                }
            }
            return userInput;
        }

        public int ReadInt(string prompt, int min, int max)
        {
            int output;

            while (true)
            {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out output))
                {
                    if(output >= min && output <= max)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nThat was not a number between {0} and {1}. Please try again.\n", min, max);
                    }
                }
                else
                {
                    Console.WriteLine("\nThat was not a valid input. Please try again.\n");
                }
            }
            return output;
        }

        public int ReadYear(string prompt, int min, int max)
        {
            int output;

            while (true)
            {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine();
                if(int.TryParse(userInput, out output))
                {
                    if (output >= min && output <= max)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"\nLego was founding in 1949. Please enter a year between 1949 and 2021. Try again.\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nThat was not a valid input. Please try again.\n");
                }
            }
            return output;
        }

        public int ReadPieces(string prompt)
        {
            int output;

            while (true)
            {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out output))
                {
                    if (output > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease eneter a number greater than zero. Try again.\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nThat was not a valid input. Please try again.\n");
                }
            }
            return output;
        }
        public int ReadSetsOwned(string prompt)
        {
            int output;

            while (true)
            {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out output))
                {
                    if (output >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease eneter a number greater than or equal to zero. Try again.\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nThat was not a valid input. Please try again.\n");
                }
            }
            return output;
        }

        public int ReadDouble(string prompt)
        {
            double output;

            while (true)
            {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine();
                if (double.TryParse(userInput, out output))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nThat was not a valid input. Please try again.\n");
                }
            }
            return Convert.ToInt32(output);
        }

        public bool ReadKey()
        {
            while(Console.ReadKey().Key == ConsoleKey.Y)
            {
                return true;
            }
            return false;
        }


    }
}
