using System;
using System.Collections.Generic;
using System.Linq;

namespace SpecialWords {
    class Program {
        static void Main(string[] args) {
            int input = int.Parse(Console.ReadLine());
            List<string> twoOrMoreA = new List<string>();
            List<string> sameStartAndEnd = new List<string>();
            List<string> notSpecialWords = new List<string>();
            int asd;
            char ch = 'a';

            for (int i = 0; i < input;i++) {
                string word = Console.ReadLine();
                asd = word.Split(ch).Length - 1;
                if (word[0] == word[word.Length - 1]) {
                    sameStartAndEnd.Add(word);
                }
                if (asd >= 2) {
                    twoOrMoreA.Add(word);
                }
                if(asd !> 2 & word[0] != word[word.Length - 1]){
                    notSpecialWords.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", sameStartAndEnd));
            Console.WriteLine(string.Join(", ", twoOrMoreA));
            Console.WriteLine(string.Join(", ", notSpecialWords));

        }
    }
}
