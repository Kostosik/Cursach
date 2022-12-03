using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cursach
{
    public class Client
    {
        private protected Tariff ClientTariff;
        private protected string FirstName;
        private protected string SecondName;
        private protected double Account;
        private protected bool IsActive;//NEW

        [JsonConstructor]
        private protected Client()
        {

        }

        public Client(string firstName,string secondName,int account,Tariff tariff)
        {
            if (firstName == null || firstName == "")
                throw new ArgumentNullException();
            if (secondName==null || secondName == "")
                throw new ArgumentNullException();
            if (account<0)
                throw new ArgumentOutOfRangeException();
            if(tariff==null)
                throw new ArgumentNullException();

            SecondName = secondName;
            Account = account;
            FirstName = firstName;
            ClientTariff = tariff;
            IsActive = true;

        }

        public virtual void Calculate()
        {
            if(Account>0)
                Account -= ClientTariff.price;
            else
                IsActive = false;
        }
        
        public string Serialize()
        {
            string jsonStr = JsonSerializer.Serialize(this);
            return jsonStr;
        }

        public string printClient()
        {
            return FirstName+ " " + SecondName + " "+ Account + " Tariff:"+ ClientTariff.name;
        }

        public string _firstName
        {
            get { return FirstName; }
        }

        public string _secondName
        {
            get { return SecondName; }
        }

        public double _account
        {
            get { return Account; }
            set { Account = value; }//////////////////
        }

        public bool _isActive
        {
            get { return IsActive; }
        }

        public Tariff _clientTariff
        {
            get { return ClientTariff; }
            set { if (value != null) ClientTariff = value; }
        }
    }
}
