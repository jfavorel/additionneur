﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsADDITIONNEUR
{

    public partial class FormAdditionneur : Form
    {
        // Variables

        int somme;


        public FormAdditionneur()
        {
            InitializeComponent();
        }

        private void bt_default_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += ((Button)sender).Text + " + ";
            somme += int.Parse(((Button)sender).Text);
        }



        private void bt_vider_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            somme = 0;
        }

        private void bt_calculer_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + somme.ToString() + " + ";

        }

        private void FormAdditionneur_Load(object sender, EventArgs e)
        {

        }
    }
}
