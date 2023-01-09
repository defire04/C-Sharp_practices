using System;
using System.Collections.Generic;
using System.Text;

namespace Practice8.models
{
    class Person
    {
        public string Name { get; set; }
        public Phone Phone { get; set; }

        public Person(string name, Phone personsPhone)
        {
            this.Name = name;
            this.Phone = personsPhone;
        }


  


        
    }
}
