namespace StateApplication
{
    partial class GameBoard
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
            this.Player1_name = new System.Windows.Forms.Label();
            this.Player1Money_label = new System.Windows.Forms.Label();
            this.Player1CallButton = new System.Windows.Forms.Button();
            this.Player1FoldButton = new System.Windows.Forms.Button();
            this.Player1RaiseButton = new System.Windows.Forms.Button();
            this.Player1CheckButton = new System.Windows.Forms.Button();
            this.Player2CallButton = new System.Windows.Forms.Button();
            this.Player2FoldButton = new System.Windows.Forms.Button();
            this.Player2RaiseButton = new System.Windows.Forms.Button();
            this.Player2CheckButton = new System.Windows.Forms.Button();
            this.Player3CallButton = new System.Windows.Forms.Button();
            this.Player3FoldButton = new System.Windows.Forms.Button();
            this.Player3RaiseButton = new System.Windows.Forms.Button();
            this.Player3CheckButton = new System.Windows.Forms.Button();
            this.Player4CallButton = new System.Windows.Forms.Button();
            this.Player4FoldButton = new System.Windows.Forms.Button();
            this.Player4RaiseButton = new System.Windows.Forms.Button();
            this.Player4CheckButton = new System.Windows.Forms.Button();
            this.Player4Pb2 = new System.Windows.Forms.PictureBox();
            this.Player4Pb1 = new System.Windows.Forms.PictureBox();
            this.Player3Pb2 = new System.Windows.Forms.PictureBox();
            this.Player3Pb1 = new System.Windows.Forms.PictureBox();
            this.Player2Pb2 = new System.Windows.Forms.PictureBox();
            this.Player2Pb1 = new System.Windows.Forms.PictureBox();
            this.Player1Pb2 = new System.Windows.Forms.PictureBox();
            this.Player1Pb1 = new System.Windows.Forms.PictureBox();
            this.Player4Picture = new System.Windows.Forms.PictureBox();
            this.Player3Picture = new System.Windows.Forms.PictureBox();
            this.Player2Picture = new System.Windows.Forms.PictureBox();
            this.Player1Picture = new System.Windows.Forms.PictureBox();
            this.player2_money_label = new System.Windows.Forms.Label();
            this.Player2_name = new System.Windows.Forms.Label();
            this.Player3Money_Label = new System.Windows.Forms.Label();
            this.Player3_Name = new System.Windows.Forms.Label();
            this.Player4MoneyLabel = new System.Windows.Forms.Label();
            this.Player4Name_Label = new System.Windows.Forms.Label();
            this.player1_money = new System.Windows.Forms.Label();
            this.player2_money = new System.Windows.Forms.Label();
            this.player3_money = new System.Windows.Forms.Label();
            this.Player4_money = new System.Windows.Forms.Label();
            this.Player1betAmount = new System.Windows.Forms.NumericUpDown();
            this.Player2BetAmount = new System.Windows.Forms.NumericUpDown();
            this.Player3BetAmount = new System.Windows.Forms.NumericUpDown();
            this.Player4BetAmount = new System.Windows.Forms.NumericUpDown();
            this.textBoxPot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxCall = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player4Pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player4Pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3Pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3Pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player4Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1betAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2BetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3BetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player4BetAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1_name
            // 
            this.Player1_name.AutoSize = true;
            this.Player1_name.Location = new System.Drawing.Point(146, 28);
            this.Player1_name.Name = "Player1_name";
            this.Player1_name.Size = new System.Drawing.Size(61, 20);
            this.Player1_name.TabIndex = 12;
            this.Player1_name.Text = "Player1";
            // 
            // Player1Money_label
            // 
            this.Player1Money_label.AutoSize = true;
            this.Player1Money_label.Location = new System.Drawing.Point(146, 58);
            this.Player1Money_label.Name = "Player1Money_label";
            this.Player1Money_label.Size = new System.Drawing.Size(53, 20);
            this.Player1Money_label.TabIndex = 14;
            this.Player1Money_label.Text = "Chips:";
            // 
            // Player1CallButton
            // 
            this.Player1CallButton.Location = new System.Drawing.Point(230, 58);
            this.Player1CallButton.Name = "Player1CallButton";
            this.Player1CallButton.Size = new System.Drawing.Size(87, 52);
            this.Player1CallButton.TabIndex = 16;
            this.Player1CallButton.Text = "Call";
            this.Player1CallButton.UseVisualStyleBackColor = true;
            this.Player1CallButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Player1FoldButton
            // 
            this.Player1FoldButton.Location = new System.Drawing.Point(323, 58);
            this.Player1FoldButton.Name = "Player1FoldButton";
            this.Player1FoldButton.Size = new System.Drawing.Size(87, 52);
            this.Player1FoldButton.TabIndex = 17;
            this.Player1FoldButton.Text = "Fold";
            this.Player1FoldButton.UseVisualStyleBackColor = true;
            this.Player1FoldButton.Click += new System.EventHandler(this.Player1FoldButton_Click);
            // 
            // Player1RaiseButton
            // 
            this.Player1RaiseButton.Location = new System.Drawing.Point(416, 58);
            this.Player1RaiseButton.Name = "Player1RaiseButton";
            this.Player1RaiseButton.Size = new System.Drawing.Size(87, 52);
            this.Player1RaiseButton.TabIndex = 18;
            this.Player1RaiseButton.Text = "Raise";
            this.Player1RaiseButton.UseVisualStyleBackColor = true;
            this.Player1RaiseButton.Click += new System.EventHandler(this.Player1RaiseButton_Click);
            // 
            // Player1CheckButton
            // 
            this.Player1CheckButton.Location = new System.Drawing.Point(509, 58);
            this.Player1CheckButton.Name = "Player1CheckButton";
            this.Player1CheckButton.Size = new System.Drawing.Size(87, 52);
            this.Player1CheckButton.TabIndex = 19;
            this.Player1CheckButton.Text = "Check";
            this.Player1CheckButton.UseVisualStyleBackColor = true;
            this.Player1CheckButton.Click += new System.EventHandler(this.Player1CheckButton_Click);
            // 
            // Player2CallButton
            // 
            this.Player2CallButton.Location = new System.Drawing.Point(230, 226);
            this.Player2CallButton.Name = "Player2CallButton";
            this.Player2CallButton.Size = new System.Drawing.Size(87, 52);
            this.Player2CallButton.TabIndex = 24;
            this.Player2CallButton.Text = "Call";
            this.Player2CallButton.UseVisualStyleBackColor = true;
            this.Player2CallButton.Click += new System.EventHandler(this.Player2CallButton_Click);
            // 
            // Player2FoldButton
            // 
            this.Player2FoldButton.Location = new System.Drawing.Point(323, 226);
            this.Player2FoldButton.Name = "Player2FoldButton";
            this.Player2FoldButton.Size = new System.Drawing.Size(87, 52);
            this.Player2FoldButton.TabIndex = 25;
            this.Player2FoldButton.Text = "Fold";
            this.Player2FoldButton.UseVisualStyleBackColor = true;
            this.Player2FoldButton.Click += new System.EventHandler(this.Player2FoldButton_Click);
            // 
            // Player2RaiseButton
            // 
            this.Player2RaiseButton.Location = new System.Drawing.Point(416, 226);
            this.Player2RaiseButton.Name = "Player2RaiseButton";
            this.Player2RaiseButton.Size = new System.Drawing.Size(87, 52);
            this.Player2RaiseButton.TabIndex = 26;
            this.Player2RaiseButton.Text = "Raise";
            this.Player2RaiseButton.UseVisualStyleBackColor = true;
            this.Player2RaiseButton.Click += new System.EventHandler(this.Player2RaiseButton_Click);
            // 
            // Player2CheckButton
            // 
            this.Player2CheckButton.Location = new System.Drawing.Point(509, 226);
            this.Player2CheckButton.Name = "Player2CheckButton";
            this.Player2CheckButton.Size = new System.Drawing.Size(87, 52);
            this.Player2CheckButton.TabIndex = 27;
            this.Player2CheckButton.Text = "Check";
            this.Player2CheckButton.UseVisualStyleBackColor = true;
            this.Player2CheckButton.Click += new System.EventHandler(this.Player2CheckButton_Click);
            // 
            // Player3CallButton
            // 
            this.Player3CallButton.Location = new System.Drawing.Point(230, 378);
            this.Player3CallButton.Name = "Player3CallButton";
            this.Player3CallButton.Size = new System.Drawing.Size(87, 52);
            this.Player3CallButton.TabIndex = 28;
            this.Player3CallButton.Text = "Call";
            this.Player3CallButton.UseVisualStyleBackColor = true;
            this.Player3CallButton.Click += new System.EventHandler(this.Player3CallButton_Click);
            // 
            // Player3FoldButton
            // 
            this.Player3FoldButton.Location = new System.Drawing.Point(323, 378);
            this.Player3FoldButton.Name = "Player3FoldButton";
            this.Player3FoldButton.Size = new System.Drawing.Size(87, 52);
            this.Player3FoldButton.TabIndex = 29;
            this.Player3FoldButton.Text = "Fold";
            this.Player3FoldButton.UseVisualStyleBackColor = true;
            this.Player3FoldButton.Click += new System.EventHandler(this.Player3FoldButton_Click);
            // 
            // Player3RaiseButton
            // 
            this.Player3RaiseButton.Location = new System.Drawing.Point(416, 378);
            this.Player3RaiseButton.Name = "Player3RaiseButton";
            this.Player3RaiseButton.Size = new System.Drawing.Size(87, 52);
            this.Player3RaiseButton.TabIndex = 30;
            this.Player3RaiseButton.Text = "Raise";
            this.Player3RaiseButton.UseVisualStyleBackColor = true;
            this.Player3RaiseButton.Click += new System.EventHandler(this.Player3RaiseButton_Click);
            // 
            // Player3CheckButton
            // 
            this.Player3CheckButton.Location = new System.Drawing.Point(509, 378);
            this.Player3CheckButton.Name = "Player3CheckButton";
            this.Player3CheckButton.Size = new System.Drawing.Size(87, 52);
            this.Player3CheckButton.TabIndex = 31;
            this.Player3CheckButton.Text = "Check";
            this.Player3CheckButton.UseVisualStyleBackColor = true;
            this.Player3CheckButton.Click += new System.EventHandler(this.Player3CheckButton_Click);
            // 
            // Player4CallButton
            // 
            this.Player4CallButton.Location = new System.Drawing.Point(230, 531);
            this.Player4CallButton.Name = "Player4CallButton";
            this.Player4CallButton.Size = new System.Drawing.Size(87, 52);
            this.Player4CallButton.TabIndex = 32;
            this.Player4CallButton.Text = "Call";
            this.Player4CallButton.UseVisualStyleBackColor = true;
            this.Player4CallButton.Click += new System.EventHandler(this.Player4CallButton_Click);
            // 
            // Player4FoldButton
            // 
            this.Player4FoldButton.Location = new System.Drawing.Point(323, 531);
            this.Player4FoldButton.Name = "Player4FoldButton";
            this.Player4FoldButton.Size = new System.Drawing.Size(87, 52);
            this.Player4FoldButton.TabIndex = 33;
            this.Player4FoldButton.Text = "Fold";
            this.Player4FoldButton.UseVisualStyleBackColor = true;
            this.Player4FoldButton.Click += new System.EventHandler(this.Player4FoldButton_Click);
            // 
            // Player4RaiseButton
            // 
            this.Player4RaiseButton.Location = new System.Drawing.Point(416, 531);
            this.Player4RaiseButton.Name = "Player4RaiseButton";
            this.Player4RaiseButton.Size = new System.Drawing.Size(87, 52);
            this.Player4RaiseButton.TabIndex = 34;
            this.Player4RaiseButton.Text = "Raise";
            this.Player4RaiseButton.UseVisualStyleBackColor = true;
            this.Player4RaiseButton.Click += new System.EventHandler(this.Player4RaiseButton_Click);
            // 
            // Player4CheckButton
            // 
            this.Player4CheckButton.Location = new System.Drawing.Point(506, 531);
            this.Player4CheckButton.Name = "Player4CheckButton";
            this.Player4CheckButton.Size = new System.Drawing.Size(87, 52);
            this.Player4CheckButton.TabIndex = 35;
            this.Player4CheckButton.Text = "Check";
            this.Player4CheckButton.UseVisualStyleBackColor = true;
            this.Player4CheckButton.Click += new System.EventHandler(this.Player4CheckButton_Click);
            // 
            // Player4Pb2
            // 
            this.Player4Pb2.Location = new System.Drawing.Point(698, 481);
            this.Player4Pb2.Name = "Player4Pb2";
            this.Player4Pb2.Size = new System.Drawing.Size(71, 102);
            this.Player4Pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player4Pb2.TabIndex = 42;
            this.Player4Pb2.TabStop = false;
            // 
            // Player4Pb1
            // 
            this.Player4Pb1.Location = new System.Drawing.Point(610, 481);
            this.Player4Pb1.Name = "Player4Pb1";
            this.Player4Pb1.Size = new System.Drawing.Size(71, 102);
            this.Player4Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player4Pb1.TabIndex = 41;
            this.Player4Pb1.TabStop = false;
            // 
            // Player3Pb2
            // 
            this.Player3Pb2.Location = new System.Drawing.Point(698, 328);
            this.Player3Pb2.Name = "Player3Pb2";
            this.Player3Pb2.Size = new System.Drawing.Size(71, 102);
            this.Player3Pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player3Pb2.TabIndex = 40;
            this.Player3Pb2.TabStop = false;
            // 
            // Player3Pb1
            // 
            this.Player3Pb1.Location = new System.Drawing.Point(610, 328);
            this.Player3Pb1.Name = "Player3Pb1";
            this.Player3Pb1.Size = new System.Drawing.Size(71, 102);
            this.Player3Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player3Pb1.TabIndex = 39;
            this.Player3Pb1.TabStop = false;
            // 
            // Player2Pb2
            // 
            this.Player2Pb2.Location = new System.Drawing.Point(698, 176);
            this.Player2Pb2.Name = "Player2Pb2";
            this.Player2Pb2.Size = new System.Drawing.Size(71, 102);
            this.Player2Pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2Pb2.TabIndex = 38;
            this.Player2Pb2.TabStop = false;
            // 
            // Player2Pb1
            // 
            this.Player2Pb1.Location = new System.Drawing.Point(610, 176);
            this.Player2Pb1.Name = "Player2Pb1";
            this.Player2Pb1.Size = new System.Drawing.Size(71, 102);
            this.Player2Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2Pb1.TabIndex = 37;
            this.Player2Pb1.TabStop = false;
            // 
            // Player1Pb2
            // 
            this.Player1Pb2.Location = new System.Drawing.Point(698, 28);
            this.Player1Pb2.Name = "Player1Pb2";
            this.Player1Pb2.Size = new System.Drawing.Size(71, 102);
            this.Player1Pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1Pb2.TabIndex = 36;
            this.Player1Pb2.TabStop = false;
            // 
            // Player1Pb1
            // 
            this.Player1Pb1.Location = new System.Drawing.Point(610, 28);
            this.Player1Pb1.Name = "Player1Pb1";
            this.Player1Pb1.Size = new System.Drawing.Size(71, 102);
            this.Player1Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1Pb1.TabIndex = 4;
            this.Player1Pb1.TabStop = false;
            // 
            // Player4Picture
            // 
            this.Player4Picture.Image = global::StateApplication.Properties.Resources.player3;
            this.Player4Picture.Location = new System.Drawing.Point(21, 481);
            this.Player4Picture.Name = "Player4Picture";
            this.Player4Picture.Size = new System.Drawing.Size(107, 102);
            this.Player4Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player4Picture.TabIndex = 3;
            this.Player4Picture.TabStop = false;
            // 
            // Player3Picture
            // 
            this.Player3Picture.Image = global::StateApplication.Properties.Resources.player2;
            this.Player3Picture.Location = new System.Drawing.Point(21, 328);
            this.Player3Picture.Name = "Player3Picture";
            this.Player3Picture.Size = new System.Drawing.Size(107, 102);
            this.Player3Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player3Picture.TabIndex = 2;
            this.Player3Picture.TabStop = false;
            // 
            // Player2Picture
            // 
            this.Player2Picture.Image = global::StateApplication.Properties.Resources.player1;
            this.Player2Picture.Location = new System.Drawing.Point(21, 185);
            this.Player2Picture.Name = "Player2Picture";
            this.Player2Picture.Size = new System.Drawing.Size(107, 102);
            this.Player2Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player2Picture.TabIndex = 1;
            this.Player2Picture.TabStop = false;
            // 
            // Player1Picture
            // 
            this.Player1Picture.Image = global::StateApplication.Properties.Resources.player0;
            this.Player1Picture.InitialImage = global::StateApplication.Properties.Resources.player0;
            this.Player1Picture.Location = new System.Drawing.Point(21, 28);
            this.Player1Picture.Name = "Player1Picture";
            this.Player1Picture.Size = new System.Drawing.Size(107, 102);
            this.Player1Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player1Picture.TabIndex = 0;
            this.Player1Picture.TabStop = false;
            // 
            // player2_money_label
            // 
            this.player2_money_label.AutoSize = true;
            this.player2_money_label.Location = new System.Drawing.Point(145, 215);
            this.player2_money_label.Name = "player2_money_label";
            this.player2_money_label.Size = new System.Drawing.Size(53, 20);
            this.player2_money_label.TabIndex = 45;
            this.player2_money_label.Text = "Chips:";
            // 
            // Player2_name
            // 
            this.Player2_name.AutoSize = true;
            this.Player2_name.Location = new System.Drawing.Point(145, 185);
            this.Player2_name.Name = "Player2_name";
            this.Player2_name.Size = new System.Drawing.Size(61, 20);
            this.Player2_name.TabIndex = 43;
            this.Player2_name.Text = "Player2";
            // 
            // Player3Money_Label
            // 
            this.Player3Money_Label.AutoSize = true;
            this.Player3Money_Label.Location = new System.Drawing.Point(146, 358);
            this.Player3Money_Label.Name = "Player3Money_Label";
            this.Player3Money_Label.Size = new System.Drawing.Size(49, 20);
            this.Player3Money_Label.TabIndex = 49;
            this.Player3Money_Label.Text = "Chips";
            // 
            // Player3_Name
            // 
            this.Player3_Name.AutoSize = true;
            this.Player3_Name.Location = new System.Drawing.Point(146, 335);
            this.Player3_Name.Name = "Player3_Name";
            this.Player3_Name.Size = new System.Drawing.Size(61, 20);
            this.Player3_Name.TabIndex = 47;
            this.Player3_Name.Text = "Player3";
            // 
            // Player4MoneyLabel
            // 
            this.Player4MoneyLabel.AutoSize = true;
            this.Player4MoneyLabel.Location = new System.Drawing.Point(146, 511);
            this.Player4MoneyLabel.Name = "Player4MoneyLabel";
            this.Player4MoneyLabel.Size = new System.Drawing.Size(49, 20);
            this.Player4MoneyLabel.TabIndex = 53;
            this.Player4MoneyLabel.Text = "Chips";
            // 
            // Player4Name_Label
            // 
            this.Player4Name_Label.AutoSize = true;
            this.Player4Name_Label.Location = new System.Drawing.Point(146, 481);
            this.Player4Name_Label.Name = "Player4Name_Label";
            this.Player4Name_Label.Size = new System.Drawing.Size(61, 20);
            this.Player4Name_Label.TabIndex = 51;
            this.Player4Name_Label.Text = "Player4";
            // 
            // player1_money
            // 
            this.player1_money.AutoSize = true;
            this.player1_money.Location = new System.Drawing.Point(134, 90);
            this.player1_money.Name = "player1_money";
            this.player1_money.Size = new System.Drawing.Size(0, 20);
            this.player1_money.TabIndex = 55;
            // 
            // player2_money
            // 
            this.player2_money.AutoSize = true;
            this.player2_money.Location = new System.Drawing.Point(134, 242);
            this.player2_money.Name = "player2_money";
            this.player2_money.Size = new System.Drawing.Size(0, 20);
            this.player2_money.TabIndex = 56;
            // 
            // player3_money
            // 
            this.player3_money.AutoSize = true;
            this.player3_money.Location = new System.Drawing.Point(134, 378);
            this.player3_money.Name = "player3_money";
            this.player3_money.Size = new System.Drawing.Size(0, 20);
            this.player3_money.TabIndex = 57;
            // 
            // Player4_money
            // 
            this.Player4_money.AutoSize = true;
            this.Player4_money.Location = new System.Drawing.Point(134, 547);
            this.Player4_money.Name = "Player4_money";
            this.Player4_money.Size = new System.Drawing.Size(0, 20);
            this.Player4_money.TabIndex = 58;
            // 
            // Player1betAmount
            // 
            this.Player1betAmount.Location = new System.Drawing.Point(21, 139);
            this.Player1betAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Player1betAmount.Name = "Player1betAmount";
            this.Player1betAmount.Size = new System.Drawing.Size(107, 26);
            this.Player1betAmount.TabIndex = 59;
            this.Player1betAmount.ValueChanged += new System.EventHandler(this.Player1betAmount_ValueChanged);
            // 
            // Player2BetAmount
            // 
            this.Player2BetAmount.Location = new System.Drawing.Point(21, 293);
            this.Player2BetAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Player2BetAmount.Name = "Player2BetAmount";
            this.Player2BetAmount.Size = new System.Drawing.Size(107, 26);
            this.Player2BetAmount.TabIndex = 60;
            this.Player2BetAmount.ValueChanged += new System.EventHandler(this.Player2BetAmount_ValueChanged);
            // 
            // Player3BetAmount
            // 
            this.Player3BetAmount.Location = new System.Drawing.Point(21, 443);
            this.Player3BetAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Player3BetAmount.Name = "Player3BetAmount";
            this.Player3BetAmount.Size = new System.Drawing.Size(107, 26);
            this.Player3BetAmount.TabIndex = 61;
            this.Player3BetAmount.ValueChanged += new System.EventHandler(this.Player3BetAmount_ValueChanged);
            // 
            // Player4BetAmount
            // 
            this.Player4BetAmount.Location = new System.Drawing.Point(21, 589);
            this.Player4BetAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Player4BetAmount.Name = "Player4BetAmount";
            this.Player4BetAmount.Size = new System.Drawing.Size(107, 26);
            this.Player4BetAmount.TabIndex = 62;
            this.Player4BetAmount.ValueChanged += new System.EventHandler(this.Player4BetAmount_ValueChanged);
            // 
            // textBoxPot
            // 
            this.textBoxPot.Location = new System.Drawing.Point(451, 7);
            this.textBoxPot.Name = "textBoxPot";
            this.textBoxPot.ReadOnly = true;
            this.textBoxPot.Size = new System.Drawing.Size(142, 26);
            this.textBoxPot.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Pot";
            // 
            // textboxCall
            // 
            this.textboxCall.Location = new System.Drawing.Point(304, 7);
            this.textboxCall.Name = "textboxCall";
            this.textboxCall.ReadOnly = true;
            this.textboxCall.Size = new System.Drawing.Size(102, 26);
            this.textboxCall.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "To Call:";
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 651);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxCall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPot);
            this.Controls.Add(this.Player4BetAmount);
            this.Controls.Add(this.Player3BetAmount);
            this.Controls.Add(this.Player2BetAmount);
            this.Controls.Add(this.Player1betAmount);
            this.Controls.Add(this.Player4_money);
            this.Controls.Add(this.player3_money);
            this.Controls.Add(this.player2_money);
            this.Controls.Add(this.player1_money);
            this.Controls.Add(this.Player4MoneyLabel);
            this.Controls.Add(this.Player4Name_Label);
            this.Controls.Add(this.Player3Money_Label);
            this.Controls.Add(this.Player3_Name);
            this.Controls.Add(this.player2_money_label);
            this.Controls.Add(this.Player2_name);
            this.Controls.Add(this.Player4Pb2);
            this.Controls.Add(this.Player4Pb1);
            this.Controls.Add(this.Player3Pb2);
            this.Controls.Add(this.Player3Pb1);
            this.Controls.Add(this.Player2Pb2);
            this.Controls.Add(this.Player2Pb1);
            this.Controls.Add(this.Player1Pb2);
            this.Controls.Add(this.Player4CheckButton);
            this.Controls.Add(this.Player4RaiseButton);
            this.Controls.Add(this.Player4FoldButton);
            this.Controls.Add(this.Player4CallButton);
            this.Controls.Add(this.Player3CheckButton);
            this.Controls.Add(this.Player3RaiseButton);
            this.Controls.Add(this.Player3FoldButton);
            this.Controls.Add(this.Player3CallButton);
            this.Controls.Add(this.Player2CheckButton);
            this.Controls.Add(this.Player2RaiseButton);
            this.Controls.Add(this.Player2FoldButton);
            this.Controls.Add(this.Player2CallButton);
            this.Controls.Add(this.Player1CheckButton);
            this.Controls.Add(this.Player1RaiseButton);
            this.Controls.Add(this.Player1FoldButton);
            this.Controls.Add(this.Player1CallButton);
            this.Controls.Add(this.Player1Money_label);
            this.Controls.Add(this.Player1_name);
            this.Controls.Add(this.Player1Pb1);
            this.Controls.Add(this.Player4Picture);
            this.Controls.Add(this.Player3Picture);
            this.Controls.Add(this.Player2Picture);
            this.Controls.Add(this.Player1Picture);
            this.Name = "GameBoard";
            this.Text = "GameBoard";
            this.Load += new System.EventHandler(this.GameBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player4Pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player4Pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3Pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3Pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player4Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1betAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2BetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3BetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player4BetAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1Picture;
        private System.Windows.Forms.PictureBox Player2Picture;
        private System.Windows.Forms.PictureBox Player3Picture;
        private System.Windows.Forms.PictureBox Player4Picture;
        private System.Windows.Forms.PictureBox Player1Pb1;
        private System.Windows.Forms.Label Player1_name;
        private System.Windows.Forms.Label Player1Money_label;
        private System.Windows.Forms.Button Player1CallButton;
        private System.Windows.Forms.Button Player1FoldButton;
        private System.Windows.Forms.Button Player1RaiseButton;
        private System.Windows.Forms.Button Player1CheckButton;
        private System.Windows.Forms.Button Player2CallButton;
        private System.Windows.Forms.Button Player2FoldButton;
        private System.Windows.Forms.Button Player2RaiseButton;
        private System.Windows.Forms.Button Player2CheckButton;
        private System.Windows.Forms.Button Player3CallButton;
        private System.Windows.Forms.Button Player3FoldButton;
        private System.Windows.Forms.Button Player3RaiseButton;
        private System.Windows.Forms.Button Player3CheckButton;
        private System.Windows.Forms.Button Player4CallButton;
        private System.Windows.Forms.Button Player4FoldButton;
        private System.Windows.Forms.Button Player4RaiseButton;
        private System.Windows.Forms.Button Player4CheckButton;
        private System.Windows.Forms.PictureBox Player1Pb2;
        private System.Windows.Forms.PictureBox Player2Pb1;
        private System.Windows.Forms.PictureBox Player2Pb2;
        private System.Windows.Forms.PictureBox Player3Pb1;
        private System.Windows.Forms.PictureBox Player3Pb2;
        private System.Windows.Forms.PictureBox Player4Pb1;
        private System.Windows.Forms.PictureBox Player4Pb2;
        private System.Windows.Forms.Label player2_money_label;
        private System.Windows.Forms.Label Player2_name;
        private System.Windows.Forms.Label Player3Money_Label;
        private System.Windows.Forms.Label Player3_Name;
        private System.Windows.Forms.Label Player4MoneyLabel;
        private System.Windows.Forms.Label Player4Name_Label;
        private System.Windows.Forms.Label player1_money;
        private System.Windows.Forms.Label player2_money;
        private System.Windows.Forms.Label player3_money;
        private System.Windows.Forms.Label Player4_money;
        private System.Windows.Forms.NumericUpDown Player1betAmount;
        private System.Windows.Forms.NumericUpDown Player2BetAmount;
        private System.Windows.Forms.NumericUpDown Player3BetAmount;
        private System.Windows.Forms.NumericUpDown Player4BetAmount;
        private System.Windows.Forms.TextBox textBoxPot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxCall;
        private System.Windows.Forms.Label label2;
    }
}