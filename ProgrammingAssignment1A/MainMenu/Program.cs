using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question1;
using Question3;
using Question4;
using Question5;

namespace MainMenu
{
    class ProgramMainMenu
    {
        static void Main(string[] args)
        {
            {
                string choice;
                do
                {
                    Console.Clear();
                    Console.WriteLine("--- Main Menu ---\n\nType 1, 3, 4 or 5 for the corresponding program number: ");
                    int programNum = int.Parse(Console.ReadLine());
                    switch (programNum)
                    {
                        case 1:
                            ProgramQ1.Main();
                            break;
                        case 3:
                            ProgramQ3.Main();
                            break;
                        case 4:
                            ProgramQ4.Main();
                            break;
                        case 5:
                            ProgramQ5.Main();
                            break;
                        default:
                            Console.WriteLine("invalid input. Please try again.");
                            //-- https://stackoverflow.com/questions/11512821/how-to-stop-c-sharp-console-applications-from-closing-automatically
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            break;
                    }
                    Console.WriteLine("Enter y to go back to the main menu, enter any key to exit program");
                    choice = Console.ReadLine();
                } while (choice == "y");
            }
        }
    }
}
