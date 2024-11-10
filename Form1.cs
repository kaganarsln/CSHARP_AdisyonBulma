using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] bolme;
            int hsbmenu = 0;
            string a = "";

            int sayi = 0;

            for(int z  = 0; z <checkedListBox1.CheckedItems.Count; z++) 
            {
                a = checkedListBox1.CheckedItems[z].ToString();
                listBox1.Items.Add(a);
                bolme = a.Split('-', ' ');
                sayi = Convert.ToInt32(bolme[1]);
                hsbmenu += sayi;
            }
            label1.Text = "toplam ücret:" + hsbmenu.ToString();
            if (!string.IsNullOrEmpty(checkedListBox1.Text)) 

            {

                MessageBox.Show("lütfen bir seçim yapınız");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked== true) 
            {
                MessageBox.Show("bizi tercih ettiğiniz için teşekkür ederiz"); 
            }
            else if (radioButton2.Checked== true) 
            {
                MessageBox.Show("lütfen ödemenizi yapınız");
            }
            else 
            {
                MessageBox.Show("ödeme yapıldı mı acaba?");
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
