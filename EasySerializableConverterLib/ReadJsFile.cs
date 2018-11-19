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
        public static List<string> testInt = new List<string>();
        public static List<string> testString = new List<string>();


        public void ReadJSFile(string path)
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
                    if (words[i] == "int" || words[i] == "string")
                    {
                        // Get the words after keywords.
                        for (int j = i + 1; j < words.Length; j++)
                        {
                            if (words[j] != "static")
                            {

                                InputNametoList(words[i], words[j]);
                                j = words.Length;
                            }
                        }
                    }
                }
            }


        }


        private void InputNametoList(string sKeyWord, string sName)
        {
            if (sName == null)
                return;

            switch (sKeyWord)
            {
                case "int":
                    testInt.Add(sName);
                    break;
                case "string":

                    testString.Add(sName);

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
                case "string":

                    return true;

                case "default":

                    return false;
            }

            return false;
        }

        public static ClClass CreateTestClassPrimitive()
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

            return output;
        }


    }
}
