using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_OOP_VS_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();


            //Create 'Input' object
            //Get either manually entered text, or text from a file

            Report Output_user = new Report();
            Analyse analyse1 = new Analyse();
            Input decision = new Input();
            string text = "";

            while (true)
            {
                Console.WriteLine("Please type file for file text input, alternatively, type manual for manual text input!: ");
                string choice = Console.ReadLine();
                //reads the choice of which the user preferred to have their type of output as.
                choice = choice.ToLower();
                //the user choice = choice.ToLower makes it so the user will not have to worry about case-sensitivity
                if (choice == "m" || choice == "manual")
                {
                    text = decision.manualTextInput();
                    //text is reading text from the manual text input given from the user 
                    var outcome = analyse1.analyseText(text);
                    //create a variable which will check the text given by the file to analyse it -
                    // - through analyseText method.
                    Output_user.UserOutput(outcome);
                    //output user and outcome takes the text gained through analyse and forwards it into the reports method
                    break;
                     
                }
                else if (choice == "f" || choice == "file")
                {
                    //Try exception, if the program does run, it will continue, if it breaks, it will catch
                    //the break and instead print an error message and re-start.
                    try
                    {
                        Console.WriteLine("Please enter file input: ");
                        string fileLoc = Console.ReadLine();
                        string file = decision.fileTextInput(fileLoc);
                        var feedback = analyse1.analyseText(file);
                        //create a variable feedback to run through the analyseText function
                        Output_user.FileOutput(feedback);
                        break;
                    }
                    //catches the program if it has an errornous output.
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Incorrect file used, please restart.");
                        break;
                    }
                }
                //if the input key is different to manual or file. The user will be prompted to re-enter their key.
                else
                {
                    Console.WriteLine("INVALID INPUT, PLEASE RE-ENTER YOUR INPUT.");
                }

                //ignore the 4 lines of comment OLD CODE!//
                //else if (inputChoice.ToLower().Equals( "f" ) || (inputChoice.ToLower().Equals( "file")))

                //string DirectoryFile = Environment.CurrentDirectory;
                //string fileLocation = ("{currentDir\\Text File.txt");
                //text = input1.fileTextInput();



                //Create an 'Analyse' object
                //Pass the text input to the 'analyseText' method



                //Receive a list of integers back
            }


 


            //TO ADD: Get the frequency of individual letters?
        }
    }
}
