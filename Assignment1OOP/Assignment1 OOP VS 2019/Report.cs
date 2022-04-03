using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_OOP_VS_2019
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)



        public void UserOutput(List<int> list)
        {
            //Prints out the output of the users entered text from assigned values.
            Console.WriteLine("Total number of Lower count letters used are: " + list[0]);
            Console.WriteLine("Total number of upper count letters used are: " + list[1]);
            Console.WriteLine("Total number of vowels letters used are: " + list[2]);
            Console.WriteLine("Total number of Consonants used are: " + list[3]);
            Console.WriteLine("Total number of Sentence endings used are: " + list[4]);
            Console.WriteLine("Total number of total letters used are: " + list[5]);
            Console.WriteLine("Total number of Spaces used are: " + list[6]);
        }

        public void FileOutput(List<int> list)
        {
            //prints out the putput of the file text with assigned values.
            Console.WriteLine("Total number of Lower count letters used are: " + list[0]);
            Console.WriteLine("Total number of upper count letters used are: " + list[1]);
            Console.WriteLine("Total number of vowels letters used are: " + list[2]);
            Console.WriteLine("Total number of Consonants used are: " + list[3]);
            Console.WriteLine("Total number of Sentence endings used are: " + list[4]);
            Console.WriteLine("Total number of total letters used are: " + list[5]);
            Console.WriteLine("Total number of Spaces used are: " + list[6]);
        }
    }
}
