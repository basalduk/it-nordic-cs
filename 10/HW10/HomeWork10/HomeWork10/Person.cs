using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork10
{
    class Person
    {
        public string Name { get; set; }
        public byte Age { get; set; }

        public byte FutureAge
        {
            get
            {
                return (byte)(Age + 4);
            }
        }

        public string PersonString
        {
            get
            {
                return $"Name: {Name}, age in 4 years: {FutureAge}";
            }
        }
    }
}
