﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projewithsql001
{
    public partial class ANAsayfa : Form
    {
        public ANAsayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Yonetici_işlemi yonetici_Işlemi=new Yonetici_işlemi();
            yonetici_Işlemi.ShowDialog();
        }
    }
}
