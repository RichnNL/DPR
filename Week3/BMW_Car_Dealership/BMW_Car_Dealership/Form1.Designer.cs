namespace BMW_Car_Dealership
{
    partial class Form1
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
            this.Welcome_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BMW_Selection = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Accessories = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome_Label
            // 
            this.Welcome_Label.AutoSize = true;
            this.Welcome_Label.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_Label.Location = new System.Drawing.Point(69, 45);
            this.Welcome_Label.Name = "Welcome_Label";
            this.Welcome_Label.Size = new System.Drawing.Size(492, 26);
            this.Welcome_Label.TabIndex = 1;
            this.Welcome_Label.Text = "Welcome to Tsankos BMW Car Dealship";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "We have the cheapest BMWs in all of Bulgaria";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BMW_Selection
            // 
            this.BMW_Selection.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BMW_Selection.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BMW_Selection.FormattingEnabled = true;
            this.BMW_Selection.ItemHeight = 20;
            this.BMW_Selection.Location = new System.Drawing.Point(12, 120);
            this.BMW_Selection.Name = "BMW_Selection";
            this.BMW_Selection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BMW_Selection.Size = new System.Drawing.Size(249, 264);
            this.BMW_Selection.TabIndex = 3;
            this.BMW_Selection.SelectedIndexChanged += new System.EventHandler(this.BMW_Selection_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(307, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Accessories
            // 
            this.Accessories.FormattingEnabled = true;
            this.Accessories.Location = new System.Drawing.Point(13, 422);
            this.Accessories.Name = "Accessories";
            this.Accessories.Size = new System.Drawing.Size(248, 109);
            this.Accessories.TabIndex = 5;
            this.Accessories.SelectedIndexChanged += new System.EventHandler(this.Accessories_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price : ";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.Location = new System.Drawing.Point(384, 443);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(51, 24);
            this.label_price.TabIndex = 7;
            this.label_price.Text = "0.00";
            this.label_price.UseWaitCursor = true;
            this.label_price.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(307, 347);
            this.label_description.MaximumSize = new System.Drawing.Size(400, 0);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(114, 24);
            this.label_description.TabIndex = 8;
            this.label_description.Text = "Description";
            this.label_description.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "само кеш/Cash Only";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 549);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Accessories);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BMW_Selection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Welcome_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox BMW_Selection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox Accessories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label3;
    }
}

