using System;
using System.Collections.Generic;
using System.Text;

namespace Example1_Luxoft_Core
{
    public class Calculatora
    {
        public double num1;
        public double num2;

        public double sum()
        {
            return num1 + num2;
        }

        public double substraction()
        {
            return num1 - num2;

        }

        public double multiplication()
        {
            return num1 * num2;
        }

        public double Divition()
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                return 0;
            }
            
        }
    }
}
