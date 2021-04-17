using System;

namespace EasterEggs {
    class Program {
        static void Main(string[] args) {
            int input = int.Parse(Console.ReadLine());
            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;
            string maxEggs = "";
              

            for(int i = 0; i < input;i++) {
                string color = Console.ReadLine();
                if (color == "orange") {
                    orange++;
                } else if (color == "blue") {
                    blue++;

                } else if (color == "green") {
                    green++;
                } else if(color == "red") {
                    red++;
                }
            }
            if(orange > blue & orange > green & orange > red) {
                maxEggs = $"{orange} -> orange"; 
            } else if(blue > orange & blue > green & blue > red) {
                maxEggs = $"{blue} -> blue";
            } else if(green > blue & green > orange & green > red) {
                maxEggs = $"{green} -> green";
            } else if(red > orange & red > green & red > blue) {
                maxEggs = $"{red} -> red";
            }
            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: { orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max Eggs: {maxEggs}");
        }
    }
}
