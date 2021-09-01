﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    class Product : IDisplayable
    {
        public int ProductId { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }

        public string GetDisplayText()
        {
            return $"{Title} costs: {Price:c}";
        }
    }
}