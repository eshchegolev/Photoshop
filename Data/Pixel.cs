﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public class Pixel
    {
        public double Check (double value)
        {
            if (value < 0 || value > 1) throw new ArgumentException();
            return value;
        }

        private double r;

        public double R
        {
            get { return r; }
            set { r = Check(value); }
        }

        private double g;

        public double G
        {
            get { return g; }
            set { g = Check(value); }
        }

        private double b;
        public double B
        {
            get { return b; }
            set { b = Check(value); }
        }
    }
}
