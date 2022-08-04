namespace lab4
{
    partial class search
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tsearch = new System.Windows.Forms.TextBox();
            this.lprice = new System.Windows.Forms.Label();
            this.lcount = new System.Windows.Forms.Label();
            this.lnumber = new System.Windows.Forms.Label();
            this.linventory = new System.Windows.Forms.Label();
            this.lobjname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(284, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tsearch
            // 
            this.tsearch.Location = new System.Drawing.Point(291, 120);
            this.tsearch.Name = "tsearch";
            this.tsearch.Size = new System.Drawing.Size(207, 20);
            this.tsearch.TabIndex = 2;
            this.tsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lprice
            // 
            this.lprice.AutoSize = true;
            this.lprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lprice.Location = new System.Drawing.Point(148, 274);
            this.lprice.Name = "lprice";
            this.lprice.Size = new System.Drawing.Size(0, 37);
            this.lprice.TabIndex = 5;
            this.lprice.Click += new System.EventHandler(this.lprice_Click);
            // 
            // lcount
            // 
            this.lcount.AutoSize = true;
            this.lcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcount.Location = new System.Drawing.Point(306, 274);
            this.lcount.Name = "lcount";
            this.lcount.Size = new System.Drawing.Size(0, 37);
            this.lcount.TabIndex = 6;
            this.lcount.Click += new System.EventHandler(this.label2_Click);
            // 
            // lnumber
            // 
            this.lnumber.AutoSize = true;
            this.lnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnumber.Location = new System.Drawing.Point(12, 274);
            this.lnumber.Name = "lnumber";
            this.lnumber.Size = new System.Drawing.Size(0, 37);
            this.lnumber.TabIndex = 7;
            this.lnumber.Click += new System.EventHandler(this.label3_Click);
            // 
            // linventory
            // 
            this.linventory.AutoSize = true;
            this.linventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linventory.Location = new System.Drawing.Point(454, 274);
            this.linventory.Name = "linventory";
            this.linventory.Size = new System.Drawing.Size(0, 37);
            this.linventory.TabIndex = 8;
            this.linventory.Click += new System.EventHandler(this.label4_Click);
            // 
            // lobjname
            // 
            this.lobjname.AutoSize = true;
            this.lobjname.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lobjname.Location = new System.Drawing.Point(636, 274);
            this.lobjname.Name = "lobjname";
            this.lobjname.Size = new System.Drawing.Size(0, 37);
            this.lobjname.TabIndex = 9;
            this.lobjname.Click += new System.EventHandler(this.label5_Click);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lobjname);
            this.Controls.Add(this.linventory);
            this.Controls.Add(this.lnumber);
            this.Controls.Add(this.lcount);
            this.Controls.Add(this.lprice);
            this.Controls.Add(this.tsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "search";
            this.Load += new System.EventHandler(this.search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tsearch;
        private System.Windows.Forms.Label lprice;
        private System.Windows.Forms.Label lcount;
        private System.Windows.Forms.Label lnumber;
        private System.Windows.Forms.Label linventory;
        private System.Windows.Forms.Label lobjname;
    }
}