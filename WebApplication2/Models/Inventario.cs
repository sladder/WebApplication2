﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Inventario
    {
        public int InventarioID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public byte Red { get; set; }
        public bool Green { get; set; }
        public Boolean Blue { get; set; }
    }
}