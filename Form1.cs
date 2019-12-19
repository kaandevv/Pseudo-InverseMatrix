using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_RastgeleMatrisOlustur_Click(object sender, EventArgs e)
        {
           
            Form2 form = new Form2("RASTGELE");
            form.Show();
            this.Hide();
            form.FormClosed += Form_FormClosed; 
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e) // form 2 kapatılırsa form 1 i tekrar acılması icin
        {
            this.Show();
        }

        private void button_MatrisOlustur_Click(object sender, EventArgs e) // kullanici girisli  matris olusturma

        {
          
            Form2 form = new Form2("OZEL");
            form.Show();
            this.Hide();
            form.FormClosed += Form_FormClosed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
