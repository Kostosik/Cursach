namespace Cursach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateRandomSystem = new System.Windows.Forms.Button();
            this.LoadFromFileSystem = new System.Windows.Forms.Button();
            this.ClientsList = new System.Windows.Forms.ListBox();
            this.TariffList = new System.Windows.Forms.ListBox();
            this.TariffDelete = new System.Windows.Forms.Button();
            this.SetActiveTariff = new System.Windows.Forms.Button();
            this.AddTariff = new System.Windows.Forms.Button();
            this.AddClient = new System.Windows.Forms.Button();
            this.ClientChangeTariff = new System.Windows.Forms.Button();
            this.ClientDelete = new System.Windows.Forms.Button();
            this.ClientFirstName = new System.Windows.Forms.TextBox();
            this.ClientSecondName = new System.Windows.Forms.TextBox();
            this.ClientMoney = new System.Windows.Forms.TextBox();
            this.TariffPrice = new System.Windows.Forms.TextBox();
            this.TariffName = new System.Windows.Forms.TextBox();
            this.ModulateButton = new System.Windows.Forms.Button();
            this.SaveToFile = new System.Windows.Forms.Button();
            this.LabelClientFirstName = new System.Windows.Forms.Label();
            this.LabelSecondClientName = new System.Windows.Forms.Label();
            this.LabelClientMoney = new System.Windows.Forms.Label();
            this.LabelTariffName = new System.Windows.Forms.Label();
            this.TariffPriceLabel = new System.Windows.Forms.Label();
            this.LabelClientError = new System.Windows.Forms.Label();
            this.LabelTariffError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateRandomSystem
            // 
            this.GenerateRandomSystem.Location = new System.Drawing.Point(622, 12);
            this.GenerateRandomSystem.Name = "GenerateRandomSystem";
            this.GenerateRandomSystem.Size = new System.Drawing.Size(135, 23);
            this.GenerateRandomSystem.TabIndex = 0;
            this.GenerateRandomSystem.Text = "GenerateRandomSystem";
            this.GenerateRandomSystem.UseVisualStyleBackColor = true;
            this.GenerateRandomSystem.Click += new System.EventHandler(this.GenerateRandomSystem_Click);
            // 
            // LoadFromFileSystem
            // 
            this.LoadFromFileSystem.Location = new System.Drawing.Point(622, 41);
            this.LoadFromFileSystem.Name = "LoadFromFileSystem";
            this.LoadFromFileSystem.Size = new System.Drawing.Size(135, 21);
            this.LoadFromFileSystem.TabIndex = 1;
            this.LoadFromFileSystem.Text = "LoadFromFileSystem";
            this.LoadFromFileSystem.UseVisualStyleBackColor = true;
            this.LoadFromFileSystem.Click += new System.EventHandler(this.LoadFromFileSystem_Click);
            // 
            // ClientsList
            // 
            this.ClientsList.FormattingEnabled = true;
            this.ClientsList.Location = new System.Drawing.Point(26, 24);
            this.ClientsList.Name = "ClientsList";
            this.ClientsList.Size = new System.Drawing.Size(196, 238);
            this.ClientsList.TabIndex = 3;
            this.ClientsList.SelectedIndexChanged += new System.EventHandler(this.ClientsList_SelectedIndexChanged);
            // 
            // TariffList
            // 
            this.TariffList.FormattingEnabled = true;
            this.TariffList.Location = new System.Drawing.Point(261, 24);
            this.TariffList.Name = "TariffList";
            this.TariffList.Size = new System.Drawing.Size(196, 238);
            this.TariffList.TabIndex = 4;
            this.TariffList.SelectedIndexChanged += new System.EventHandler(this.TariffList_SelectedIndexChanged);
            // 
            // TariffDelete
            // 
            this.TariffDelete.Location = new System.Drawing.Point(622, 172);
            this.TariffDelete.Name = "TariffDelete";
            this.TariffDelete.Size = new System.Drawing.Size(96, 23);
            this.TariffDelete.TabIndex = 6;
            this.TariffDelete.Text = "TariffDelete";
            this.TariffDelete.UseVisualStyleBackColor = true;
            this.TariffDelete.Visible = false;
            this.TariffDelete.Click += new System.EventHandler(this.TariffDelete_Click);
            // 
            // SetActiveTariff
            // 
            this.SetActiveTariff.Location = new System.Drawing.Point(622, 201);
            this.SetActiveTariff.Name = "SetActiveTariff";
            this.SetActiveTariff.Size = new System.Drawing.Size(96, 23);
            this.SetActiveTariff.TabIndex = 7;
            this.SetActiveTariff.Text = "SetActiveTariff";
            this.SetActiveTariff.UseVisualStyleBackColor = true;
            this.SetActiveTariff.Visible = false;
            this.SetActiveTariff.Click += new System.EventHandler(this.SetActiveTariff_Click);
            // 
            // AddTariff
            // 
            this.AddTariff.Location = new System.Drawing.Point(520, 399);
            this.AddTariff.Name = "AddTariff";
            this.AddTariff.Size = new System.Drawing.Size(96, 23);
            this.AddTariff.TabIndex = 8;
            this.AddTariff.Text = "AddTariff";
            this.AddTariff.UseVisualStyleBackColor = true;
            this.AddTariff.Click += new System.EventHandler(this.AddTariff_Click);
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(520, 293);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(96, 23);
            this.AddClient.TabIndex = 11;
            this.AddClient.Text = "AddClient";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // ClientChangeTariff
            // 
            this.ClientChangeTariff.Location = new System.Drawing.Point(520, 201);
            this.ClientChangeTariff.Name = "ClientChangeTariff";
            this.ClientChangeTariff.Size = new System.Drawing.Size(96, 23);
            this.ClientChangeTariff.TabIndex = 10;
            this.ClientChangeTariff.Text = "ClientChangeTariff";
            this.ClientChangeTariff.UseVisualStyleBackColor = true;
            this.ClientChangeTariff.Visible = false;
            this.ClientChangeTariff.Click += new System.EventHandler(this.ClientChangeTariff_Click);
            // 
            // ClientDelete
            // 
            this.ClientDelete.Location = new System.Drawing.Point(520, 172);
            this.ClientDelete.Name = "ClientDelete";
            this.ClientDelete.Size = new System.Drawing.Size(96, 23);
            this.ClientDelete.TabIndex = 9;
            this.ClientDelete.Text = "ClientDelete";
            this.ClientDelete.UseVisualStyleBackColor = true;
            this.ClientDelete.Visible = false;
            this.ClientDelete.Click += new System.EventHandler(this.ClientDelete_Click);
            // 
            // ClientFirstName
            // 
            this.ClientFirstName.Location = new System.Drawing.Point(26, 296);
            this.ClientFirstName.Name = "ClientFirstName";
            this.ClientFirstName.Size = new System.Drawing.Size(100, 20);
            this.ClientFirstName.TabIndex = 12;
            this.ClientFirstName.Visible = false;
            // 
            // ClientSecondName
            // 
            this.ClientSecondName.Location = new System.Drawing.Point(172, 296);
            this.ClientSecondName.Name = "ClientSecondName";
            this.ClientSecondName.Size = new System.Drawing.Size(100, 20);
            this.ClientSecondName.TabIndex = 13;
            this.ClientSecondName.Visible = false;
            // 
            // ClientMoney
            // 
            this.ClientMoney.Location = new System.Drawing.Point(295, 296);
            this.ClientMoney.Name = "ClientMoney";
            this.ClientMoney.Size = new System.Drawing.Size(100, 20);
            this.ClientMoney.TabIndex = 14;
            this.ClientMoney.Visible = false;
            // 
            // TariffPrice
            // 
            this.TariffPrice.Location = new System.Drawing.Point(172, 401);
            this.TariffPrice.Name = "TariffPrice";
            this.TariffPrice.Size = new System.Drawing.Size(100, 20);
            this.TariffPrice.TabIndex = 17;
            this.TariffPrice.Visible = false;
            // 
            // TariffName
            // 
            this.TariffName.Location = new System.Drawing.Point(26, 402);
            this.TariffName.Name = "TariffName";
            this.TariffName.Size = new System.Drawing.Size(100, 20);
            this.TariffName.TabIndex = 16;
            this.TariffName.Visible = false;
            // 
            // ModulateButton
            // 
            this.ModulateButton.Location = new System.Drawing.Point(622, 69);
            this.ModulateButton.Name = "ModulateButton";
            this.ModulateButton.Size = new System.Drawing.Size(135, 23);
            this.ModulateButton.TabIndex = 18;
            this.ModulateButton.Text = "ModulateSystem";
            this.ModulateButton.UseVisualStyleBackColor = true;
            this.ModulateButton.Visible = false;
            this.ModulateButton.Click += new System.EventHandler(this.ModulateButton_Click);
            // 
            // SaveToFile
            // 
            this.SaveToFile.Location = new System.Drawing.Point(622, 118);
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.Size = new System.Drawing.Size(75, 23);
            this.SaveToFile.TabIndex = 19;
            this.SaveToFile.Text = "SaveToFile";
            this.SaveToFile.UseVisualStyleBackColor = true;
            this.SaveToFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelClientFirstName
            // 
            this.LabelClientFirstName.AutoSize = true;
            this.LabelClientFirstName.Location = new System.Drawing.Point(23, 280);
            this.LabelClientFirstName.Name = "LabelClientFirstName";
            this.LabelClientFirstName.Size = new System.Drawing.Size(116, 13);
            this.LabelClientFirstName.TabIndex = 20;
            this.LabelClientFirstName.Text = "Введите имя клиента";
            this.LabelClientFirstName.Visible = false;
            // 
            // LabelSecondClientName
            // 
            this.LabelSecondClientName.AutoSize = true;
            this.LabelSecondClientName.Location = new System.Drawing.Point(142, 280);
            this.LabelSecondClientName.Name = "LabelSecondClientName";
            this.LabelSecondClientName.Size = new System.Drawing.Size(144, 13);
            this.LabelSecondClientName.TabIndex = 21;
            this.LabelSecondClientName.Text = "Введите фамилию клиента";
            this.LabelSecondClientName.Visible = false;
            // 
            // LabelClientMoney
            // 
            this.LabelClientMoney.AutoSize = true;
            this.LabelClientMoney.Location = new System.Drawing.Point(292, 280);
            this.LabelClientMoney.Name = "LabelClientMoney";
            this.LabelClientMoney.Size = new System.Drawing.Size(180, 13);
            this.LabelClientMoney.TabIndex = 22;
            this.LabelClientMoney.Text = "Введите состояние счета клиента";
            this.LabelClientMoney.Visible = false;
            // 
            // LabelTariffName
            // 
            this.LabelTariffName.AutoSize = true;
            this.LabelTariffName.Location = new System.Drawing.Point(23, 386);
            this.LabelTariffName.Name = "LabelTariffName";
            this.LabelTariffName.Size = new System.Drawing.Size(140, 13);
            this.LabelTariffName.TabIndex = 23;
            this.LabelTariffName.Text = "Введите название тарифа";
            this.LabelTariffName.Visible = false;
            // 
            // TariffPriceLabel
            // 
            this.TariffPriceLabel.AutoSize = true;
            this.TariffPriceLabel.Location = new System.Drawing.Point(169, 386);
            this.TariffPriceLabel.Name = "TariffPriceLabel";
            this.TariffPriceLabel.Size = new System.Drawing.Size(146, 13);
            this.TariffPriceLabel.TabIndex = 24;
            this.TariffPriceLabel.Text = "Введите стоимость тарифа";
            this.TariffPriceLabel.Visible = false;
            // 
            // LabelClientError
            // 
            this.LabelClientError.AutoSize = true;
            this.LabelClientError.Location = new System.Drawing.Point(142, 319);
            this.LabelClientError.Name = "LabelClientError";
            this.LabelClientError.Size = new System.Drawing.Size(163, 13);
            this.LabelClientError.TabIndex = 25;
            this.LabelClientError.Text = "Неправильно введены данные";
            this.LabelClientError.Visible = false;
            // 
            // LabelTariffError
            // 
            this.LabelTariffError.AutoSize = true;
            this.LabelTariffError.Location = new System.Drawing.Point(76, 424);
            this.LabelTariffError.Name = "LabelTariffError";
            this.LabelTariffError.Size = new System.Drawing.Size(163, 13);
            this.LabelTariffError.TabIndex = 26;
            this.LabelTariffError.Text = "Неправильно введены данные";
            this.LabelTariffError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelTariffError);
            this.Controls.Add(this.LabelClientError);
            this.Controls.Add(this.TariffPriceLabel);
            this.Controls.Add(this.LabelTariffName);
            this.Controls.Add(this.LabelClientMoney);
            this.Controls.Add(this.LabelSecondClientName);
            this.Controls.Add(this.LabelClientFirstName);
            this.Controls.Add(this.SaveToFile);
            this.Controls.Add(this.ModulateButton);
            this.Controls.Add(this.TariffPrice);
            this.Controls.Add(this.TariffName);
            this.Controls.Add(this.ClientMoney);
            this.Controls.Add(this.ClientSecondName);
            this.Controls.Add(this.ClientFirstName);
            this.Controls.Add(this.AddClient);
            this.Controls.Add(this.ClientChangeTariff);
            this.Controls.Add(this.ClientDelete);
            this.Controls.Add(this.AddTariff);
            this.Controls.Add(this.SetActiveTariff);
            this.Controls.Add(this.TariffDelete);
            this.Controls.Add(this.TariffList);
            this.Controls.Add(this.ClientsList);
            this.Controls.Add(this.LoadFromFileSystem);
            this.Controls.Add(this.GenerateRandomSystem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateRandomSystem;
        private System.Windows.Forms.Button LoadFromFileSystem;
        private System.Windows.Forms.ListBox ClientsList;
        private System.Windows.Forms.ListBox TariffList;
        private System.Windows.Forms.Button TariffDelete;
        private System.Windows.Forms.Button SetActiveTariff;
        private System.Windows.Forms.Button AddTariff;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Button ClientChangeTariff;
        private System.Windows.Forms.Button ClientDelete;
        private System.Windows.Forms.TextBox ClientFirstName;
        private System.Windows.Forms.TextBox ClientSecondName;
        private System.Windows.Forms.TextBox ClientMoney;
        private System.Windows.Forms.TextBox TariffPrice;
        private System.Windows.Forms.TextBox TariffName;
        private System.Windows.Forms.Button ModulateButton;
        private System.Windows.Forms.Button SaveToFile;
        private System.Windows.Forms.Label LabelClientFirstName;
        private System.Windows.Forms.Label LabelSecondClientName;
        private System.Windows.Forms.Label LabelClientMoney;
        private System.Windows.Forms.Label LabelTariffName;
        private System.Windows.Forms.Label TariffPriceLabel;
        private System.Windows.Forms.Label LabelClientError;
        private System.Windows.Forms.Label LabelTariffError;
    }
}

