using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"ID: {Id,-3} | Ten: {Name,-15} | Tuoi: {Age}";
        }
    }
}
