namespace DataBaseSneakers
{
    partial class AddSneakers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSneakers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelSneakersName = new System.Windows.Forms.Label();
            this.labelVentor = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelProdCountry = new System.Windows.Forms.Label();
            this.labelSport = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.panelAdd1 = new System.Windows.Forms.Panel();
            this.panelAdd2 = new System.Windows.Forms.Panel();
            this.rjButtonClear = new DataBaseSneakers.RJButton();
            this.rjTextBoxProdCountry = new DataBaseSneakers.RJTextBox();
            this.rjTextBoxMaterial = new DataBaseSneakers.RJTextBox();
            this.rjComboBoxSport = new DataBaseSneakers.RJComboBox();
            this.rjTextBoxSize = new DataBaseSneakers.RJTextBox();
            this.rjTextBoxBrand = new DataBaseSneakers.RJTextBox();
            this.rjTextBoxVentor = new DataBaseSneakers.RJTextBox();
            this.rjButtonAdd = new DataBaseSneakers.RJButton();
            this.rjTextBoxSneakersName = new DataBaseSneakers.RJTextBox();
            this.rjComboBoxGender = new DataBaseSneakers.RJComboBox();
            this.rjComboBoxSize = new DataBaseSneakers.RJComboBox();
            this.rjTextBoPrice = new DataBaseSneakers.RJTextBox();
            this.rjTextBoxColor = new DataBaseSneakers.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelAdd1.SuspendLayout();
            this.panelAdd2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 41);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelInfo.Location = new System.Drawing.Point(28, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(223, 22);
            this.labelInfo.TabIndex = 45;
            this.labelInfo.Text = "Добавление информации";
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(645, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(52, 41);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.Purple;
            this.labelHeader.Location = new System.Drawing.Point(165, 87);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(175, 50);
            this.labelHeader.TabIndex = 8;
            this.labelHeader.Text = "Кроссовки";
            // 
            // labelSneakersName
            // 
            this.labelSneakersName.AutoSize = true;
            this.labelSneakersName.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSneakersName.Location = new System.Drawing.Point(37, 209);
            this.labelSneakersName.Name = "labelSneakersName";
            this.labelSneakersName.Size = new System.Drawing.Size(229, 28);
            this.labelSneakersName.TabIndex = 11;
            this.labelSneakersName.Text = "Название кроссовок:";
            // 
            // labelVentor
            // 
            this.labelVentor.AutoSize = true;
            this.labelVentor.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVentor.Location = new System.Drawing.Point(39, 275);
            this.labelVentor.Name = "labelVentor";
            this.labelVentor.Size = new System.Drawing.Size(106, 28);
            this.labelVentor.TabIndex = 14;
            this.labelVentor.Text = "Артикул:";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrand.Location = new System.Drawing.Point(39, 351);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(83, 28);
            this.labelBrand.TabIndex = 17;
            this.labelBrand.Text = "Бренд:";
            // 
            // labelProdCountry
            // 
            this.labelProdCountry.AutoSize = true;
            this.labelProdCountry.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProdCountry.Location = new System.Drawing.Point(7, 20);
            this.labelProdCountry.Name = "labelProdCountry";
            this.labelProdCountry.Size = new System.Drawing.Size(254, 28);
            this.labelProdCountry.TabIndex = 19;
            this.labelProdCountry.Text = "Страна производитель:";
            // 
            // labelSport
            // 
            this.labelSport.AutoSize = true;
            this.labelSport.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSport.Location = new System.Drawing.Point(9, 92);
            this.labelSport.Name = "labelSport";
            this.labelSport.Size = new System.Drawing.Size(193, 28);
            this.labelSport.TabIndex = 21;
            this.labelSport.Text = "Название спорта:";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaterial.Location = new System.Drawing.Point(7, 164);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(122, 28);
            this.labelMaterial.TabIndex = 23;
            this.labelMaterial.Text = "Материал:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(9, 20);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(60, 28);
            this.labelGender.TabIndex = 25;
            this.labelGender.Text = "Пол:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize.Location = new System.Drawing.Point(9, 92);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(92, 28);
            this.labelSize.TabIndex = 29;
            this.labelSize.Text = "Размер:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(9, 156);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(69, 28);
            this.labelColor.TabIndex = 31;
            this.labelColor.Text = "Цвет:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(9, 219);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(192, 28);
            this.labelPrice.TabIndex = 33;
            this.labelPrice.Text = "Цена за единицу:";
            // 
            // panelAdd1
            // 
            this.panelAdd1.Controls.Add(this.labelProdCountry);
            this.panelAdd1.Controls.Add(this.rjTextBoxProdCountry);
            this.panelAdd1.Controls.Add(this.labelSport);
            this.panelAdd1.Controls.Add(this.labelMaterial);
            this.panelAdd1.Controls.Add(this.rjTextBoxMaterial);
            this.panelAdd1.Controls.Add(this.rjComboBoxSport);
            this.panelAdd1.Location = new System.Drawing.Point(32, 397);
            this.panelAdd1.Name = "panelAdd1";
            this.panelAdd1.Size = new System.Drawing.Size(510, 209);
            this.panelAdd1.TabIndex = 37;
            this.panelAdd1.Visible = false;
            // 
            // panelAdd2
            // 
            this.panelAdd2.Controls.Add(this.labelGender);
            this.panelAdd2.Controls.Add(this.rjComboBoxGender);
            this.panelAdd2.Controls.Add(this.rjComboBoxSize);
            this.panelAdd2.Controls.Add(this.labelSize);
            this.panelAdd2.Controls.Add(this.rjTextBoPrice);
            this.panelAdd2.Controls.Add(this.labelColor);
            this.panelAdd2.Controls.Add(this.labelPrice);
            this.panelAdd2.Controls.Add(this.rjTextBoxColor);
            this.panelAdd2.Location = new System.Drawing.Point(32, 612);
            this.panelAdd2.Name = "panelAdd2";
            this.panelAdd2.Size = new System.Drawing.Size(511, 279);
            this.panelAdd2.TabIndex = 38;
            this.panelAdd2.Visible = false;
            // 
            // rjButtonClear
            // 
            this.rjButtonClear.BackColor = System.Drawing.Color.DarkOrchid;
            this.rjButtonClear.BackgroundColor = System.Drawing.Color.DarkOrchid;
            this.rjButtonClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonClear.BorderRadius = 26;
            this.rjButtonClear.BorderSize = 0;
            this.rjButtonClear.FlatAppearance.BorderSize = 0;
            this.rjButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonClear.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonClear.ForeColor = System.Drawing.Color.White;
            this.rjButtonClear.Location = new System.Drawing.Point(44, 897);
            this.rjButtonClear.Name = "rjButtonClear";
            this.rjButtonClear.Size = new System.Drawing.Size(169, 54);
            this.rjButtonClear.TabIndex = 36;
            this.rjButtonClear.Text = "Очистить";
            this.rjButtonClear.TextColor = System.Drawing.Color.White;
            this.rjButtonClear.UseVisualStyleBackColor = false;
            this.rjButtonClear.Click += new System.EventHandler(this.rjButtonClear_Click);
            // 
            // rjTextBoxProdCountry
            // 
            this.rjTextBoxProdCountry.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxProdCountry.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxProdCountry.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxProdCountry.BorderRadius = 0;
            this.rjTextBoxProdCountry.BorderSize = 2;
            this.rjTextBoxProdCountry.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.rjTextBoxProdCountry.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxProdCountry.Location = new System.Drawing.Point(291, 13);
            this.rjTextBoxProdCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxProdCountry.MaxLength = 32767;
            this.rjTextBoxProdCountry.MinLength = 0;
            this.rjTextBoxProdCountry.Multiline = false;
            this.rjTextBoxProdCountry.Name = "rjTextBoxProdCountry";
            this.rjTextBoxProdCountry.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxProdCountry.PasswordChar = false;
            this.rjTextBoxProdCountry.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxProdCountry.PlaceholderText = "";
            this.rjTextBoxProdCountry.ReadOnly = false;
            this.rjTextBoxProdCountry.Size = new System.Drawing.Size(190, 37);
            this.rjTextBoxProdCountry.TabIndex = 20;
            this.rjTextBoxProdCountry.Texts = "";
            this.rjTextBoxProdCountry.UnderlinedStyle = true;
            this.rjTextBoxProdCountry._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxProdCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxLetters_KeyPress);
            // 
            // rjTextBoxMaterial
            // 
            this.rjTextBoxMaterial.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxMaterial.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxMaterial.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxMaterial.BorderRadius = 0;
            this.rjTextBoxMaterial.BorderSize = 2;
            this.rjTextBoxMaterial.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.rjTextBoxMaterial.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxMaterial.Location = new System.Drawing.Point(159, 157);
            this.rjTextBoxMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxMaterial.MaxLength = 32767;
            this.rjTextBoxMaterial.MinLength = 0;
            this.rjTextBoxMaterial.Multiline = false;
            this.rjTextBoxMaterial.Name = "rjTextBoxMaterial";
            this.rjTextBoxMaterial.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxMaterial.PasswordChar = false;
            this.rjTextBoxMaterial.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxMaterial.PlaceholderText = "";
            this.rjTextBoxMaterial.ReadOnly = false;
            this.rjTextBoxMaterial.Size = new System.Drawing.Size(246, 37);
            this.rjTextBoxMaterial.TabIndex = 24;
            this.rjTextBoxMaterial.Texts = "";
            this.rjTextBoxMaterial.UnderlinedStyle = true;
            this.rjTextBoxMaterial._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxMaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxLetters_KeyPress);
            this.rjTextBoxMaterial.Leave += new System.EventHandler(this.rjTextBoxMaterial_Leave);
            // 
            // rjComboBoxSport
            // 
            this.rjComboBoxSport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBoxSport.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxSport.BorderSize = 2;
            this.rjComboBoxSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjComboBoxSport.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjComboBoxSport.ForeColor = System.Drawing.Color.Black;
            this.rjComboBoxSport.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxSport.ListBackColor = System.Drawing.Color.Lavender;
            this.rjComboBoxSport.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBoxSport.Location = new System.Drawing.Point(230, 92);
            this.rjComboBoxSport.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxSport.Name = "rjComboBoxSport";
            this.rjComboBoxSport.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxSport.Size = new System.Drawing.Size(200, 37);
            this.rjComboBoxSport.TabIndex = 27;
            this.rjComboBoxSport.Texts = "";
            // 
            // rjTextBoxSize
            // 
            this.rjTextBoxSize.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxSize.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxSize.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxSize.BorderRadius = 0;
            this.rjTextBoxSize.BorderSize = 2;
            this.rjTextBoxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjTextBoxSize.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxSize.Location = new System.Drawing.Point(248, 916);
            this.rjTextBoxSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxSize.MaxLength = 2;
            this.rjTextBoxSize.MinLength = 0;
            this.rjTextBoxSize.Multiline = false;
            this.rjTextBoxSize.Name = "rjTextBoxSize";
            this.rjTextBoxSize.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxSize.PasswordChar = false;
            this.rjTextBoxSize.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxSize.PlaceholderText = "";
            this.rjTextBoxSize.ReadOnly = false;
            this.rjTextBoxSize.Size = new System.Drawing.Size(142, 35);
            this.rjTextBoxSize.TabIndex = 30;
            this.rjTextBoxSize.Texts = "";
            this.rjTextBoxSize.UnderlinedStyle = true;
            this.rjTextBoxSize.Visible = false;
            this.rjTextBoxSize._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxDigits_KeyPress);
            // 
            // rjTextBoxBrand
            // 
            this.rjTextBoxBrand.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxBrand.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxBrand.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxBrand.BorderRadius = 0;
            this.rjTextBoxBrand.BorderSize = 2;
            this.rjTextBoxBrand.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.rjTextBoxBrand.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxBrand.Location = new System.Drawing.Point(189, 344);
            this.rjTextBoxBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxBrand.MaxLength = 32767;
            this.rjTextBoxBrand.MinLength = 0;
            this.rjTextBoxBrand.Multiline = false;
            this.rjTextBoxBrand.Name = "rjTextBoxBrand";
            this.rjTextBoxBrand.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxBrand.PasswordChar = false;
            this.rjTextBoxBrand.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxBrand.PlaceholderText = "";
            this.rjTextBoxBrand.ReadOnly = false;
            this.rjTextBoxBrand.Size = new System.Drawing.Size(190, 37);
            this.rjTextBoxBrand.TabIndex = 18;
            this.rjTextBoxBrand.Texts = "";
            this.rjTextBoxBrand.UnderlinedStyle = true;
            this.rjTextBoxBrand._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxBrand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxLetters_KeyPress);
            this.rjTextBoxBrand.Leave += new System.EventHandler(this.rjTextBoxBrand_Leave);
            // 
            // rjTextBoxVentor
            // 
            this.rjTextBoxVentor.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxVentor.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxVentor.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxVentor.BorderRadius = 0;
            this.rjTextBoxVentor.BorderSize = 2;
            this.rjTextBoxVentor.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.rjTextBoxVentor.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxVentor.Location = new System.Drawing.Point(189, 268);
            this.rjTextBoxVentor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxVentor.MaxLength = 8;
            this.rjTextBoxVentor.MinLength = 0;
            this.rjTextBoxVentor.Multiline = false;
            this.rjTextBoxVentor.Name = "rjTextBoxVentor";
            this.rjTextBoxVentor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxVentor.PasswordChar = false;
            this.rjTextBoxVentor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxVentor.PlaceholderText = "";
            this.rjTextBoxVentor.ReadOnly = false;
            this.rjTextBoxVentor.Size = new System.Drawing.Size(190, 37);
            this.rjTextBoxVentor.TabIndex = 16;
            this.rjTextBoxVentor.Texts = "";
            this.rjTextBoxVentor.UnderlinedStyle = true;
            this.rjTextBoxVentor._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            // 
            // rjButtonAdd
            // 
            this.rjButtonAdd.BackColor = System.Drawing.Color.DarkOrchid;
            this.rjButtonAdd.BackgroundColor = System.Drawing.Color.DarkOrchid;
            this.rjButtonAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonAdd.BorderRadius = 26;
            this.rjButtonAdd.BorderSize = 0;
            this.rjButtonAdd.Enabled = false;
            this.rjButtonAdd.FlatAppearance.BorderSize = 0;
            this.rjButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonAdd.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonAdd.ForeColor = System.Drawing.Color.White;
            this.rjButtonAdd.Location = new System.Drawing.Point(477, 897);
            this.rjButtonAdd.Name = "rjButtonAdd";
            this.rjButtonAdd.Size = new System.Drawing.Size(169, 54);
            this.rjButtonAdd.TabIndex = 13;
            this.rjButtonAdd.Text = "Добавить";
            this.rjButtonAdd.TextColor = System.Drawing.Color.White;
            this.rjButtonAdd.UseVisualStyleBackColor = false;
            this.rjButtonAdd.Click += new System.EventHandler(this.rjButtonAdd_Click);
            // 
            // rjTextBoxSneakersName
            // 
            this.rjTextBoxSneakersName.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxSneakersName.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxSneakersName.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxSneakersName.BorderRadius = 0;
            this.rjTextBoxSneakersName.BorderSize = 2;
            this.rjTextBoxSneakersName.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.rjTextBoxSneakersName.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxSneakersName.Location = new System.Drawing.Point(281, 202);
            this.rjTextBoxSneakersName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxSneakersName.MaxLength = 32767;
            this.rjTextBoxSneakersName.MinLength = 0;
            this.rjTextBoxSneakersName.Multiline = false;
            this.rjTextBoxSneakersName.Name = "rjTextBoxSneakersName";
            this.rjTextBoxSneakersName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxSneakersName.PasswordChar = false;
            this.rjTextBoxSneakersName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxSneakersName.PlaceholderText = "";
            this.rjTextBoxSneakersName.ReadOnly = false;
            this.rjTextBoxSneakersName.Size = new System.Drawing.Size(190, 37);
            this.rjTextBoxSneakersName.TabIndex = 12;
            this.rjTextBoxSneakersName.Texts = "";
            this.rjTextBoxSneakersName.UnderlinedStyle = true;
            this.rjTextBoxSneakersName._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxSneakersName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxLetters_KeyPress);
            // 
            // rjComboBoxGender
            // 
            this.rjComboBoxGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBoxGender.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxGender.BorderSize = 2;
            this.rjComboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjComboBoxGender.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjComboBoxGender.ForeColor = System.Drawing.Color.Black;
            this.rjComboBoxGender.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxGender.Items.AddRange(new object[] {
            "F",
            "M"});
            this.rjComboBoxGender.ListBackColor = System.Drawing.Color.Lavender;
            this.rjComboBoxGender.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBoxGender.Location = new System.Drawing.Point(119, 15);
            this.rjComboBoxGender.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxGender.Name = "rjComboBoxGender";
            this.rjComboBoxGender.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxGender.Size = new System.Drawing.Size(200, 37);
            this.rjComboBoxGender.TabIndex = 28;
            this.rjComboBoxGender.Texts = "";
            // 
            // rjComboBoxSize
            // 
            this.rjComboBoxSize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBoxSize.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxSize.BorderSize = 2;
            this.rjComboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjComboBoxSize.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjComboBoxSize.ForeColor = System.Drawing.Color.Black;
            this.rjComboBoxSize.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxSize.Items.AddRange(new object[] {
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48"});
            this.rjComboBoxSize.ListBackColor = System.Drawing.Color.Lavender;
            this.rjComboBoxSize.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBoxSize.Location = new System.Drawing.Point(119, 92);
            this.rjComboBoxSize.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxSize.Name = "rjComboBoxSize";
            this.rjComboBoxSize.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxSize.Size = new System.Drawing.Size(200, 37);
            this.rjComboBoxSize.TabIndex = 35;
            this.rjComboBoxSize.Texts = "";
            // 
            // rjTextBoPrice
            // 
            this.rjTextBoPrice.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoPrice.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoPrice.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoPrice.BorderRadius = 0;
            this.rjTextBoPrice.BorderSize = 2;
            this.rjTextBoPrice.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.rjTextBoPrice.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoPrice.Location = new System.Drawing.Point(216, 212);
            this.rjTextBoPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoPrice.MaxLength = 32767;
            this.rjTextBoPrice.MinLength = 0;
            this.rjTextBoPrice.Multiline = false;
            this.rjTextBoPrice.Name = "rjTextBoPrice";
            this.rjTextBoPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoPrice.PasswordChar = false;
            this.rjTextBoPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoPrice.PlaceholderText = "";
            this.rjTextBoPrice.ReadOnly = false;
            this.rjTextBoPrice.Size = new System.Drawing.Size(142, 37);
            this.rjTextBoPrice.TabIndex = 34;
            this.rjTextBoPrice.Texts = "";
            this.rjTextBoPrice.UnderlinedStyle = true;
            this.rjTextBoPrice._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            this.rjTextBoPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxPrice_KeyPress);
            // 
            // rjTextBoxColor
            // 
            this.rjTextBoxColor.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxColor.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxColor.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxColor.BorderRadius = 0;
            this.rjTextBoxColor.BorderSize = 2;
            this.rjTextBoxColor.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.rjTextBoxColor.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxColor.Location = new System.Drawing.Point(119, 149);
            this.rjTextBoxColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxColor.MaxLength = 48;
            this.rjTextBoxColor.MinLength = 0;
            this.rjTextBoxColor.Multiline = false;
            this.rjTextBoxColor.Name = "rjTextBoxColor";
            this.rjTextBoxColor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxColor.PasswordChar = false;
            this.rjTextBoxColor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxColor.PlaceholderText = "";
            this.rjTextBoxColor.ReadOnly = false;
            this.rjTextBoxColor.Size = new System.Drawing.Size(142, 37);
            this.rjTextBoxColor.TabIndex = 32;
            this.rjTextBoxColor.Texts = "";
            this.rjTextBoxColor.UnderlinedStyle = true;
            this.rjTextBoxColor._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            this.rjTextBoxColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxLetters_KeyPress);
            // 
            // AddSneakers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(697, 985);
            this.Controls.Add(this.rjButtonClear);
            this.Controls.Add(this.panelAdd1);
            this.Controls.Add(this.rjTextBoxSize);
            this.Controls.Add(this.rjTextBoxBrand);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.rjTextBoxVentor);
            this.Controls.Add(this.labelVentor);
            this.Controls.Add(this.rjButtonAdd);
            this.Controls.Add(this.rjTextBoxSneakersName);
            this.Controls.Add(this.labelSneakersName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAdd2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSneakers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddSneakers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelAdd1.ResumeLayout(false);
            this.panelAdd1.PerformLayout();
            this.panelAdd2.ResumeLayout(false);
            this.panelAdd2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelHeader;
        private RJButton rjButtonAdd;
        private RJTextBox rjTextBoxSneakersName;
        private System.Windows.Forms.Label labelSneakersName;
        private System.Windows.Forms.Label labelVentor;
        private RJTextBox rjTextBoxVentor;
        private RJTextBox rjTextBoxBrand;
        private System.Windows.Forms.Label labelBrand;
        private RJTextBox rjTextBoxProdCountry;
        private System.Windows.Forms.Label labelProdCountry;
        private System.Windows.Forms.Label labelSport;
        private RJTextBox rjTextBoxMaterial;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelGender;
        private RJComboBox rjComboBoxSport;
        private RJComboBox rjComboBoxGender;
        private System.Windows.Forms.Label labelSize;
        private RJTextBox rjTextBoxSize;
        private RJTextBox rjTextBoxColor;
        private System.Windows.Forms.Label labelColor;
        private RJTextBox rjTextBoPrice;
        private System.Windows.Forms.Label labelPrice;
        private RJComboBox rjComboBoxSize;
        private RJButton rjButtonClear;
        private System.Windows.Forms.Panel panelAdd1;
        private System.Windows.Forms.Panel panelAdd2;
        private System.Windows.Forms.Label labelInfo;
    }
}