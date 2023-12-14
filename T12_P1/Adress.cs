using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_P11
{
    internal class Adress
    {
        public int num;
        public string country;
        public string city;
        public int street;
        public int house;
        public int apart;


        public Adress() 
        {

        
        }

        public Adress(int num, string country, string city, int street, int house, int apart)
        {
            this.num = num;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apart = apart;
        }

        public override string ToString()
        {
            return $"{num}\n{country}\n{city}\n{street}\n{house}\n{apart}";
        }


    }
}
