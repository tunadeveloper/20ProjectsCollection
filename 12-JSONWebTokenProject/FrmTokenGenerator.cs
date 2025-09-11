﻿using _12_JSONWebTokenProject.JWT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_JSONWebTokenProject
{
    public partial class FrmTokenGenerator : Form
    {
        public FrmTokenGenerator()
        {
            InitializeComponent();
        }

        private void btnGenerateToken_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string name = txtFirstName.Text;
            string surname = txtLastName.Text;
            TokenGenerator tokenGenerator = new TokenGenerator();
            string token = tokenGenerator.GenerateJSONWebToken(username, email, name, surname);
            rtbToken.Text = token;
        }
    }
}
