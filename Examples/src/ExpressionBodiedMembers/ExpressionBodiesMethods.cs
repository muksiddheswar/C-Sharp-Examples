using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace C_Sharp_Examples.src.ExpressionBodiedMembers
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            fname = firstName;
            lname = lastName;
        }

        private string fname;
        private string lname;

        public override string ToString() => $"{fname} {lname}".Trim();
        public void DisplayName() => Console.WriteLine(ToString());

        // Expression-bodied methods with parameters
        public string GetFullName(string title) => $"{title} {fname} {lname}";
        public int CalculateAge(int birthYear) => DateTime.Now.Year - birthYear;
        public bool IsOlderThan(int age) => CalculateAge(1990) > age;
        public string FormatName(string format) => format.Replace("{first}", fname).Replace("{last}", lname);
    }


}
