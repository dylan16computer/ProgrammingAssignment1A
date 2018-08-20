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
        static string choice = "y";
        static int programNum;
        static void Main(string[] args)
        {
            {
                while(choice == "y")
                {
                    while (programNum != 1 || programNum != 3 || programNum != 4 || programNum != 5)
                    {
                        Console.Clear();
                        Console.WriteLine("--- Main Menu ---\n\nType 1, 3, 4 or 5 for the corresponding program number: ");
                        programNum = int.Parse(Console.ReadLine());
                        //if (int.TryParse(programNum, out int check))
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
                                    ////-- https://stackoverflow.com/questions/11512821/how-to-stop-c-sharp-console-applications-from-closing-automatically
                                    //System.Threading.Thread.Sleep(1000);
                                    //Console.Clear();
                                    //Console.WriteLine("Enter y to go back to the main menu, enter n to exit program");
                                    //choice = Console.ReadLine();
                                    Console.Clear();
                                    break;
                            }
                    }
                    Console.WriteLine("Enter y to return to Main Menu, enter n to close program");
                    choice = Console.ReadLine();
                    if(choice == "n")
                    {
                        Console.WriteLine("Program shutting down...");
                        //-- https://stackoverflow.com/questions/11512821/how-to-stop-c-sharp-console-applications-from-closing-automatically
                        System.Threading.Thread.Sleep(1000);
                        //-- https://stackoverflow.com/questions/5682408/command-to-close-an-application-of-console
                        Environment.Exit(0);
                    }
                    while (choice != "y")
                    {
                        Console.WriteLine("invalid input. Try again.");
                        choice = Console.ReadLine();
                        if (choice == "n")
                        {
                            //-- https://stackoverflow.com/questions/5682408/command-to-close-an-application-of-console
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }
    }
}
