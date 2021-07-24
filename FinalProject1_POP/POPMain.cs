﻿using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1_POP
{
    public partial class POPMain : Form
    {
        POPVO User;
        public POPMain(POPVO user)
        {
            InitializeComponent();
            User = user;
        }
        

        private void POPMain_Load(object sender, EventArgs e)
        {
            POPUser frmUser = new POPUser(User);
            openChildForm(frmUser);
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelCildForm.Controls.Add(childForm);
            PanelCildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new POPUser(User));
        }
        private void btnWork_Click(object sender, EventArgs e)
        {
            openChildForm(new POPWorkInfo(User));
        }
        private void POPMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
