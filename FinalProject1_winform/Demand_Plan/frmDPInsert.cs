﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1_winform
{
    public partial class frmDPInsert : Form
    {
        public frmDPInsert(string PlanID)
        {
            InitializeComponent();
            txt_PlanID.Text = PlanID;
        }
    }
}
