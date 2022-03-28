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
        bool valid = false;


        //Gets text input from the keyboard
        public string manualTextInput()
        {
            // Loops while the text doesnt end in a *
            while (valid == false){

                // user input
                Console.Write("Enter the text: ");
                text = Console.ReadLine();

                // checks for *
                foreach (var i in text){
                    if (i.ToString() == "*"){
                        valid = true;
                    }
                }
            }
            return text;
        }


        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            // searches for the file given the partial name (must be .txt file)
            fileName = fileName + ".txt";
            string folderPath = @"C:\";
            DirectoryInfo dir= new DirectoryInfo(folderPath);
            FileInfo[] files = dir.GetFiles(fileName, SearchOption.TopDirectoryOnly);

            // loops for any found file (can only be 1) 
            // foreach loop is used as the above code returns a list of files 
            foreach (var item in files){
                using (var sr = new StreamReader(item.FullName)){
                    text = sr.ReadToEnd().ToString();
                }
            }

            // if the text is the default text (meaning no valid input) code is re-ran
            if (text == "nothing"){
                Console.WriteLine("File does not exist");
                Console.WriteLine("");
                Console.Write("Enter the files name: ");
                string file = Console.ReadLine();
                text = fileTextInput(file);
            }

            return text;
        }

    }
}
