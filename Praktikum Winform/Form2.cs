﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_Winform
{
    public partial class Form2: Form
    {
        public Form2(string username)
        {
            InitializeComponent();
            SapaUsername.Text = $"Halo Bang {username}";
        }
    }
}
