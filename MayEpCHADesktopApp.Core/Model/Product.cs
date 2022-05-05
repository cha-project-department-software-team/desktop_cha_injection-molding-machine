﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayEpCHADesktopApp.Core.Model
{
    public class Product
    {
        public Product(string id, string name, Mold mold, string moldId, EUnit unit, double piecesPerKilogram)
        {
            Id = id;
            Name = name;
            Mold = mold;
            MoldId = moldId;
            Unit = unit;
            PiecesPerKilogram = piecesPerKilogram;
        }

        private Product()
        {

        }

        public string Id { get; set; }
        public string Name { get; set; }
        public Mold Mold { get; set; }
        public string MoldId { get; set; }
        public EUnit Unit { get; set; }
        public double PiecesPerKilogram { get; set; }
    }
}
