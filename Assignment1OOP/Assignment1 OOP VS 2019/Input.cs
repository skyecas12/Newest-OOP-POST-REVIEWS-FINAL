using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_OOP_VS_2019
{
    class Input
    {
        //Handles the text input for Assessment 1
        string text = "nothing";

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard


        //ChoiceOfMethod() method refers to which choice the user wants to take, only m/manual will work.
        
        //manualTextInput, this is for the user to enter their text manually.
        public string manualTextInput()
        {
            Console.WriteLine("Please enter an asterisk after inputting manual text!: ");
            Console.WriteLine(" ");
            text = Console.ReadLine();
            return text;
        }
        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        
        public string fileTextInput(string filename)
            //This method is for filetext input, this will allow the user to use a text based file to output a display.
        {
            text = File.ReadAllText(filename);
            return text;

        }
            
        
    }
}
