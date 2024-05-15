namespace Studies
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            UserControl1 = new Button();
            UserControl2 = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            UserControl3 = new Button();
            UserControl4 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Location = new Point(119, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 426);
            panel1.TabIndex = 0;
            // 
            // UserControl1
            // 
            UserControl1.Location = new Point(24, 12);
            UserControl1.Name = "UserControl1";
            UserControl1.Size = new Size(89, 90);
            UserControl1.TabIndex = 0;
            UserControl1.Text = "UserControl1";
            UserControl1.UseVisualStyleBackColor = true;
            UserControl1.Click += UserControl1_Click;
            // 
            // UserControl2
            // 
            UserControl2.BackColor = SystemColors.ActiveCaption;
            UserControl2.Location = new Point(24, 122);
            UserControl2.Name = "UserControl2";
            UserControl2.Size = new Size(89, 90);
            UserControl2.TabIndex = 1;
            UserControl2.Text = "UserControl2";
            UserControl2.UseVisualStyleBackColor = false;
            UserControl2.Click += UserControl2_Click;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // UserControl3
            // 
            UserControl3.BackColor = Color.Fuchsia;
            UserControl3.Location = new Point(24, 234);
            UserControl3.Name = "UserControl3";
            UserControl3.Size = new Size(89, 90);
            UserControl3.TabIndex = 2;
            UserControl3.Text = "UserControl3";
            UserControl3.UseVisualStyleBackColor = false;
            UserControl3.Click += UserControl3_Click;
            // 
            // UserControl4
            // 
            UserControl4.BackColor = Color.White;
            UserControl4.Location = new Point(24, 348);
            UserControl4.Name = "UserControl4";
            UserControl4.Size = new Size(89, 90);
            UserControl4.TabIndex = 3;
            UserControl4.Text = "UserControl4";
            UserControl4.UseVisualStyleBackColor = false;
            UserControl4.Click += UserControl4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UserControl4);
            Controls.Add(UserControl3);
            Controls.Add(UserControl1);
            Controls.Add(panel1);
            Controls.Add(UserControl2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button UserControl1;
        private Button UserControl2;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button UserControl3;
        private Button UserControl4;
    }
}