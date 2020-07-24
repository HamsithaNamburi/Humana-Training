using System;
using System.Collections.Generic;
using System.Text;

namespace Package
{
   public  class Calculator
    {
        
        public int Addition(int n1,int n2)
        {
            int sum = n1 + n2;
            return sum;
        }
        public int Substraction(int n1, int n2)
        {
            int sub = n1 - n2;
            return sub;


        }
        public int Multiplication(int n1, int n2)
        {
            int mul = n1 * n2;
            return mul;


        }
        public int Division(int n1, int n2)
        {
            int div = n1 / n2;
            return div;


        }
    }
}
