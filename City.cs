using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class City
    {
        public int ZipCode { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public int Population { get; set; }
    }

        internal class Apartment : Building
        {
            public int NumberOfUnits { get; set; }
            public int NumberOfOpenUnits { get; set; }
            public bool HasParking { get; set; }
        }

        internal class Building
        {
            public string Street { get; set; }

            public int StreetNumber { get; set; }
        }

    internal class HighRise : Building
    {
        public int NumberOfStories { get; set; }
        public string OwnerName { get; set; }
        public List<string> Directory { get; set; }
    }
}