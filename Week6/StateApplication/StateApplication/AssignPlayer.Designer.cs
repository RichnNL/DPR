namespace StateApplication
{
    partial class AssignPlayer
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
            this.Set_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player1bet = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.player1bet)).BeginInit();
            this.SuspendLayout();
            // 
            // Set_Button
            // 
            this.Set_Button.Location = new System.Drawing.Point(121, 305);
            this.Set_Button.Name = "Set_Button";
            this.Set_Button.Size = new System.Drawing.Size(125, 55);
            this.Set_Button.TabIndex = 0;
            this.Set_Button.Text = "Set";
            this.Set_Button.UseVisualStyleBackColor = true;
            this.Set_Button.Click += new System.EventHandler(this.Set_Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Starting Chips";
            // 
            // player1bet
            // 
            this.player1bet.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.player1bet.Location = new System.Drawing.Point(125, 259);
            this.player1bet.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.player1bet.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.player1bet.Name = "player1bet";
            this.player1bet.Size = new System.Drawing.Size(134, 26);
            this.player1bet.TabIndex = 60;
            this.player1bet.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.player1bet.ValueChanged += new System.EventHandler(this.player1bet_ValueChanged);
            // 
            // AssignPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 403);
            this.Controls.Add(this.player1bet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Set_Button);
            this.Name = "AssignPlayer";
            this.Text = "AssignPlayer";
            this.Load += new System.EventHandler(this.AssignPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player1bet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Set_Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown player1bet;
    }
}