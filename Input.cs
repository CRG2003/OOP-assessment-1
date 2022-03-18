using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "nothing";

        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.Write("Enter the text: ");
            text = Console.ReadLine();
            return text;
        }

        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            fileName = fileName + ".txt";
            using (var sr = new StreamReader(fileName)){
                text = sr.ToString();
            }
            return text;
        }

    }
}
