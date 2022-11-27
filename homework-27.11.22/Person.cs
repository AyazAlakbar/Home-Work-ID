using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace homework_27._11._22
{
    internal class Person
    {
        public static int ID = 0;
        
        public static int MyProperty { get; set; }
        public Person()
        {
            ID++;
           
        }
    }
}
