﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class FormÚjFutó : Form
    {
        public Futók ÚjFutó = new Futók();

        public FormÚjFutó()
        {
            InitializeComponent();
        }

        private void FormÚjFutó_Load(object sender, EventArgs e)
        {
            futókBindingSource.DataSource = ÚjFutó;
        }
    }
}
