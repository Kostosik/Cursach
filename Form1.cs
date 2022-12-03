using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BillingSystem system;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fillListBoxes()
        {
            for (int i = 0; i < system.Clients.Count(); i++)
                ClientsList.Items.Add(system.Clients[i].printClient());
            for (int i = 0; i < system.Tariffs.Count(); i++)
                TariffList.Items.Add(system.Tariffs[i].printTariff());
        }

        private void GenerateRandomSystem_Click(object sender, EventArgs e)
        {
            system = new BillingSystem();
            fillListBoxes();
            GenerateRandomSystem.Visible = false;
            LoadFromFileSystem.Visible = false;
            ModulateButton.Visible = true;
        }

        private void LoadFromFileSystem_Click(object sender, EventArgs e)
        {
            system = new BillingSystem("C:/Users/kosto/source/repos/Cursach/bin/Debug");
            fillListBoxes();
            GenerateRandomSystem.Visible = false;
            LoadFromFileSystem.Visible = false;
            ModulateButton.Visible = true;
        }

        private void TariffList_SelectedIndexChanged(object sender, EventArgs e)
        {
            TariffDelete.Visible = true;
            SetActiveTariff.Visible = true;
        }

        private void ClientsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientChangeTariff.Visible = true;
            ClientDelete.Visible = true;
        }

        private void ClientDelete_Click(object sender, EventArgs e)
        {
            system.Clients.RemoveAt(ClientsList.SelectedIndex);
            ClientsList.Items.RemoveAt(ClientsList.SelectedIndex);
            ClientChangeTariff.Visible = false;
            ClientDelete.Visible = false;
        }

        private void TariffDelete_Click(object sender, EventArgs e)
        {
            system.Tariffs.RemoveAt(TariffList.SelectedIndex);
            TariffList.Items.RemoveAt(TariffList.SelectedIndex);
            TariffDelete.Visible = false;
            SetActiveTariff.Visible = false;
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            if (!ClientFirstName.Visible)
            {
                ClientFirstName.Visible = true;
                ClientMoney.Visible = true;
                ClientSecondName.Visible = true;
                LabelClientFirstName.Visible =true;
                LabelSecondClientName.Visible =true;
                LabelClientMoney.Visible =true;
            }
            else
            {
                if (ClientMoney.Text != "" && ClientSecondName.Text != "" && ClientFirstName.Text != "" && TariffList.SelectedIndex >= 0)
                {
                    system.AddClient(ClientFirstName.Text, ClientSecondName.Text, Convert.ToInt32(ClientMoney.Text), system.Tariffs[TariffList.SelectedIndex]);
                    ClientsList.Items.Add(system.Clients.Last().printClient());
                    ClientFirstName.Visible = false;
                    ClientSecondName.Visible = false;
                    ClientMoney.Visible = false;
                    LabelClientFirstName.Visible = false;
                    LabelSecondClientName.Visible = false;
                    LabelClientMoney.Visible = false;
                    LabelClientError.Visible = false;
                }
                else
                    LabelClientError.Visible = true;
            }
        }

        private void AddTariff_Click(object sender, EventArgs e)
        {
            if (!TariffPrice.Visible)
            {
                TariffName.Visible = true;
                TariffPrice.Visible = true;
                LabelTariffName.Visible = true;
                TariffPriceLabel.Visible = true;
            }
            else
            {
                if (TariffPrice.Text != "" && TariffName.Text != "")
                {
                    system.AddTariff(TariffName.Text, Convert.ToInt32(TariffPrice.Text));
                    TariffList.Items.Add(system.Tariffs.Last().printTariff());
                    TariffPrice.Visible = false;
                    TariffName.Visible = false;
                    LabelTariffName.Visible = false;
                    TariffPriceLabel.Visible = false;
                    LabelTariffError.Visible = false;
                }
                else
                    LabelTariffError.Visible = true;
            }

        }

        private void ModulateButton_Click(object sender, EventArgs e)
        {
            system.Modulate();
            ClientsList.Items.Clear();
            for (int i = 0; i < system.Clients.Count(); i++)
            {
                ClientsList.Items.Add(system.Clients[i].printClient());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            system.Serialize();
        }

        private void ClientChangeTariff_Click(object sender, EventArgs e)
        {
            int clientIndex = ClientsList.SelectedIndex;
            if (TariffList.SelectedIndex >= 0)
                system.ChangeTariff(system.Clients[clientIndex], system.Tariffs[TariffList.SelectedIndex]);
            ClientsList.Items.RemoveAt(clientIndex);
            ClientsList.Items.Insert(clientIndex, system.Clients[clientIndex].printClient());
            ClientChangeTariff.Visible = false;
            ClientDelete.Visible = false;
        }

        private void SetActiveTariff_Click(object sender, EventArgs e)
        {
            int index = TariffList.SelectedIndex;
            system.Tariffs[index].Activate();
            TariffList.Items.RemoveAt(index);
            TariffList.Items.Insert(index, system.Tariffs[index].printTariff());
            TariffDelete.Visible = false;
            SetActiveTariff.Visible = false;

        }
    }
}
