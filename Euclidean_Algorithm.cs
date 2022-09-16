using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace HelloWorld {
    class Program2 {

        //static integers defining the original inputs for the program
        public static int inputA = 45;
        public static int inputB = 210;


        /// <summary>
        /// Recursive method that takes two integers as input and returns the greatest common divisor.
        /// Uses Euclidean's Algorithm.
        /// </summary>
        /// <param name="x">The first input integer</param>
        /// <param name="y">The second input integer</param>
       public static void GreatestDivisor(int x, int y) {
            int a = x;
            int b = y;
            int result;

            if (a < b) { //if the second param is greater than the first, swap them so variable a is always the larger number
                a = y;
                b = x;
            }

            result = a % b; //calculate the remainder of dividing a and b

            if (result == 0) { //if result of modulo is zero, then the lowest common divisor is b
                Console.WriteLine("The highest common divisor of {0} and {1} is {2}", inputA, inputB, b);
            }
            else {
                GreatestDivisor(b, result); //recursive call
            }
        }

        // static void Main(string[] args) {
        //
        //     GreatestDivisor(inputA, inputB);
        // }
    }
}