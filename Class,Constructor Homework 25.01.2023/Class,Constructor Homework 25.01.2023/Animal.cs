﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Constructor_Homework_25._01._2023
{
    internal class Animal
    {
        public string name = "";
        public string breed = "";
        public string color = "";
        public int age;

        public string GetDetails()
        {
            return $"Name : {name}  Breed  : {breed}  Age : {age} ";
        }
    }
}
