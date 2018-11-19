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
        private static List<string> testInt = new List<string>();
        private static List<string> testString = new List<string>();
        private static List<string> testByte = new List<string>();
        private static List<string> testFloat = new List<string>();

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

                                InputNametoList(words[i], words[j]);
                                j = words.Length;
                            }
                        }
                    }
                }
            }

            return CreateTestClassPrimitive();


        }

        private bool bCheckingIsFunction(string[] sWord, int iCurPos, int iLength)
        {
            //Check previous words contain "(" or not
            if (sWord[iCurPos - 1].Contains("("))
            {
                return true;
            }

            if (sWord[iCurPos].Contains("(") || sWord[iCurPos].Contains(")"))
            {
                return true;
            }

            Console.WriteLine("iCur :" + iCurPos + " iLength " + iLength);

            if (iCurPos + 1 < iLength && sWord[iCurPos + 1].Contains("(") || iCurPos + 1 < iLength && sWord[iCurPos + 1].Contains(")"))
            {
                return true;
            }

            return false;
        }

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

                case "default":

                    break;
            }

        }

        private bool bKeyWordChecking(string sKeyWord)
        {
            switch (sKeyWord)
            {
                case "int":
                case "Byte":
                case "String":
                case "string":
                case "float":

                    return true;

                case "default":

                    return false;
            }

            return false;
        }

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

            return output;
        }


    }
}
