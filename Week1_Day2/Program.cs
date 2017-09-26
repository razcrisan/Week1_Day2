using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //An int is a whole number (no decimals)
            //A string is a collection of characters

            char firstInitial = 'D';
            //Characters or chars are single letters or numbers

            bool isTired = true;
            //Boolean or bool is true or false

            //Other number data types

            float number = 2.1638499201857392f;
            decimal partialNum = 2.1638499201857392m;
            double someNumber = 2.1638499201857392d;

            Console.WriteLine(number);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNumber);

            //Now, let's talk about operators
            // + adds two operands
            // - Subtrcts the second operand from the first
            // * Multiplies both operands
            // / Divides the first operand by the other
            // % Modulus - divides and checks remainder
            // ++ Increments operator by one and is used for ints
            // -- Decrements - decreases value by one
            
            //RELATIONAL OPERATORA
            // == Checks if the values of two operands are equal, and if they are, returns bool true
            // != Checks if values of two operands are equal or not, and if the values are NOT equal, returns bool true.
            // not,
            // if not, returns bool to true

            int razAge = 23;

            int monicaAge = 20;
            Console.WriteLine(razAge == monicaAge);

            /*
             *  > Checks if the value of the left operand is
             *  greater than the value of the right operand, and
             *  if yes then condition is ture
             *  < Checks the value of the left operand is less
             *  than the value of the right operand, and 
             *  if yes then condition is true
             *  
             *  >= Checks if the value of left operand is greater than
             *  or equal to the value of the right operand,
             *  and if yes than the condition becomes true.
             *  
             *  <= Checks if the value of the right operand is
             *  less than or equal to the value of the right operand
             *  and if yes then condition becomes true
             *  */


        }
    }
}
