using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            string[] entries = Console.ReadLine().Split(" | ");
            string[] test = Console.ReadLine().Split(" | ");
            string final = Console.ReadLine();

            for (var i = 0; i < entries.Length; i++) {
                string name = entries[i].Split(": ")[0];
                string desc = entries[i].Split(": ")[1];

                if (dictionary.ContainsKey(name))
                    dictionary[name].Add(desc);
                else
                    dictionary.Add(name, new List<string>() {desc});
            }

            if (final == "Test") {
                foreach (string question in test)
                    if (dictionary.ContainsKey(question)) {
                        Console.WriteLine($"{question}:");
                        dictionary[question] = dictionary[question].OrderByDescending(desc => desc.Length).ToList();
                        dictionary[question].ForEach(desc => Console.WriteLine($" -{desc}"));
                    }
            } else {
                List<string> keys = dictionary.Keys.ToList();
                keys.Sort();
                Console.WriteLine(string.Join(" ", keys));
            }
        }
    }
}