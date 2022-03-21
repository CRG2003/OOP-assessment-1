using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {

            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters

            List<int> values = new List<int>();

            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }

            // loops for every character in the text input
            foreach (char c in input){

                // ends analysis when * is found
                if (c.ToString() == "*"){
                    break;
                }

                // counts sentances (if no '.'s then it counts as 1 sentance)
                bool noPoint = input.IndexOf(".") >= 0;
                if (c.ToString() == "."){
                    values[0] += 1;
                }
                if (noPoint == false){
                    values[0] = 1;
                }

                // counts vowels and consonants
                bool isVowel = "aeiouAEIOU".IndexOf(c) >= 0;
                if (isVowel){
                    values[1] += 1;
                }
                else if (c.ToString() != " " && c.ToString() != "."){
                    values[2] += 1;
                }

                // counts upper and lower case letters
                bool isUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf(c) >= 0;
                if (isUpper){
                    values[3] += 1;
                }
                else if (c.ToString() != " " && c.ToString() != "."){
                    values[4] += 1;
                }
            }

            return values;
        }
    }
}
