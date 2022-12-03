using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cursach
{
    public class UniqueClient:Client
    {
        public override void Calculate()
        {
            if (Account > 0)
                Account -= ClientTariff.price * 0.9;
            else
                IsActive = false;
        }

        public UniqueClient(string firstName, string secondName, int account, Tariff tariff) :base(firstName,secondName,account,tariff)
        {

        }

        [JsonConstructor]
        public UniqueClient(string firstName, string secondName, int money, Tariff tariff,bool isActive)
        {
            FirstName=firstName;
            SecondName=secondName;
            Account =money;
            ClientTariff = tariff;
            IsActive = isActive;
        }
    }
}
