using System;
using System.Collections.Generic;
using System.Linq;

namespace ScratchPad {
    class Program {
        static void Main(string[] args) {


            /* Lists Lecture
             * 
                Lists();
                EvenNumbers();
                MaxAndMin();
                Sequence();
                DeleteNegativeNumbers();
                SeperationLists();
                WholeSqareRoots();
                CountingNumbers(); 

             */

            
            /*
             * Methods Lecture
             * 
                double[] testArr = new double[] { 10, 20, 30, 40, 50, 60, 70 };


                IncrementArray(testArr, 3, 5);
                Console.WriteLine(String.Join(" ", testArr));
                NumberType(5);

                int[] generatedTestArr = GenerateNumbers(10, 20);
                Console.WriteLine(String.Join(", ", generatedTestArr));

                PrintPyramid(5);
            
            */

            // Multidimensional Arrays



        }

        // Lists Lecture

        static void Lists() {
            string input = Console.ReadLine();
            var words = input.Split(" ").ToList();

            words.Add("Hello"); // Index 0
            words.Add("Test"); // Index 1
            words.Add("123"); // Index 2
            words.Add("World"); // Index 3

            words.Remove("Test"); // Removing items by value
            words.RemoveAt(0); // Removing items by index

            Console.WriteLine(string.Join(" ", words));

            List<string> moreWords = new List<string>();
            moreWords.Add("This is");
            moreWords.Add("a test");

            words.AddRange(moreWords);  // Adding another data type to the list with AddRange();
            Console.WriteLine(string.Join(" ", words));
        }

        static void EvenNumbers() {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); // Listening for input [Everything in one line]

            List<int> evenNums = new List<int>(); // Creating another list for the even numbers only
            foreach (var num in nums) {
                if (num % 2 == 0) {
                    evenNums.Add(num);
                }
            } // Creating loop for checking all of the numbers for even ones

            Console.WriteLine(string.Join(' ', evenNums)); // Printing even numbers
        }

        static void MaxAndMin() {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); // Listening for input

            int max = input.Max(); // Creating a variable which will store the max value from the list
            int min = input.Min(); // Creating a variable which will store the min value from teh list

            foreach (var number in input) {
                if (number == max || number == min) {
                    Console.Write($"{number}; ");
                }
            }
        }

        static void Sequence() {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int longestLength = 1;
            int longestNumber = numbers[0];

            int lastLength = 1;
            int lastNumber = numbers[0];

            for (int i = 1; i < numbers.Count; i++) {
                int current = numbers[i];

                if (current == lastNumber) {
                    lastLength++;
                } else {
                    lastLength = 1;
                    lastNumber = current;
                }
                if (lastLength > longestLength) {
                    longestLength = lastLength;
                    longestNumber = lastNumber;
                }
            }

            for (int i = 0; i < longestLength; i++) {
                Console.Write($"{longestNumber} ");
            }
        }

        static void Removing() {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int globalLastNum = numbers[numbers.Count - 1]; // 1

            for (int i = 0; i < numbers.Count; i++) {
                if (numbers.Contains(globalLastNum)) {
                    numbers.Remove(globalLastNum);
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }

        static void DeleteNegativeNumbers() {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count;) {
                int current = numbers[i];
                if (current < 0) {
                    numbers.RemoveAt(i);
                } else {
                    i++;
                }
            }

            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }

        static void SeperationLists() {
            string input = Console.ReadLine();
            List<string> combinedList = input.Split('|').ToList();

           // Console.WriteLine(string.Join(" ",combinedList));
            combinedList.Reverse();

            List<int> allNumbers = new List<int>();
            string[] splitPattern = new string[] { " " };
            foreach (var subList in combinedList) {
                List<int> numbers = subList.Split(splitPattern, StringSplitOptions.RemoveEmptyEntries)
                                           .Select(int.Parse)
                                           .ToList();
                allNumbers.AddRange(numbers);
            }
            string output = string.Join(" ", allNumbers);
            Console.WriteLine(output);
            Console.ReadLine();
        }

        static void WholeSqareRoots() {
            string input = Console.ReadLine();
            List<int> numbers = input.Split().Select(int.Parse).ToList();

            List<int> wholeSqareRoots = new List<int>();

            foreach(var number in numbers) {

                double squareRoot = Math.Sqrt(number);
                if(squareRoot % 1 == 0) {
                    wholeSqareRoots.Add(number);
                }
            }

            string output = string.Join(" ", wholeSqareRoots);
            Console.WriteLine(output);
        }

        static void CountingNumbers() {
            string input = Console.ReadLine();
            List<int> numbers = input.Split().Select(int.Parse).ToList();

            // Array Method
            int[] counts = new int[numbers.Max() + 1];

            foreach(var number in numbers) {
                counts[number]++;
            }

            for(int i = 0;i < counts.Length;i++) {
                int count = counts[i];
                if(count != 0) {
                    Console.Write($"{i} -> {count}");
                }
            }

            // Sort Method
            numbers.Sort();
            int lastCount = -1;
            int lastNumber = numbers[0];

            foreach(var number in numbers) {
                if(number == lastNumber) {
                    lastCount++;
                } else {
                    Console.WriteLine($"{lastNumber} -> {lastCount}");
                    lastCount = 1;
                    lastNumber = number;
                }
            }
            Console.WriteLine($"{lastNumber} => {lastCount}");
        }

        // Methods Lecture

        static void PrintNumbers(int start,int end) {
            for(int i = start;i <= end;i++) {
                Console.WriteLine(i);
            }
        }

        static void IncrementArray(double[] array, int start,int end) {
            for(int i = start;i <= end;i++) {
                array[i] = array[i] + 1;
            }
        }

        static void NumberType(int num) {
            if (num < 0) {
                Console.WriteLine($"{num} is negative");
            } else if (num == 0) {
                Console.WriteLine($"{num} is zero");
            } else {
                Console.WriteLine($"{num} is positive");
            }
        }

        static int[] GenerateNumbers(int start, int end = 100) {
            int count = end - start;
            int[] generated = new int[count + 1];

            for(int i = start;i <= end; i++) {
                int index = i - start;
                generated[index] = i;
            }

            return generated;
        }

        static void PrintPyramid(int peak) {
            for(int currentPeak = 1; currentPeak <= peak;currentPeak++ ) {
                PrintTriangleNums(1, currentPeak);
            }
            for (int currentPeak = peak; currentPeak >= 0; currentPeak--) {
                PrintTriangleNums(1, currentPeak); 
            }
        }

        static void PrintTriangleNums(int start,int end) {
            for (int i = start;i<= end;i++) {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        // Multidimensional Arrays



    }
}








