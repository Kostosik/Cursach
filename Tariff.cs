using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cursach
{
    public class Tariff
    {
        private string Name;
        private double Price;
        private bool IsActive;

        [JsonConstructor]
        public Tariff(string name, int price, bool isActive)
        {
            Name = name;
            Price = price;
            IsActive = isActive;
        }

        private Tariff()
        { }

        public Tariff(string name,int price)
        {
            if(name == null || name=="")
                throw new ArgumentNullException();
            if(price <= 0)
                throw new ArgumentOutOfRangeException();
            Name = name;
            Price = price;
            IsActive = true;
        }

        public string Serialize()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = false,
                AllowTrailingCommas = false
            };
            string jsonStr = JsonSerializer.Serialize(this,options);
            return jsonStr;
        }

        public string printTariff()
        {
            return Name+ " Price: " + Price + (isActive? " Active":" Not active");
        }

        public void Activate()
        {
            IsActive = !IsActive;
        }

        public string name
        {
            get { return Name; }
            private set { Name = value; }
        }

        public double price
        {
            get { return Price; }
            private set { Price = value; }
        }

        public bool isActive
        {
            get { return IsActive; }
            private set
            {
                IsActive = value;
            }
        }
    }
}
