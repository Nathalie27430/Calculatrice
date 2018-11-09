using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public class Operation
    {
        public double Addition(double num1, double num2)
        {
            double result = num1 + num2;


            return result;
        }
        public double Soustraction(double num1, double num2)
        {
            double result = num1 - num2;

            return result;
        }

        public double Multiplication(double num1, double num2)
        {
            double result = num1 * num2;

            return result;
        }

    }
}