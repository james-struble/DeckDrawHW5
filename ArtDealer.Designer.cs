using System.Windows.Forms;

namespace DeckDrawHW1
{
    partial class ArtDealer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtDealer));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Congrats = new System.Windows.Forms.PictureBox();
            this.PickACardMesage = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rankBoxCard4 = new System.Windows.Forms.ComboBox();
            this.suitBoxCard4 = new System.Windows.Forms.ComboBox();
            this.rankBoxCard3 = new System.Windows.Forms.ComboBox();
            this.suitBoxCard3 = new System.Windows.Forms.ComboBox();
            this.rankBoxCard2 = new System.Windows.Forms.ComboBox();
            this.suitBoxCard2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rankBoxCard1 = new System.Windows.Forms.ComboBox();
            this.suitBoxCard1 = new System.Windows.Forms.ComboBox();
            this.infoBox = new System.Windows.Forms.Label();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.DrawButton = new System.Windows.Forms.Button();
            this.SelectButton1 = new System.Windows.Forms.Button();
            this.SelectButton2 = new System.Windows.Forms.Button();
            this.SelectButton3 = new System.Windows.Forms.Button();
            this.SelectButton4 = new System.Windows.Forms.Button();
            this.labelCard1 = new System.Windows.Forms.Label();
            this.labelCard2 = new System.Windows.Forms.Label();
            this.labelCard3 = new System.Windows.Forms.Label();
            this.labelCard4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Congrats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.BackgroundImage = global::DeckDrawHW1.Properties.Resources.poker_table_texture;
            this.groupBox1.Controls.Add(this.Congrats);
            this.groupBox1.Controls.Add(this.PickACardMesage);
            this.groupBox1.Controls.Add(this.ResetButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rankBoxCard4);
            this.groupBox1.Controls.Add(this.suitBoxCard4);
            this.groupBox1.Controls.Add(this.rankBoxCard3);
            this.groupBox1.Controls.Add(this.suitBoxCard3);
            this.groupBox1.Controls.Add(this.rankBoxCard2);
            this.groupBox1.Controls.Add(this.suitBoxCard2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rankBoxCard1);
            this.groupBox1.Controls.Add(this.suitBoxCard1);
            this.groupBox1.Controls.Add(this.infoBox);
            this.groupBox1.Controls.Add(this.card4);
            this.groupBox1.Controls.Add(this.card3);
            this.groupBox1.Controls.Add(this.card2);
            this.groupBox1.Controls.Add(this.card1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StopButton);
            this.groupBox1.Controls.Add(this.DrawButton);
            this.groupBox1.Controls.Add(this.SelectButton1);
            this.groupBox1.Controls.Add(this.SelectButton2);
            this.groupBox1.Controls.Add(this.SelectButton3);
            this.groupBox1.Controls.Add(this.SelectButton4);
            this.groupBox1.Controls.Add(this.labelCard1);
            this.groupBox1.Controls.Add(this.labelCard2);
            this.groupBox1.Controls.Add(this.labelCard3);
            this.groupBox1.Controls.Add(this.labelCard4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(4, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1449, 743);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // Congrats
            // 
            this.Congrats.AccessibleName = "";
            this.Congrats.Image = ((System.Drawing.Image)(resources.GetObject("Congrats.Image")));
            this.Congrats.Location = new System.Drawing.Point(308, 194);
            this.Congrats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Congrats.Name = "Congrats";
            this.Congrats.Size = new System.Drawing.Size(823, 430);
            this.Congrats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Congrats.TabIndex = 26;
            this.Congrats.TabStop = false;
            this.Congrats.Visible = false;
            // 
            // PickACardMesage
            // 
            this.PickACardMesage.AutoSize = true;
            this.PickACardMesage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PickACardMesage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PickACardMesage.Location = new System.Drawing.Point(536, 134);
            this.PickACardMesage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PickACardMesage.Name = "PickACardMesage";
            this.PickACardMesage.Size = new System.Drawing.Size(362, 78);
            this.PickACardMesage.TabIndex = 24;
            this.PickACardMesage.Text = "Pick a Card! Any Card!\r\n(No duplicates!)";
            this.PickACardMesage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResetButton
            // 
            this.ResetButton.AutoSize = true;
            this.ResetButton.BackColor = System.Drawing.Color.Green;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(193, 631);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(436, 102);
            this.ResetButton.TabIndex = 23;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1171, 81);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(229, 176);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(1220, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "HISTORY";
            // 
            // rankBoxCard4
            // 
            this.rankBoxCard4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rankBoxCard4.FormattingEnabled = true;
            this.rankBoxCard4.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.rankBoxCard4.Location = new System.Drawing.Point(931, 516);
            this.rankBoxCard4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rankBoxCard4.Name = "rankBoxCard4";
            this.rankBoxCard4.Size = new System.Drawing.Size(188, 24);
            this.rankBoxCard4.TabIndex = 21;
            this.rankBoxCard4.SelectedIndexChanged += new System.EventHandler(this.rankBoxCard4_SelectedIndexChanged);
            // 
            // suitBoxCard4
            // 
            this.suitBoxCard4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suitBoxCard4.FormattingEnabled = true;
            this.suitBoxCard4.Items.AddRange(new object[] {
            "Hearts",
            "Clubs",
            "Diamonds",
            "Spades"});
            this.suitBoxCard4.Location = new System.Drawing.Point(931, 549);
            this.suitBoxCard4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suitBoxCard4.Name = "suitBoxCard4";
            this.suitBoxCard4.Size = new System.Drawing.Size(188, 24);
            this.suitBoxCard4.TabIndex = 20;
            this.suitBoxCard4.SelectedIndexChanged += new System.EventHandler(this.suitBoxCard4_SelectedIndexChanged);
            // 
            // rankBoxCard3
            // 
            this.rankBoxCard3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rankBoxCard3.FormattingEnabled = true;
            this.rankBoxCard3.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.rankBoxCard3.Location = new System.Drawing.Point(733, 516);
            this.rankBoxCard3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rankBoxCard3.Name = "rankBoxCard3";
            this.rankBoxCard3.Size = new System.Drawing.Size(188, 24);
            this.rankBoxCard3.TabIndex = 19;
            this.rankBoxCard3.SelectedIndexChanged += new System.EventHandler(this.rankBoxCard3_SelectedIndexChanged);
            // 
            // suitBoxCard3
            // 
            this.suitBoxCard3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suitBoxCard3.FormattingEnabled = true;
            this.suitBoxCard3.Items.AddRange(new object[] {
            "Hearts",
            "Clubs",
            "Diamonds",
            "Spades"});
            this.suitBoxCard3.Location = new System.Drawing.Point(733, 549);
            this.suitBoxCard3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suitBoxCard3.Name = "suitBoxCard3";
            this.suitBoxCard3.Size = new System.Drawing.Size(188, 24);
            this.suitBoxCard3.TabIndex = 18;
            this.suitBoxCard3.SelectedIndexChanged += new System.EventHandler(this.suitBoxCard3_SelectedIndexChanged);
            // 
            // rankBoxCard2
            // 
            this.rankBoxCard2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rankBoxCard2.FormattingEnabled = true;
            this.rankBoxCard2.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.rankBoxCard2.Location = new System.Drawing.Point(536, 516);
            this.rankBoxCard2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rankBoxCard2.Name = "rankBoxCard2";
            this.rankBoxCard2.Size = new System.Drawing.Size(188, 24);
            this.rankBoxCard2.TabIndex = 17;
            this.rankBoxCard2.SelectedIndexChanged += new System.EventHandler(this.rankBoxCard2_SelectedIndexChanged);
            // 
            // suitBoxCard2
            // 
            this.suitBoxCard2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suitBoxCard2.FormattingEnabled = true;
            this.suitBoxCard2.Items.AddRange(new object[] {
            "Hearts",
            "Clubs",
            "Diamonds",
            "Spades"});
            this.suitBoxCard2.Location = new System.Drawing.Point(536, 549);
            this.suitBoxCard2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suitBoxCard2.Name = "suitBoxCard2";
            this.suitBoxCard2.Size = new System.Drawing.Size(188, 24);
            this.suitBoxCard2.TabIndex = 16;
            this.suitBoxCard2.SelectedIndexChanged += new System.EventHandler(this.suitBoxCard2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 550);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Suit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 517);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rank";
            // 
            // rankBoxCard1
            // 
            this.rankBoxCard1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rankBoxCard1.FormattingEnabled = true;
            this.rankBoxCard1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.rankBoxCard1.Location = new System.Drawing.Point(339, 516);
            this.rankBoxCard1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rankBoxCard1.Name = "rankBoxCard1";
            this.rankBoxCard1.Size = new System.Drawing.Size(188, 24);
            this.rankBoxCard1.TabIndex = 13;
            this.rankBoxCard1.SelectedIndexChanged += new System.EventHandler(this.rankBoxCard1_SelectedIndexChanged);
            // 
            // suitBoxCard1
            // 
            this.suitBoxCard1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suitBoxCard1.FormattingEnabled = true;
            this.suitBoxCard1.Items.AddRange(new object[] {
            "Hearts",
            "Clubs",
            "Diamonds",
            "Spades"});
            this.suitBoxCard1.Location = new System.Drawing.Point(339, 549);
            this.suitBoxCard1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suitBoxCard1.Name = "suitBoxCard1";
            this.suitBoxCard1.Size = new System.Drawing.Size(188, 24);
            this.suitBoxCard1.TabIndex = 12;
            this.suitBoxCard1.SelectedIndexChanged += new System.EventHandler(this.suitBoxCard1_SelectedIndexChanged);
            // 
            // infoBox
            // 
            this.infoBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoBox.AutoSize = true;
            this.infoBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.infoBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.infoBox.Location = new System.Drawing.Point(0, 0);
            this.infoBox.Margin = new System.Windows.Forms.Padding(0);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(342, 222);
            this.infoBox.TabIndex = 11;
            this.infoBox.Text = resources.GetString("infoBox.Text");
            // 
            // card4
            // 
            this.card4.BackColor = System.Drawing.Color.Transparent;
            this.card4.Location = new System.Drawing.Point(936, 238);
            this.card4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(189, 265);
            this.card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card4.TabIndex = 10;
            this.card4.TabStop = false;
            // 
            // card3
            // 
            this.card3.BackColor = System.Drawing.Color.Transparent;
            this.card3.Location = new System.Drawing.Point(736, 238);
            this.card3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(189, 265);
            this.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card3.TabIndex = 9;
            this.card3.TabStop = false;
            // 
            // card2
            // 
            this.card2.BackColor = System.Drawing.Color.Transparent;
            this.card2.Location = new System.Drawing.Point(533, 238);
            this.card2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(189, 265);
            this.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card2.TabIndex = 8;
            this.card2.TabStop = false;
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.Transparent;
            this.card1.Location = new System.Drawing.Point(333, 238);
            this.card1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(189, 265);
            this.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card1.TabIndex = 7;
            this.card1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(441, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(527, 77);
            this.label1.TabIndex = 6;
            this.label1.Text = "The Art Dealer";
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Red;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StopButton.Location = new System.Drawing.Point(773, 631);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(436, 102);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // DrawButton
            // 
            this.DrawButton.BackColor = System.Drawing.Color.Green;
            this.DrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawButton.ForeColor = System.Drawing.Color.White;
            this.DrawButton.Location = new System.Drawing.Point(193, 631);
            this.DrawButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(436, 102);
            this.DrawButton.TabIndex = 0;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = false;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // SelectButton1
            // 
            this.SelectButton1.AutoSize = true;
            this.SelectButton1.BackColor = System.Drawing.Color.Green;
            this.SelectButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton1.ForeColor = System.Drawing.Color.White;
            this.SelectButton1.Location = new System.Drawing.Point(339, 587);
            this.SelectButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectButton1.Name = "SelectButton1";
            this.SelectButton1.Size = new System.Drawing.Size(189, 43);
            this.SelectButton1.TabIndex = 23;
            this.SelectButton1.Text = "Select";
            this.SelectButton1.UseVisualStyleBackColor = false;
            this.SelectButton1.Click += new System.EventHandler(this.SelectButton1_Click);
            // 
            // SelectButton2
            // 
            this.SelectButton2.AutoSize = true;
            this.SelectButton2.BackColor = System.Drawing.Color.Green;
            this.SelectButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton2.ForeColor = System.Drawing.Color.White;
            this.SelectButton2.Location = new System.Drawing.Point(536, 587);
            this.SelectButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectButton2.Name = "SelectButton2";
            this.SelectButton2.Size = new System.Drawing.Size(189, 43);
            this.SelectButton2.TabIndex = 23;
            this.SelectButton2.Text = "Select";
            this.SelectButton2.UseVisualStyleBackColor = false;
            this.SelectButton2.Click += new System.EventHandler(this.SelectButton2_Click);
            // 
            // SelectButton3
            // 
            this.SelectButton3.AutoSize = true;
            this.SelectButton3.BackColor = System.Drawing.Color.Green;
            this.SelectButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton3.ForeColor = System.Drawing.Color.White;
            this.SelectButton3.Location = new System.Drawing.Point(733, 587);
            this.SelectButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectButton3.Name = "SelectButton3";
            this.SelectButton3.Size = new System.Drawing.Size(189, 43);
            this.SelectButton3.TabIndex = 23;
            this.SelectButton3.Text = "Select";
            this.SelectButton3.UseVisualStyleBackColor = false;
            this.SelectButton3.Click += new System.EventHandler(this.SelectButton3_Click);
            // 
            // SelectButton4
            // 
            this.SelectButton4.AutoSize = true;
            this.SelectButton4.BackColor = System.Drawing.Color.Green;
            this.SelectButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton4.ForeColor = System.Drawing.Color.White;
            this.SelectButton4.Location = new System.Drawing.Point(931, 587);
            this.SelectButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectButton4.Name = "SelectButton4";
            this.SelectButton4.Size = new System.Drawing.Size(189, 43);
            this.SelectButton4.TabIndex = 23;
            this.SelectButton4.Text = "Select";
            this.SelectButton4.UseVisualStyleBackColor = false;
            this.SelectButton4.Click += new System.EventHandler(this.SelectButton4_Click);
            // 
            // labelCard1
            // 
            this.labelCard1.BackColor = System.Drawing.Color.LightGreen;
            this.labelCard1.Location = new System.Drawing.Point(328, 233);
            this.labelCard1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCard1.Name = "labelCard1";
            this.labelCard1.Size = new System.Drawing.Size(200, 274);
            this.labelCard1.TabIndex = 25;
            // 
            // labelCard2
            // 
            this.labelCard2.BackColor = System.Drawing.Color.LightGreen;
            this.labelCard2.Location = new System.Drawing.Point(529, 233);
            this.labelCard2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCard2.Name = "labelCard2";
            this.labelCard2.Size = new System.Drawing.Size(200, 274);
            this.labelCard2.TabIndex = 25;
            // 
            // labelCard3
            // 
            this.labelCard3.BackColor = System.Drawing.Color.LightGreen;
            this.labelCard3.Location = new System.Drawing.Point(731, 233);
            this.labelCard3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCard3.Name = "labelCard3";
            this.labelCard3.Size = new System.Drawing.Size(200, 274);
            this.labelCard3.TabIndex = 25;
            // 
            // labelCard4
            // 
            this.labelCard4.BackColor = System.Drawing.Color.LightGreen;
            this.labelCard4.Location = new System.Drawing.Point(931, 233);
            this.labelCard4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCard4.Name = "labelCard4";
            this.labelCard4.Size = new System.Drawing.Size(200, 274);
            this.labelCard4.TabIndex = 25;
            // 
            // ArtDealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1452, 763);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ArtDealer";
            this.Text = "Art Dealer";
            this.Load += new System.EventHandler(this.ArtDealer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Congrats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button SelectButton1;
        private System.Windows.Forms.Button SelectButton2;
        private System.Windows.Forms.Button SelectButton3;
        private System.Windows.Forms.Button SelectButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox card4;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card2;
        private System.Windows.Forms.Label infoBox;
        private System.Windows.Forms.ComboBox suitBoxCard1;
        private System.Windows.Forms.ComboBox rankBoxCard1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rankBoxCard4;
        private System.Windows.Forms.ComboBox suitBoxCard4;
        private System.Windows.Forms.ComboBox rankBoxCard3;
        private System.Windows.Forms.ComboBox suitBoxCard3;
        private System.Windows.Forms.ComboBox rankBoxCard2;
        private System.Windows.Forms.ComboBox suitBoxCard2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label PickACardMesage;
        private System.Windows.Forms.Label labelCard1;
        private System.Windows.Forms.Label labelCard2;
        private System.Windows.Forms.Label labelCard3;
        private System.Windows.Forms.Label labelCard4;
        private PictureBox Congrats;
    }
}

