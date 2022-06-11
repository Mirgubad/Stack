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
            names.Push("John");
            names.Push(23);
            names.Push(3);
            Console.WriteLine(names.Pop());
            Console.WriteLine(names.Peek());

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

//Objetc arrayi olduğu üçün maində loop emtək olmur,IEnumerable -a implement etdimki maində loop edib object arrayinin İtemlarını çap etmək olsun
//Həmçinin o olmasa belə GetAll metodu yazmışamki onu call edəndə print edir elementləri
           
        }

        
    }
}
