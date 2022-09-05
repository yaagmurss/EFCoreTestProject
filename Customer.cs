using System;
using System.Collections.Generic;
using System.Text;

namespace DateTime
{
    class Customer
    {
        public int Id;
        public string Name;

        public Customer(){}

        public Customer(int id)
        {
            this.Id = id;            
        }
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
