namespace lab4
{
    partial class displayallproducts
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
            this.displayall = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.displayall)).BeginInit();
            this.SuspendLayout();
            // 
            // displayall
            // 
            this.displayall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayall.Location = new System.Drawing.Point(22, 26);
            this.displayall.Name = "displayall";
            this.displayall.Size = new System.Drawing.Size(743, 398);
            this.displayall.TabIndex = 0;
            this.displayall.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // displayallproducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "displayallproducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "displayallproduct";
            this.Load += new System.EventHandler(this.displayallproduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView displayall;
    }
}