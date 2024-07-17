namespace DataBaseSneakers
{
    partial class EditSneakers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSneakers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.rjTextBoPrice = new DataBaseSneakers.RJTextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.rjTextBoxColor = new DataBaseSneakers.RJTextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.rjComboBoxSport = new DataBaseSneakers.RJComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.rjTextBoxMaterial = new DataBaseSneakers.RJTextBox();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelSport = new System.Windows.Forms.Label();
            this.rjTextBoxProdCountry = new DataBaseSneakers.RJTextBox();
            this.labelProdCountry = new System.Windows.Forms.Label();
            this.rjTextBoxBrand = new DataBaseSneakers.RJTextBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.rjTextBoxVentor = new DataBaseSneakers.RJTextBox();
            this.labelVentor = new System.Windows.Forms.Label();
            this.rjButtonEdit = new DataBaseSneakers.RJButton();
            this.rjTextBoxSneakersName = new DataBaseSneakers.RJTextBox();
            this.labelSneakersName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.radioButtonSneakersName = new System.Windows.Forms.RadioButton();
            this.radioButtonVentor = new System.Windows.Forms.RadioButton();
            this.radioButtonBrand = new System.Windows.Forms.RadioButton();
            this.panelSneakersName = new System.Windows.Forms.Panel();
            this.panelVentor = new System.Windows.Forms.Panel();
            this.rjComboBoxSize = new DataBaseSneakers.RJComboBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.rjComboBoxGender = new DataBaseSneakers.RJComboBox();
            this.panelBrand = new System.Windows.Forms.Panel();
            this.panelProdCountry = new System.Windows.Forms.Panel();
            this.radioButtonProdCountry = new System.Windows.Forms.RadioButton();
            this.radioButtonSport = new System.Windows.Forms.RadioButton();
            this.panelSport = new System.Windows.Forms.Panel();
            this.panelMaterial = new System.Windows.Forms.Panel();
            this.radioButtonMaterial = new System.Windows.Forms.RadioButton();
            this.radioButtonGender = new System.Windows.Forms.RadioButton();
            this.radioButtonSize = new System.Windows.Forms.RadioButton();
            this.radioButtonColor = new System.Windows.Forms.RadioButton();
            this.radioButtonPrice = new System.Windows.Forms.RadioButton();
            this.panelGender = new System.Windows.Forms.Panel();
            this.panelSize = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelPrice = new System.Windows.Forms.Panel();
            this.rjButtonClear = new DataBaseSneakers.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSneakersName.SuspendLayout();
            this.panelVentor.SuspendLayout();
            this.panelBrand.SuspendLayout();
            this.panelProdCountry.SuspendLayout();
            this.panelSport.SuspendLayout();
            this.panelMaterial.SuspendLayout();
            this.panelGender.SuspendLayout();
            this.panelSize.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.panelPrice.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(998, 41);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(25, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(217, 22);
            this.labelInfo.TabIndex = 50;
            this.labelInfo.Text = "Изменение информации";
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(946, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(52, 41);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
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
            this.rjTextBoPrice.Location = new System.Drawing.Point(222, 31);
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
            this.rjTextBoPrice.TabIndex = 57;
            this.rjTextBoPrice.Texts = "";
            this.rjTextBoPrice.UnderlinedStyle = true;
            this.rjTextBoPrice._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxPrice_KeyPress);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(15, 38);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(192, 28);
            this.labelPrice.TabIndex = 56;
            this.labelPrice.Text = "Цена за единицу:";
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
            this.rjTextBoxColor.Location = new System.Drawing.Point(125, 30);
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
            this.rjTextBoxColor.TabIndex = 55;
            this.rjTextBoxColor.Texts = "";
            this.rjTextBoxColor.UnderlinedStyle = true;
            this.rjTextBoxColor._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxLetters_KeyPress);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(15, 37);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(69, 28);
            this.labelColor.TabIndex = 54;
            this.labelColor.Text = "Цвет:";
            // 
            // rjComboBoxSport
            // 
            this.rjComboBoxSport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBoxSport.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxSport.BorderSize = 2;
            this.rjComboBoxSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBoxSport.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjComboBoxSport.ForeColor = System.Drawing.Color.Black;
            this.rjComboBoxSport.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxSport.ListBackColor = System.Drawing.Color.Lavender;
            this.rjComboBoxSport.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBoxSport.Location = new System.Drawing.Point(236, 42);
            this.rjComboBoxSport.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxSport.Name = "rjComboBoxSport";
            this.rjComboBoxSport.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxSport.Size = new System.Drawing.Size(200, 37);
            this.rjComboBoxSport.TabIndex = 50;
            this.rjComboBoxSport.Texts = "";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(15, 32);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(60, 28);
            this.labelGender.TabIndex = 49;
            this.labelGender.Text = "Пол:";
            // 
            // rjTextBoxMaterial
            // 
            this.rjTextBoxMaterial.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxMaterial.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxMaterial.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxMaterial.BorderRadius = 0;
            this.rjTextBoxMaterial.BorderSize = 2;
            this.rjTextBoxMaterial.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjTextBoxMaterial.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxMaterial.Location = new System.Drawing.Point(165, 34);
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
            this.rjTextBoxMaterial.Size = new System.Drawing.Size(328, 39);
            this.rjTextBoxMaterial.TabIndex = 48;
            this.rjTextBoxMaterial.Texts = "";
            this.rjTextBoxMaterial.UnderlinedStyle = true;
            this.rjTextBoxMaterial._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxMaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxLetters_KeyPress);
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaterial.Location = new System.Drawing.Point(15, 45);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(122, 28);
            this.labelMaterial.TabIndex = 47;
            this.labelMaterial.Text = "Материал:";
            // 
            // labelSport
            // 
            this.labelSport.AutoSize = true;
            this.labelSport.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSport.Location = new System.Drawing.Point(15, 42);
            this.labelSport.Name = "labelSport";
            this.labelSport.Size = new System.Drawing.Size(193, 28);
            this.labelSport.TabIndex = 46;
            this.labelSport.Text = "Название спорта:";
            // 
            // rjTextBoxProdCountry
            // 
            this.rjTextBoxProdCountry.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxProdCountry.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxProdCountry.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxProdCountry.BorderRadius = 0;
            this.rjTextBoxProdCountry.BorderSize = 2;
            this.rjTextBoxProdCountry.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjTextBoxProdCountry.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxProdCountry.Location = new System.Drawing.Point(303, 29);
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
            this.rjTextBoxProdCountry.TabIndex = 45;
            this.rjTextBoxProdCountry.Texts = "";
            this.rjTextBoxProdCountry.UnderlinedStyle = true;
            this.rjTextBoxProdCountry._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxProdCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxLetters_KeyPress);
            // 
            // labelProdCountry
            // 
            this.labelProdCountry.AutoSize = true;
            this.labelProdCountry.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProdCountry.Location = new System.Drawing.Point(15, 36);
            this.labelProdCountry.Name = "labelProdCountry";
            this.labelProdCountry.Size = new System.Drawing.Size(254, 28);
            this.labelProdCountry.TabIndex = 44;
            this.labelProdCountry.Text = "Страна производитель:";
            // 
            // rjTextBoxBrand
            // 
            this.rjTextBoxBrand.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxBrand.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxBrand.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxBrand.BorderRadius = 0;
            this.rjTextBoxBrand.BorderSize = 2;
            this.rjTextBoxBrand.Font = new System.Drawing.Font("Constantia", 10.8F);
            this.rjTextBoxBrand.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxBrand.Location = new System.Drawing.Point(165, 29);
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
            this.rjTextBoxBrand.TabIndex = 43;
            this.rjTextBoxBrand.Texts = "";
            this.rjTextBoxBrand.UnderlinedStyle = true;
            this.rjTextBoxBrand._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxBrand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxLetters_KeyPress);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrand.Location = new System.Drawing.Point(15, 36);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(83, 28);
            this.labelBrand.TabIndex = 42;
            this.labelBrand.Text = "Бренд:";
            // 
            // rjTextBoxVentor
            // 
            this.rjTextBoxVentor.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxVentor.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxVentor.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxVentor.BorderRadius = 0;
            this.rjTextBoxVentor.BorderSize = 2;
            this.rjTextBoxVentor.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjTextBoxVentor.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxVentor.Location = new System.Drawing.Point(165, 30);
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
            this.rjTextBoxVentor.TabIndex = 41;
            this.rjTextBoxVentor.Texts = "";
            this.rjTextBoxVentor.UnderlinedStyle = true;
            this.rjTextBoxVentor._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            // 
            // labelVentor
            // 
            this.labelVentor.AutoSize = true;
            this.labelVentor.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVentor.Location = new System.Drawing.Point(15, 39);
            this.labelVentor.Name = "labelVentor";
            this.labelVentor.Size = new System.Drawing.Size(106, 28);
            this.labelVentor.TabIndex = 40;
            this.labelVentor.Text = "Артикул:";
            // 
            // rjButtonEdit
            // 
            this.rjButtonEdit.BackColor = System.Drawing.Color.DarkOrchid;
            this.rjButtonEdit.BackgroundColor = System.Drawing.Color.DarkOrchid;
            this.rjButtonEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonEdit.BorderRadius = 26;
            this.rjButtonEdit.BorderSize = 0;
            this.rjButtonEdit.FlatAppearance.BorderSize = 0;
            this.rjButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonEdit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonEdit.ForeColor = System.Drawing.Color.White;
            this.rjButtonEdit.Location = new System.Drawing.Point(406, 702);
            this.rjButtonEdit.Name = "rjButtonEdit";
            this.rjButtonEdit.Size = new System.Drawing.Size(169, 54);
            this.rjButtonEdit.TabIndex = 39;
            this.rjButtonEdit.Text = "Изменить";
            this.rjButtonEdit.TextColor = System.Drawing.Color.White;
            this.rjButtonEdit.UseVisualStyleBackColor = false;
            this.rjButtonEdit.Click += new System.EventHandler(this.rjButtonEdit_Click);
            // 
            // rjTextBoxSneakersName
            // 
            this.rjTextBoxSneakersName.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxSneakersName.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxSneakersName.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxSneakersName.BorderRadius = 0;
            this.rjTextBoxSneakersName.BorderSize = 2;
            this.rjTextBoxSneakersName.Font = new System.Drawing.Font("Constantia", 10.8F);
            this.rjTextBoxSneakersName.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxSneakersName.Location = new System.Drawing.Point(277, 31);
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
            this.rjTextBoxSneakersName.Size = new System.Drawing.Size(230, 37);
            this.rjTextBoxSneakersName.TabIndex = 38;
            this.rjTextBoxSneakersName.Texts = "";
            this.rjTextBoxSneakersName.UnderlinedStyle = true;
            this.rjTextBoxSneakersName._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxSneakersName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxLetters_KeyPress);
            // 
            // labelSneakersName
            // 
            this.labelSneakersName.AutoSize = true;
            this.labelSneakersName.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSneakersName.Location = new System.Drawing.Point(15, 40);
            this.labelSneakersName.Name = "labelSneakersName";
            this.labelSneakersName.Size = new System.Drawing.Size(229, 28);
            this.labelSneakersName.TabIndex = 37;
            this.labelSneakersName.Text = "Название кроссовок:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(43, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.Purple;
            this.labelHeader.Location = new System.Drawing.Point(176, 89);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(175, 50);
            this.labelHeader.TabIndex = 35;
            this.labelHeader.Text = "Кроссовки";
            // 
            // radioButtonSneakersName
            // 
            this.radioButtonSneakersName.AutoSize = true;
            this.radioButtonSneakersName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSneakersName.Location = new System.Drawing.Point(55, 221);
            this.radioButtonSneakersName.Name = "radioButtonSneakersName";
            this.radioButtonSneakersName.Size = new System.Drawing.Size(376, 39);
            this.radioButtonSneakersName.TabIndex = 58;
            this.radioButtonSneakersName.TabStop = true;
            this.radioButtonSneakersName.Text = "Изменинить название кроссовок";
            this.radioButtonSneakersName.UseVisualStyleBackColor = true;
            this.radioButtonSneakersName.CheckedChanged += new System.EventHandler(this.radioButtonSneakersName_CheckedChanged);
            // 
            // radioButtonVentor
            // 
            this.radioButtonVentor.AutoSize = true;
            this.radioButtonVentor.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonVentor.Location = new System.Drawing.Point(53, 275);
            this.radioButtonVentor.Name = "radioButtonVentor";
            this.radioButtonVentor.Size = new System.Drawing.Size(273, 39);
            this.radioButtonVentor.TabIndex = 59;
            this.radioButtonVentor.TabStop = true;
            this.radioButtonVentor.Text = "Изменинить артикул";
            this.radioButtonVentor.UseVisualStyleBackColor = true;
            this.radioButtonVentor.CheckedChanged += new System.EventHandler(this.radioButtonVentor_CheckedChanged);
            // 
            // radioButtonBrand
            // 
            this.radioButtonBrand.AutoSize = true;
            this.radioButtonBrand.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonBrand.Location = new System.Drawing.Point(53, 329);
            this.radioButtonBrand.Name = "radioButtonBrand";
            this.radioButtonBrand.Size = new System.Drawing.Size(346, 39);
            this.radioButtonBrand.TabIndex = 60;
            this.radioButtonBrand.TabStop = true;
            this.radioButtonBrand.Text = "Изменинить название бренда";
            this.radioButtonBrand.UseVisualStyleBackColor = true;
            this.radioButtonBrand.CheckedChanged += new System.EventHandler(this.radioButtonBrand_CheckedChanged);
            // 
            // panelSneakersName
            // 
            this.panelSneakersName.Controls.Add(this.labelSneakersName);
            this.panelSneakersName.Controls.Add(this.rjTextBoxSneakersName);
            this.panelSneakersName.Location = new System.Drawing.Point(43, 543);
            this.panelSneakersName.Name = "panelSneakersName";
            this.panelSneakersName.Size = new System.Drawing.Size(532, 97);
            this.panelSneakersName.TabIndex = 61;
            this.panelSneakersName.Visible = false;
            // 
            // panelVentor
            // 
            this.panelVentor.Controls.Add(this.labelVentor);
            this.panelVentor.Controls.Add(this.rjTextBoxVentor);
            this.panelVentor.Location = new System.Drawing.Point(43, 543);
            this.panelVentor.Name = "panelVentor";
            this.panelVentor.Size = new System.Drawing.Size(520, 100);
            this.panelVentor.TabIndex = 62;
            this.panelVentor.Visible = false;
            // 
            // rjComboBoxSize
            // 
            this.rjComboBoxSize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBoxSize.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxSize.BorderSize = 2;
            this.rjComboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
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
            this.rjComboBoxSize.Location = new System.Drawing.Point(125, 38);
            this.rjComboBoxSize.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxSize.Name = "rjComboBoxSize";
            this.rjComboBoxSize.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxSize.Size = new System.Drawing.Size(200, 37);
            this.rjComboBoxSize.TabIndex = 64;
            this.rjComboBoxSize.Texts = "";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize.Location = new System.Drawing.Point(15, 38);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(92, 28);
            this.labelSize.TabIndex = 63;
            this.labelSize.Text = "Размер:";
            // 
            // rjComboBoxGender
            // 
            this.rjComboBoxGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBoxGender.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxGender.BorderSize = 2;
            this.rjComboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBoxGender.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjComboBoxGender.ForeColor = System.Drawing.Color.Black;
            this.rjComboBoxGender.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxGender.Items.AddRange(new object[] {
            "F",
            "M"});
            this.rjComboBoxGender.ListBackColor = System.Drawing.Color.Lavender;
            this.rjComboBoxGender.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBoxGender.Location = new System.Drawing.Point(123, 28);
            this.rjComboBoxGender.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxGender.Name = "rjComboBoxGender";
            this.rjComboBoxGender.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxGender.Size = new System.Drawing.Size(200, 37);
            this.rjComboBoxGender.TabIndex = 65;
            this.rjComboBoxGender.Texts = "";
            // 
            // panelBrand
            // 
            this.panelBrand.Controls.Add(this.rjTextBoxBrand);
            this.panelBrand.Controls.Add(this.labelBrand);
            this.panelBrand.Location = new System.Drawing.Point(43, 543);
            this.panelBrand.Name = "panelBrand";
            this.panelBrand.Size = new System.Drawing.Size(520, 100);
            this.panelBrand.TabIndex = 66;
            this.panelBrand.Visible = false;
            // 
            // panelProdCountry
            // 
            this.panelProdCountry.Controls.Add(this.labelProdCountry);
            this.panelProdCountry.Controls.Add(this.rjTextBoxProdCountry);
            this.panelProdCountry.Location = new System.Drawing.Point(43, 543);
            this.panelProdCountry.Name = "panelProdCountry";
            this.panelProdCountry.Size = new System.Drawing.Size(532, 100);
            this.panelProdCountry.TabIndex = 67;
            this.panelProdCountry.Visible = false;
            // 
            // radioButtonProdCountry
            // 
            this.radioButtonProdCountry.AutoSize = true;
            this.radioButtonProdCountry.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonProdCountry.Location = new System.Drawing.Point(53, 384);
            this.radioButtonProdCountry.Name = "radioButtonProdCountry";
            this.radioButtonProdCountry.Size = new System.Drawing.Size(425, 39);
            this.radioButtonProdCountry.TabIndex = 68;
            this.radioButtonProdCountry.TabStop = true;
            this.radioButtonProdCountry.Text = "Изменинить страну производитель";
            this.radioButtonProdCountry.UseVisualStyleBackColor = true;
            this.radioButtonProdCountry.CheckedChanged += new System.EventHandler(this.radioButtonProdCountry_CheckedChanged);
            // 
            // radioButtonSport
            // 
            this.radioButtonSport.AutoSize = true;
            this.radioButtonSport.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSport.Location = new System.Drawing.Point(619, 221);
            this.radioButtonSport.Name = "radioButtonSport";
            this.radioButtonSport.Size = new System.Drawing.Size(301, 39);
            this.radioButtonSport.TabIndex = 69;
            this.radioButtonSport.TabStop = true;
            this.radioButtonSport.Text = "Изменинить вид спорта";
            this.radioButtonSport.UseVisualStyleBackColor = true;
            this.radioButtonSport.CheckedChanged += new System.EventHandler(this.radioButtonSport_CheckedChanged);
            // 
            // panelSport
            // 
            this.panelSport.Controls.Add(this.labelSport);
            this.panelSport.Controls.Add(this.rjComboBoxSport);
            this.panelSport.Location = new System.Drawing.Point(43, 543);
            this.panelSport.Name = "panelSport";
            this.panelSport.Size = new System.Drawing.Size(532, 100);
            this.panelSport.TabIndex = 70;
            this.panelSport.Visible = false;
            // 
            // panelMaterial
            // 
            this.panelMaterial.Controls.Add(this.labelMaterial);
            this.panelMaterial.Controls.Add(this.rjTextBoxMaterial);
            this.panelMaterial.Location = new System.Drawing.Point(43, 543);
            this.panelMaterial.Name = "panelMaterial";
            this.panelMaterial.Size = new System.Drawing.Size(532, 107);
            this.panelMaterial.TabIndex = 71;
            this.panelMaterial.Visible = false;
            // 
            // radioButtonMaterial
            // 
            this.radioButtonMaterial.AutoSize = true;
            this.radioButtonMaterial.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMaterial.Location = new System.Drawing.Point(619, 275);
            this.radioButtonMaterial.Name = "radioButtonMaterial";
            this.radioButtonMaterial.Size = new System.Drawing.Size(289, 39);
            this.radioButtonMaterial.TabIndex = 72;
            this.radioButtonMaterial.TabStop = true;
            this.radioButtonMaterial.Text = "Изменинить материал";
            this.radioButtonMaterial.UseVisualStyleBackColor = true;
            this.radioButtonMaterial.CheckedChanged += new System.EventHandler(this.radioButtonMaterial_CheckedChanged);
            // 
            // radioButtonGender
            // 
            this.radioButtonGender.AutoSize = true;
            this.radioButtonGender.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonGender.Location = new System.Drawing.Point(619, 329);
            this.radioButtonGender.Name = "radioButtonGender";
            this.radioButtonGender.Size = new System.Drawing.Size(216, 39);
            this.radioButtonGender.TabIndex = 73;
            this.radioButtonGender.TabStop = true;
            this.radioButtonGender.Text = "Изменинить пол";
            this.radioButtonGender.UseVisualStyleBackColor = true;
            this.radioButtonGender.CheckedChanged += new System.EventHandler(this.radioButtonGender_CheckedChanged);
            // 
            // radioButtonSize
            // 
            this.radioButtonSize.AutoSize = true;
            this.radioButtonSize.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSize.Location = new System.Drawing.Point(619, 384);
            this.radioButtonSize.Name = "radioButtonSize";
            this.radioButtonSize.Size = new System.Drawing.Size(255, 39);
            this.radioButtonSize.TabIndex = 74;
            this.radioButtonSize.TabStop = true;
            this.radioButtonSize.Text = "Изменинить размер";
            this.radioButtonSize.UseVisualStyleBackColor = true;
            this.radioButtonSize.CheckedChanged += new System.EventHandler(this.radioButtonSize_CheckedChanged);
            // 
            // radioButtonColor
            // 
            this.radioButtonColor.AutoSize = true;
            this.radioButtonColor.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonColor.Location = new System.Drawing.Point(55, 440);
            this.radioButtonColor.Name = "radioButtonColor";
            this.radioButtonColor.Size = new System.Drawing.Size(233, 39);
            this.radioButtonColor.TabIndex = 75;
            this.radioButtonColor.TabStop = true;
            this.radioButtonColor.Text = "Изменинить цвет";
            this.radioButtonColor.UseVisualStyleBackColor = true;
            this.radioButtonColor.CheckedChanged += new System.EventHandler(this.radioButtonColor_CheckedChanged);
            // 
            // radioButtonPrice
            // 
            this.radioButtonPrice.AutoSize = true;
            this.radioButtonPrice.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPrice.Location = new System.Drawing.Point(619, 440);
            this.radioButtonPrice.Name = "radioButtonPrice";
            this.radioButtonPrice.Size = new System.Drawing.Size(345, 39);
            this.radioButtonPrice.TabIndex = 76;
            this.radioButtonPrice.TabStop = true;
            this.radioButtonPrice.Text = "Изменинить цену за единицу";
            this.radioButtonPrice.UseVisualStyleBackColor = true;
            this.radioButtonPrice.CheckedChanged += new System.EventHandler(this.radioButtonPrice_CheckedChanged);
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.labelGender);
            this.panelGender.Controls.Add(this.rjComboBoxGender);
            this.panelGender.Location = new System.Drawing.Point(43, 543);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(532, 107);
            this.panelGender.TabIndex = 77;
            this.panelGender.Visible = false;
            // 
            // panelSize
            // 
            this.panelSize.Controls.Add(this.labelSize);
            this.panelSize.Controls.Add(this.rjComboBoxSize);
            this.panelSize.Location = new System.Drawing.Point(43, 543);
            this.panelSize.Name = "panelSize";
            this.panelSize.Size = new System.Drawing.Size(532, 107);
            this.panelSize.TabIndex = 77;
            this.panelSize.Visible = false;
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.labelColor);
            this.panelColor.Controls.Add(this.rjTextBoxColor);
            this.panelColor.Location = new System.Drawing.Point(43, 543);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(532, 107);
            this.panelColor.TabIndex = 78;
            this.panelColor.Visible = false;
            // 
            // panelPrice
            // 
            this.panelPrice.Controls.Add(this.labelPrice);
            this.panelPrice.Controls.Add(this.rjTextBoPrice);
            this.panelPrice.Location = new System.Drawing.Point(40, 543);
            this.panelPrice.Name = "panelPrice";
            this.panelPrice.Size = new System.Drawing.Size(532, 107);
            this.panelPrice.TabIndex = 78;
            this.panelPrice.Visible = false;
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
            this.rjButtonClear.Location = new System.Drawing.Point(185, 702);
            this.rjButtonClear.Name = "rjButtonClear";
            this.rjButtonClear.Size = new System.Drawing.Size(169, 54);
            this.rjButtonClear.TabIndex = 78;
            this.rjButtonClear.Text = "Очистить";
            this.rjButtonClear.TextColor = System.Drawing.Color.White;
            this.rjButtonClear.UseVisualStyleBackColor = false;
            this.rjButtonClear.Click += new System.EventHandler(this.rjButtonClear_Click);
            // 
            // EditSneakers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(998, 869);
            this.Controls.Add(this.panelPrice);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.panelSize);
            this.Controls.Add(this.rjButtonClear);
            this.Controls.Add(this.panelGender);
            this.Controls.Add(this.radioButtonPrice);
            this.Controls.Add(this.radioButtonColor);
            this.Controls.Add(this.radioButtonSize);
            this.Controls.Add(this.radioButtonGender);
            this.Controls.Add(this.radioButtonMaterial);
            this.Controls.Add(this.panelMaterial);
            this.Controls.Add(this.panelSport);
            this.Controls.Add(this.radioButtonSport);
            this.Controls.Add(this.radioButtonProdCountry);
            this.Controls.Add(this.panelProdCountry);
            this.Controls.Add(this.panelBrand);
            this.Controls.Add(this.panelVentor);
            this.Controls.Add(this.panelSneakersName);
            this.Controls.Add(this.radioButtonBrand);
            this.Controls.Add(this.radioButtonVentor);
            this.Controls.Add(this.radioButtonSneakersName);
            this.Controls.Add(this.rjButtonEdit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditSneakers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditSneakers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSneakersName.ResumeLayout(false);
            this.panelSneakersName.PerformLayout();
            this.panelVentor.ResumeLayout(false);
            this.panelVentor.PerformLayout();
            this.panelBrand.ResumeLayout(false);
            this.panelBrand.PerformLayout();
            this.panelProdCountry.ResumeLayout(false);
            this.panelProdCountry.PerformLayout();
            this.panelSport.ResumeLayout(false);
            this.panelSport.PerformLayout();
            this.panelMaterial.ResumeLayout(false);
            this.panelMaterial.PerformLayout();
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            this.panelSize.ResumeLayout(false);
            this.panelSize.PerformLayout();
            this.panelColor.ResumeLayout(false);
            this.panelColor.PerformLayout();
            this.panelPrice.ResumeLayout(false);
            this.panelPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private RJTextBox rjTextBoPrice;
        private System.Windows.Forms.Label labelPrice;
        private RJTextBox rjTextBoxColor;
        private System.Windows.Forms.Label labelColor;
        private RJComboBox rjComboBoxSport;
        private System.Windows.Forms.Label labelGender;
        private RJTextBox rjTextBoxMaterial;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelSport;
        private RJTextBox rjTextBoxProdCountry;
        private System.Windows.Forms.Label labelProdCountry;
        private RJTextBox rjTextBoxBrand;
        private System.Windows.Forms.Label labelBrand;
        private RJTextBox rjTextBoxVentor;
        private System.Windows.Forms.Label labelVentor;
        private RJButton rjButtonEdit;
        private RJTextBox rjTextBoxSneakersName;
        private System.Windows.Forms.Label labelSneakersName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.RadioButton radioButtonSneakersName;
        private System.Windows.Forms.RadioButton radioButtonVentor;
        private System.Windows.Forms.RadioButton radioButtonBrand;
        private System.Windows.Forms.Panel panelSneakersName;
        private System.Windows.Forms.Panel panelVentor;
        private RJComboBox rjComboBoxSize;
        private System.Windows.Forms.Label labelSize;
        private RJComboBox rjComboBoxGender;
        private System.Windows.Forms.Panel panelBrand;
        private System.Windows.Forms.Panel panelProdCountry;
        private System.Windows.Forms.RadioButton radioButtonProdCountry;
        private System.Windows.Forms.RadioButton radioButtonSport;
        private System.Windows.Forms.Panel panelSport;
        private System.Windows.Forms.Panel panelMaterial;
        private System.Windows.Forms.RadioButton radioButtonMaterial;
        private System.Windows.Forms.RadioButton radioButtonGender;
        private System.Windows.Forms.RadioButton radioButtonSize;
        private System.Windows.Forms.RadioButton radioButtonColor;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.RadioButton radioButtonPrice;
        private System.Windows.Forms.Panel panelSize;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Panel panelPrice;
        private RJButton rjButtonClear;
    }
}