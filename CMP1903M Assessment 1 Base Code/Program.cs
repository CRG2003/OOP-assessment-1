//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    { 
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            Input i = new Input();
            //Get either manually entered text, or text from a file
            string choice = "";
            string text = "";

            while (choice != "1" && choice != "2"){
                Console.Write("Choose to enter text manually (1) or read from a text file (2): ");
                choice = Console.ReadLine();
            }
            if (choice == "1"){
                text = i.manualTextInput();
            }
            if (choice == "2"){
                Console.Write("Enter the files name: ");
                string file = Console.ReadLine();
                text = i.fileTextInput(file);
            }

            //Create an 'Analyse' object
            Analyse a = new Analyse();
            //Pass the text input to the 'analyseText' method
            //Receive a list of integers back
            List<int> values = a.analyseText(text);


            //Report the results of the analysis
            Console.WriteLine("");
            Console.WriteLine("Number of sentances: " + values[0]);
            Console.WriteLine("Number of vowels: " + values[1]);
            Console.WriteLine("Number of consonants: " + values[2]);
            Console.WriteLine("Number of upper case letters: " + values[3]);
            Console.WriteLine("Number of lower case letters: " + values[4]);


            //TO ADD: Get the frequency of individual letters?

           
        }
    }
}
