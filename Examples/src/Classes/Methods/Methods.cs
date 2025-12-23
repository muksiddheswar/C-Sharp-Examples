using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Examples.src.Classes.Methods
{
    class Methods
    {
        // Define the method Multiply here
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Implement a constructor that takes two parameters: name and age and sets the Name and Age properties.
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Implement a method called GetGreeting that returns a string in the following format:
        //"Hello, my name is {Name} and I am {Age} years old."
        public string GetGreeting()
        {
            return $"Hello, my name is {Name} and I am {Age} years old.";
        }

    }



}
