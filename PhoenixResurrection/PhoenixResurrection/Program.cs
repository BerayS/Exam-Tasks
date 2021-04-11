using System;
using System.Collections.Generic;


namespace PhoenixResurrection {
    class Program {
        static void Main(string[] args) {
            int input = int.Parse(Console.ReadLine());
            double[,] array2Da = new double[input, 3];

            int uBound0 = array2Da.GetUpperBound(0);
            int uBound1 = array2Da.GetUpperBound(1);
            for (int i = 0; i <= uBound0; i++) {
                for (int j = 0; j <= uBound1; j++) {
                    double asd = double.Parse(Console.ReadLine());
                    array2Da[i, j] = asd;
                }
            }
            int cols = array2Da.GetLength(0);
            double result = 0;
            for (int i = 0; i < cols; i++) {
                result = Math.Pow(array2Da[i, 0],2) * (array2Da[i, 1] + 2 * array2Da[i, 2]);
                Console.WriteLine(result);
            }
            // Module 2 Prep Task
    }
    }
}
