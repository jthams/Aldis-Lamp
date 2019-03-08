using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldis_Lamp_BaseLogic
{
    class MorseTranslation
    {
        static void Main(string[] args)
        {
            try
            {
                Translation("This is just a test 0123");
                Console.ReadLine();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static StringBuilder Translation(string plainText)
        {
            // Convert user input to lower case to reduce the size of the dictionary
            string LplainText = plainText.ToLower();
            // Utilize a stringbuilder to append the dictionary value and return it as a string of morse code
            StringBuilder cypherText = new StringBuilder();
            // Parse through the given text and locate the key
            foreach (var item in LplainText)
            {
                if (MorseAlphabet.ContainsKey(item))
                {
                    // Append the key value to the stringbuilder object
                    cypherText.Append(MorseAlphabet[item]);
                }
                else
                {
                    throw new ArgumentException("Argument must be an alphanumeric character and may not contain special characters");
                }
                
            }
            Console.WriteLine(cypherText);
            return cypherText;
        }
        public static Dictionary<char, string> MorseAlphabet = new Dictionary<char, string>()
        {
            {'a', ".-" },{'b', "-..." },{'c', "-.-." },{'d', "-.." },{'e', "." },
            {'f', "..-." },{'g', "--." },{'h', "...." },{'i', ".." },{'j', ".---" },
            {'k', "-.-" }, {'l', ".-.." },{'m', "--" },{'n', "-." },{'o', "---" },
            {'p', ".--." },{'q', "--.-" },{'r', ".-." },{'s', "..." },{'t', "-" },
            {'u', "..-" },{'v', "...-" },{'w', ".--" },{'x', "-..-" },{'y', "-.--" },
            {'z', "--.." },{' ', "-------"},{'0',"-----"},{'1',".----"},{'2',"..---"}
            ,{'3',"...--"},{'4',"....-"},{'5',"-----"},{'6',"-...."},{'7',"--..."}
            ,{'8',"---.."},{'9',"----."}
        };
    }
}
