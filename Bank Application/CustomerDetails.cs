using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Application
{
    //Generic Class
    class CustomerDetails<T>
    {
        T _value;

        public CustomerDetails(T t)
        {
            this._value = t;
        }

        public void Display()
        {
            Console.WriteLine(this._value);
        }

    }
}
