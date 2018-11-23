using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EasySerializableConverterLib
{
    public class LoadJsFile
    {
        private static List<string> testInt = new List<string>();           // List of string to store the file int variable name
        private static List<string> testString = new List<string>();        // List of string to store the file string variable name
        private static List<string> testByte = new List<string>();          // List of string to store the file byte variable name
        private static List<string> testFloat = new List<string>();         // List of string to store the file float variable name
        private static List<string> testListInt = new List<string>();       // List of string to store the file List int variable name
        private static List<string> testListString = new List<string>();    // List of string to store the file List variable name

        // read js file and return to ClClass
        public ClClass ReadJSFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            // Display the file contents by using a foreach loop.
            Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                string[] words = line.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    // To check the var keyword ( int, string, float, byte)
                    if (bKeyWordChecking(words[i]))
                    {
                        // Get the words after keywords.
                        for (int j = i + 1; j < words.Length; j++)
                        {
                            if (words[j] != "static" && !bCheckingIsFunction(words, j, words.Length))
                            {

                                if (bCorrectInput(words[j]))
                                {
                                    InputNametoList(words[i], words[j]);
                                }
                                j = words.Length;
                            }
                        }
                    }
                }
            }

            return CreateTestClassPrimitive();


        }

        // To check this line whether is a function not that. to check does it contain those special word
        private bool bCheckingIsFunction(string[] sWord, int iCurPos, int iLength)
        {
            //Check previous words contain "(" or not
            if (sWord[iCurPos - 1].Contains("("))
            {
                return true;
            }

            //Check current words is it contain any special word
            if (sWord[iCurPos].Contains("(") || sWord[iCurPos].Contains(")") || sWord[iCurPos].Contains(",") )
            {
                return true;
            }

            //Check next words is it contain any special word
            if (iCurPos + 1 < iLength && (sWord[iCurPos + 1].Contains("(") || sWord[iCurPos + 1].Contains(")") || sWord[iCurPos].Contains(",")))
            {
                return true;
            }

            return false;
        }

        // Remove the special char which the words contain
        private string SpecialWordHandler(string sWord)
        {

            if (sWord.Contains("="))
            {
                return sWord.Split('=')[0];
            }
            else if (sWord.Contains("{"))
            {
                return sWord.Split('{')[0];
            }
            else if (sWord.Contains(";"))
            {
                return sWord.Split(';')[0];
            }

            return sWord;
        }

        // Save those value name into the list for output use
        private void InputNametoList(string sKeyWord, string sName)
        {
            if (sName == null)
                return;

            sName = SpecialWordHandler(sName);

            switch (sKeyWord)
            {
                case "int":
                    testInt.Add(sName);
                    break;
                case "Byte":
                    testByte.Add(sName);
                    break;
                case "String":
                case "string":

                    testString.Add(sName);

                    break;
                case "float":
                    testFloat.Add(sName);

                    break;
                case "List<int>":
                case "<int>":
                    testListInt.Add(sName);

                    break;
                case "List<string>":
                case "List<String>":
                case "<String>":
                case "<string>":
                    testListString.Add(sName);

                    break;
                case "default":

                    break;
            }

        }

        // to check whether the input words is correct or not.
        private bool bCorrectInput(string sWord)
        {
            if (sWord.Contains("<") || sWord.Contains(">"))
            {
                return false;
            }
            else if (sWord.Contains("-") || sWord.Contains("~"))
            {
                return false;
            }

            return true;
        }


        // To check whether this line contain the var key word
        private bool bKeyWordChecking(string sKeyWord)
        {
            switch (sKeyWord)
            {
                case "int":
                case "Byte":
                case "String":
                case "string":
                case "float":
                case "List<int>":
                case "<int>":
                case "List<string>":
                case "List<String>":
                case "<String>":
                case "<string>":
                   
                    return true;

                case "default":

                    return false;
            }

            return false;
        }

        // Read all list and save to ouput fileds to ClClass
        public ClClass CreateTestClassPrimitive()
        {
            var output = new ClClass("Primitive Class");

            foreach (string sName in testInt)
            {
                output.Fields.Add(new ClField(sName, typeof(int)));
            }
            foreach (string sName in testString)
            {
                output.Fields.Add(new ClField(sName, typeof(string)));
            }
            foreach (string sName in testByte)
            {
                output.Fields.Add(new ClField(sName, typeof(Byte)));

            }
            foreach (string sName in testFloat)
            {
                output.Fields.Add(new ClField(sName, typeof(float)));

            }

            foreach (string sName in testListInt)
            {
                output.Fields.Add(new ClEnumerableField(sName, typeof(int)));
            }

            foreach (string sName in testListString)
            {
                output.Fields.Add(new ClEnumerableField(sName, typeof(string)));
            }

            return output;
        }


    }
}
