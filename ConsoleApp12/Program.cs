using System;
using System.Collections.Generic;
using System.Collections;
namespace ConsoleApp12
{
    class Program 
    {
        static void Main(string[] args)
        {
            MyStack  names = new MyStack();
            names.Push("Salman");
            names.Push(23);
            names.Push(3);
            Console.WriteLine(names.Pop());
            Console.WriteLine(names.Peek());



           
        }

        
    }
}
