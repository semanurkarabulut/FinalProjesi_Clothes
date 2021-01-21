using Clothes.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clothes.Entites.Concrete
{
    public class Clothe : IEntity
    {
        public int ClotheId { get; set; }
        public decimal UnitPrice { get; set; }
        public string Name { get; set; }

        public Clothe()
        {

        }

        public Clothe(int id, decimal unitPrice, string name)
        {
            ClotheId = id;
            UnitPrice = unitPrice;
            Name = name;
        }

        public override string ToString()
        {
            return $"{ClotheId,-5} {UnitPrice,-10} {Name,-20}";
        }
    }
}
