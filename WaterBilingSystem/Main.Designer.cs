namespace WaterBilingSystem
{
    partial class Main
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
            this.tbPrev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lbvRead = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPrev
            // 
            this.tbPrev.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrev.Location = new System.Drawing.Point(328, 129);
            this.tbPrev.Name = "tbPrev";
            this.tbPrev.Size = new System.Drawing.Size(177, 26);
            this.tbPrev.TabIndex = 0;
            this.tbPrev.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Previous Reading:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Present Reading:";
            // 
            // tbPres
            // 
            this.tbPres.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPres.Location = new System.Drawing.Point(328, 167);
            this.tbPres.Name = "tbPres";
            this.tbPres.Size = new System.Drawing.Size(177, 26);
            this.tbPres.TabIndex = 5;
            this.tbPres.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Classification:";
            // 
            // cboClass
            // 
            this.cboClass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClass.Items.AddRange(new object[] {
            "Commercial",
            "Residential"});
            this.cboClass.Location = new System.Drawing.Point(328, 206);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(177, 29);
            this.cboClass.TabIndex = 7;
            this.cboClass.Text = "Residential";
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount Due:";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.Crimson;
            this.lbAmount.Location = new System.Drawing.Point(324, 284);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(79, 21);
            this.lbAmount.TabIndex = 9;
            this.lbAmount.Text = "Php. 0.00";
            // 
            // btnCompute
            // 
            this.btnCompute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCompute.Location = new System.Drawing.Point(328, 327);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(177, 40);
            this.btnCompute.TabIndex = 10;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lbvRead
            // 
            this.lbvRead.AutoSize = true;
            this.lbvRead.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvRead.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbvRead.Location = new System.Drawing.Point(324, 250);
            this.lbvRead.Name = "lbvRead";
            this.lbvRead.Size = new System.Drawing.Size(19, 21);
            this.lbvRead.TabIndex = 12;
            this.lbvRead.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(179, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Volume Read:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "WATER BILLING SYSTEM";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(168, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbvRead);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrev);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Water Billing System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lbvRead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

