namespace lab4
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inventory = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.objectname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.ErrorProvider(this.components);
            this.priceerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.displaytable = new System.Windows.Forms.DataGridView();
            this.objname = new System.Windows.Forms.ErrorProvider(this.components);
            this.inv = new System.Windows.Forms.ErrorProvider(this.components);
            this.cnt = new System.Windows.Forms.ErrorProvider(this.components);
            this.isavaliable = new System.Windows.Forms.CheckBox();
            this.chklist = new System.Windows.Forms.CheckedListBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displaytable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnt)).BeginInit();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(32, 55);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(123, 20);
            this.number.TabIndex = 1;
            this.number.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(32, 250);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(134, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(429, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inventory number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // inventory
            // 
            this.inventory.Location = new System.Drawing.Point(425, 58);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(256, 20);
            this.inventory.TabIndex = 4;
            this.inventory.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(193, 55);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(182, 20);
            this.date.TabIndex = 5;
            this.date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(220, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // objectname
            // 
            this.objectname.Location = new System.Drawing.Point(32, 133);
            this.objectname.Name = "objectname";
            this.objectname.Size = new System.Drawing.Size(649, 20);
            this.objectname.TabIndex = 8;
            this.objectname.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "object name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(29, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "count";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(260, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(32, 211);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(203, 20);
            this.count.TabIndex = 12;
            this.count.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(265, 211);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(152, 20);
            this.price.TabIndex = 13;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(265, 250);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(152, 23);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // name
            // 
            this.name.ContainerControl = this;
            // 
            // priceerror
            // 
            this.priceerror.ContainerControl = this;
            // 
            // displaytable
            // 
            this.displaytable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displaytable.Location = new System.Drawing.Point(32, 301);
            this.displaytable.Name = "displaytable";
            this.displaytable.Size = new System.Drawing.Size(575, 150);
            this.displaytable.TabIndex = 15;
            this.displaytable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displaytable_CellContentClick_1);
            // 
            // objname
            // 
            this.objname.ContainerControl = this;
            // 
            // inv
            // 
            this.inv.ContainerControl = this;
            // 
            // cnt
            // 
            this.cnt.ContainerControl = this;
            // 
            // isavaliable
            // 
            this.isavaliable.AutoSize = true;
            this.isavaliable.Location = new System.Drawing.Point(710, 61);
            this.isavaliable.Name = "isavaliable";
            this.isavaliable.Size = new System.Drawing.Size(78, 17);
            this.isavaliable.TabIndex = 16;
            this.isavaliable.Text = "is avaliable";
            this.isavaliable.UseVisualStyleBackColor = true;
            this.isavaliable.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chklist
            // 
            this.chklist.FormattingEnabled = true;
            this.chklist.Items.AddRange(new object[] {
            "is regular",
            "is working",
            "is playing"});
            this.chklist.Location = new System.Drawing.Point(425, 167);
            this.chklist.Name = "chklist";
            this.chklist.Size = new System.Drawing.Size(140, 64);
            this.chklist.TabIndex = 17;
            this.chklist.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(582, 167);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(56, 17);
            this.rb1.TabIndex = 18;
            this.rb1.TabStop = true;
            this.rb1.Text = "Simple";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(658, 167);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(98, 17);
            this.rb2.TabIndex = 19;
            this.rb2.TabStop = true;
            this.rb2.Text = "vaiable product";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.rb4);
            this.gb2.Controls.Add(this.rb3);
            this.gb2.Location = new System.Drawing.Point(582, 195);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(200, 100);
            this.gb2.TabIndex = 20;
            this.gb2.TabStop = false;
            this.gb2.Text = "payment";
            this.gb2.Enter += new System.EventHandler(this.gb2_Enter);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(50, 60);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(56, 17);
            this.rb4.TabIndex = 1;
            this.rb4.TabStop = true;
            this.rb4.Text = "paypal";
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(50, 19);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(119, 17);
            this.rb3.TabIndex = 0;
            this.rb3.TabStop = true;
            this.rb3.Text = "payment on delivery";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "un";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.chklist);
            this.Controls.Add(this.isavaliable);
            this.Controls.Add(this.displaytable);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.price);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.objectname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displaytable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnt)).EndInit();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inventory;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox objectname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ErrorProvider name;
        private System.Windows.Forms.ErrorProvider priceerror;
        private System.Windows.Forms.DataGridView displaytable;
        private System.Windows.Forms.ErrorProvider objname;
        private System.Windows.Forms.ErrorProvider inv;
        private System.Windows.Forms.ErrorProvider cnt;
        private System.Windows.Forms.CheckBox isavaliable;
        private System.Windows.Forms.CheckedListBox chklist;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.Label label7;
    }
}