﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioManagement
{
    public partial class Stockwindow : Form
    {
        public Stockwindow(int uid)
        {
            InitializeComponent();
            label1.Text = "UserId: " + uid.ToString();
        }
    }
}