﻿using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261020
{
    class Decoration
    {
        private string name;
        private int cost;

        public Decoration(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }
        public string Name { get => name; set => name = value; }
        public int Cost { get => cost; set => cost = value;}

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
