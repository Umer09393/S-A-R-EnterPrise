﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace S_A_R_EnterPrise
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static string t1="";
        public static string t2="";
        public static string t3="";
        public static string t4="";

        Form2 f2 = new Form2();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        t1  =  textBox1.Text;
         t2 = textBox2.Text ;
            t3 = textBox3.Text;
            t4 = textBox4.Text;

           
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Regex uname = new Regex("");
            Regex cname = new Regex("");
            Regex phone = new Regex("");
            Regex address = new Regex("");



        }
        int cLeft = 1;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            f2.Show();
        }
    }
}
