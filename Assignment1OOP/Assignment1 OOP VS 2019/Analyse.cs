using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_OOP_VS_2019
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text

        //these are arrays of characters, each with two sets of uppercase and two sets of lowercase, these will be used in for loops -
        //and later assigned to values to be used as lists in the output.
        char[] Not_VowelLower = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'y', 'v', 'x', 'z', 'w' };
        char[] Is_VowelLower = { 'a', 'e', 'i', 'o', 'u' };
        char[] Upper_Vowel = { 'A', 'E', 'I', 'O', 'U' };
        char[] Upper_Not_Vowel = { 'B', 'C', 'D', 'f', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'Y', 'V', 'X', 'Z', 'W' };
        char[] Sentence_Ends = { '.', '!', '?' };
        char[] Space_Between_Words = { ' ' };
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            int sentence_Count = 0;
            //2. Number of vowels

            int is_Vowel_Count = 0;
            //3. Number of consonants
            int consonant_count = 0;

            //4. Number of upper case letters
            int upper_Count = 0;
            //5. Number of lower ca4se letters
            int lower_count = 0;
            int Total_Letters = 0;
            int space_words = 0;
            
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            //foreach loops will iterate through the lists of every characters or punctuation given in above arrays - 
            //if it contains characters within the given array, it will enumerate to the integer variables given ++.
            foreach (char ch in input)
            {
                if (Upper_Not_Vowel.Contains(ch))
                {
                    upper_Count++;
                    consonant_count++;   
                }
            }
            foreach (char ch in input)
            {
                if (Upper_Vowel.Contains(ch))
                {
                    upper_Count++;
                    is_Vowel_Count++; 
                }
            }
            foreach (char ch in input)
            {
                if (Is_VowelLower.Contains(ch))
                {
                    lower_count++;
                    is_Vowel_Count++;
                }
            }
            foreach (char ch in input)
            {
                if(Not_VowelLower.Contains(ch))
                {
                    consonant_count++;
                    lower_count++;
                }
            }
            foreach (char ch in input)
            {
                if(Sentence_Ends.Contains(ch))
                {
                    sentence_Count++;
                }
            }
            foreach (char ch in input)
            {
                if(Space_Between_Words.Contains(ch))
                {
                    space_words++;
                }
            }

            //Total letters will equal all counted letters entered in the program.
            Total_Letters = lower_count + upper_Count;
            //A simple for loop which allows user to add and and assign their variables to a value which can be used and assigned as a list later in the report output. 
            for (int i = 0; i < 7; i++)
            {
                values.Add(0);
            }
            values[0] = lower_count;
            values[1] = upper_Count;
            values[2] = is_Vowel_Count;
            values[3] = consonant_count;
            values[4] = sentence_Count;
            values[5] = Total_Letters;
            values[6] = space_words;
            //values are being signed to an integer variable.
            return values;

            

        }
        
    }
}

