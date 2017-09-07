using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;



namespace Clientside
{
    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "smita";
            
            Id = "855";
            Age = 22;
        }
    }
}
