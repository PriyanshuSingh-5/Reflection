﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReflectionProgram
{
    public class Customer
    {
        public int Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public Customer()
        {
            this.Id = -1;
            this.Name = Name;
        }
        public Customer(int Id,string Name)
        {
            this.Id = -1;
            this.Name = Name;
        }
        public void PrintId()
        {
            Console.WriteLine("Id is {0}" + this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name is {0}" + this.Name);
        }
    }
}
