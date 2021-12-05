using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hogwarts {
    class Program {
        static void Main(string[] args) {
            string text = Console.ReadLine();
            string[] input;

            while ((input = Console.ReadLine().Split())[0] != "Abracadabra") {
                switch (input[0]) {
                    case "Abjuration":
                        Console.WriteLine(text = text.ToUpper());
                        break;

                    case "Necromancy":
                        Console.WriteLine(text = text.ToLower());
                        break;

                    case "Illusion":
                        int index = Convert.ToInt32(input[1]);

                        if (index > text.Length - 1) {
                            Console.WriteLine("The spell was too weak.");
                            break;
                        }

                        char replace = input[2].ToCharArray()[0];
                        char[] chars = text.ToCharArray();
                        chars[index] = replace;

                        text = new string(chars);

                        Console.WriteLine("Done!");
                        break;

                    case "Divination":
                        text = text.Replace(input[1], input[2]);
                        Console.WriteLine(text);
                        break;

                    case "Alteration":
                        text = text.Replace(input[1], "");
                        Console.WriteLine(text);
                        break;

                    default:
                        Console.WriteLine("The spell did not work!");
                        break;
                }
            }
        }
    }
}