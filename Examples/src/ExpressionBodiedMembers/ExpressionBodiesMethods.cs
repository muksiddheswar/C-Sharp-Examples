using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

    public class Location
    {

        /*
         * The following example defines a Location class whose read-only Name property 
         * is implemented as an expression body definition that returns the value of the 
         * private locationName field:
        */
        private string locationName;

        public Location(string name)
        {
            locationName = name;
        }

        public string Name => locationName;

        //Expression body definitions to implement property get and set accessors
        public string LName
        {
            get => locationName;
            set => locationName = value;
        }
    }


}
