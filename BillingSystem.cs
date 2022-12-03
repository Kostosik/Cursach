using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;


namespace Cursach
{
    internal class BillingSystem
    {
        public List<Client> Clients;
        public List<Tariff> Tariffs;

        public BillingSystem()
        {
            Tariffs = new List<Tariff>(0);
            Tariffs.Add(new Tariff("Name", 100));
            Tariffs.Add(new Tariff("Two", 1000));

            Clients = new List<Client>(0);
            for (int i = 0; i < 5; i++)
            {
                Clients.Add(new Client("Default", "Default", 5000, Tariffs[0]));
            }
            for (int i = 0; i < 5; i++)
            {
                Clients.Add(new Client("Default", "Default", 5000, Tariffs[1]));
            }
            for(int i = 0; i < 5; i++)
            {
                Clients.Add(new UniqueClient("Unique","Unique",10000, Tariffs[1]));
            }
        }

        public BillingSystem(string filepath)
        {
            if (filepath == null || filepath == "")
                throw new ArgumentNullException();
            Deserialize(filepath);
        }

        public void AddClient(string firstName, string secondName, int money, Tariff tariff)
        {
                Clients.Add(new Client(firstName, secondName, money, tariff));
        }
        public void AddClient(Client client)
        {
            if(client == null)
                throw new ArgumentNullException();
            Clients.Add(client);
        }

        public void AddTariff(string name, int price)
        {
            Tariffs.Add(new Tariff(name, price));
        }
        public void AddTariff(Tariff tariff)
        {
            if(tariff == null)
                throw new ArgumentNullException();
            Tariffs.Add(tariff);
        }

        public void ChangeTariff(Client client , Tariff tariff)
        {
            if (client == null && tariff == null)
                throw new ArgumentNullException();
            client._clientTariff = tariff;
        }

        public void Modulate()
        {
            for(int i=0;i<Clients.Count;i++)
            {
                Clients[i].Calculate();
            }
        }

        public void Serialize()//XML REWRITE
        {
            using (FileStream fs = new FileStream("Clients.json", FileMode.Create, FileAccess.ReadWrite))
            {
                for(int i=0;i<Clients.Count();i++)
                {
                    byte[] buffer = Encoding.Default.GetBytes(Clients[i].Serialize());
                    fs.Write(buffer, 0, buffer.Length);

                }
                fs.Close();
            }
            using (FileStream fs = new FileStream("Tariffes.json", FileMode.Create,FileAccess.ReadWrite))
            {
                for (int i = 0; i < Tariffs.Count(); i++)
                {
                    byte[] buffer = Encoding.Default.GetBytes(Tariffs[i].Serialize());
                    fs.Write(buffer, 0, buffer.Length);
                }
                fs.Close();
            }
        }

        void Deserialize(string filePath)
        {
            File.OpenRead(filePath + "/Clients.json");
            string jsonString = File.ReadAllText(filePath + "/Clients.json");

            string[] arrJsons = jsonString.Split('}');

            for (int i = 0; i < arrJsons.Length - 1; i++)
            {
                //Clients.Insert(i, JsonSerializer.Deserialize<UniqueClient>(arrJsons[i] + '}'));
            }


            File.OpenRead(filePath + "/Tariffes.json");
            jsonString = File.ReadAllText(filePath + "/Tariffes.json");

            arrJsons = jsonString.Split('}');
            Tariffs = new List<Tariff>(1);
            for (int i = 0; i < arrJsons.Length - 1; i++)
            {
                Tariff temp = JsonSerializer.Deserialize<Tariff>(arrJsons[i] + '}');
                Tariffs.Add(JsonSerializer.Deserialize<Tariff>(arrJsons[i] + '}'));
            }
            //Clients.Add(JsonSerializer.Deserialize<UniqueClient>(filePath));//
        }
    }
}
