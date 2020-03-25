using System;
using System.Linq;

namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] morseMessage = Console.ReadLine().Split("|").Select(x => x.Trim()).ToArray();
            string finalMessage = "";

            foreach (var morseWord in morseMessage)
            {
                string[] letters = morseWord.Split();
                foreach (var letter in letters)
                {
                    switch (letter)
                    {
                        case ".-":
                            finalMessage += "A";
                            break;
                        case "-...":
                            finalMessage += "B";
                            break;
                        case "-.-.":
                            finalMessage += "C";
                            break;
                        case "-..":
                            finalMessage += "D";
                            break;
                        case ".":
                            finalMessage += "E";
                            break;
                        case "..-.":
                            finalMessage += "F";
                            break;
                        case "--.":
                            finalMessage += "G";
                            break;
                        case "....":
                            finalMessage += "H";
                            break;
                        case "..":
                            finalMessage += "I";
                            break;
                        case ".---":
                            finalMessage += "J";
                            break;
                        case "-.-":
                            finalMessage += "K";
                            break;
                        case ".-..":
                            finalMessage += "L";
                            break;
                        case "--":
                            finalMessage += "M";
                            break;
                        case "-.":
                            finalMessage += "N";
                            break;
                        case "---":
                            finalMessage += "O";
                            break;
                        case ".--.":
                            finalMessage += "P";
                            break;
                        case "--.-":
                            finalMessage += "Q";
                            break;
                        case ".-.":
                            finalMessage += "R";
                            break;
                        case "...":
                            finalMessage += "S";
                            break;
                        case "-":
                            finalMessage += "T";
                            break;
                        case "..-":
                            finalMessage += "U";
                            break;
                        case "...-":
                            finalMessage += "V";
                            break;
                        case ".--":
                            finalMessage += "W";
                            break;
                        case "-..-":
                            finalMessage += "X";
                            break;
                        case "-.--":
                            finalMessage += "Y";
                            break;
                        case "--..":
                            finalMessage += "Z";
                            break;
                        default:
                            break;
                    }
                }
                finalMessage += " ";
            }
            Console.WriteLine(finalMessage);
        }
    }
}
