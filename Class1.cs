using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Calculatrice
{
    internal class Class1
    {
        public static float Addition(float firstNumber, float secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static float Soustraction(float firstNumber, float secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public static float Multiplication(float firstNumber, float secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public static float Division(float firstNumber, float secondNumber)
        {
            return firstNumber / secondNumber;
        }
        public static float Modulo(float firstNumber, float secondNumber)
        {
            return firstNumber % secondNumber;
        }
    }
}
