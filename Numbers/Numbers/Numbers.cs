using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers {
    class Program {
        static void Main(string[] args) {
            var nums = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();
            List<int> sumOfFivenNumbers = new List<int>();

            for (int i = 0;i < nums.Count;i++) {
                int sum = 0;
                int n = nums[i];
                while (n != 0) {
                    sum += n % 10;
                    n /= 10;
                }
                Console.WriteLine(sum);
                if (nums[i] % 2 ==0) {
                    evenNumbers.Add(nums[i]);
                }
                if(nums[i] % 2 != 0) {
                    oddNumbers.Add(nums[i]);
                }
                if (sum % 10 == 5 & nums[i] != 5) {
                    sumOfFivenNumbers.Add(nums[i]);
                }
            }
            Console.WriteLine(string.Join(", ", evenNumbers));
            Console.WriteLine(string.Join(", ", oddNumbers));
            Console.WriteLine(string.Join(", ", sumOfFivenNumbers));

        }
    }
}
