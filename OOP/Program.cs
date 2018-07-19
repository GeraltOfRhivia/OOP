﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Тест создания класса и использования сеттеров и геттеров VS
            Test t = new Test();
            Console.WriteLine(t.Name);
            t.Name = "Den";
            t.Age = 27;
            Console.WriteLine(t.Name + " " + t.Age);
            Console.ReadKey();
        }
    }


    class Test
    {
        // FIELDS
        private string name;
        private int age;
        
        // CONSTRUCT
        public Test()
        {
            Console.WriteLine("Create Test-class");
        }

        // SET & GET
        // CСоздается нажав правую кнопку мыши на полях
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }


    }

}
