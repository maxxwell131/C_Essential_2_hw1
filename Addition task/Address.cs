using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_task
{
    class Address
    {
        private string index, country, city, street;
        private uint house, apartment;

        public string Index { get; set; }
        public string Countru { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public uint House { get; set; }
        public uint Apartament { get; set; }

        public void AdressShow()
        {
            Console.WriteLine("Adress:\n index-{0},\n country-{1},\n city-{2},\n street-{3},\n house-{4},\n apartment-{5}", this.Index, this.Countru, this.City, this.Street,this.House, this.Apartament );
        }
    }
}
