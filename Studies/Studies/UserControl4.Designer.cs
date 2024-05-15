namespace Studies
{
    partial class UserControl4
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            ÚjKurzus1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaption;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(16, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(163, 289);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(185, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(450, 320);
            dataGridView1.TabIndex = 5;
            // 
            // ÚjKurzus1
            // 
            ÚjKurzus1.Location = new Point(483, 341);
            ÚjKurzus1.Name = "ÚjKurzus1";
            ÚjKurzus1.Size = new Size(152, 23);
            ÚjKurzus1.TabIndex = 8;
            ÚjKurzus1.Text = "Új kurzus hozzáadása";
            ÚjKurzus1.UseVisualStyleBackColor = true;
            // 
            // UserControl4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ÚjKurzus1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Name = "UserControl4";
            Size = new Size(650, 384);
            Load += UserControl4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Button ÚjKurzus1;
    }
}
