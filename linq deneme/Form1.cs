using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq_deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> liste = new List<string>();
        int list_len;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lst_ekle_Click(object sender, EventArgs e)
        {
            string tst;
            tst = textBox1.Text;
            liste.Add(tst);
            textBox1.Text = "";
            list_len = liste.Count;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstbx_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for(int i = 0; i < liste.Count; i++) 
            {
                listBox1.Items.Add(liste[i]);
                satir_sayi.Text = list_len.ToString();
            }
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            // Bilinen hata linq eklemesi yaparken liste sıfırlanmadığından aynısını tekrar ekliyor.
            if (listBox1.SelectedIndex > -1)
            {
                // listbox1'de seçilmiş satırdaki indexi alıp listedeki elemanı siler.
                int list_selecteditem = listBox1.SelectedIndex;
                liste.RemoveAt(list_selecteditem);
                //label1'i satır sayısına göre günceller.
                list_len = list_len - 1;
                satir_sayi.Text = list_len.ToString();
                //listbox1 içinde seçili satırı siler.
                string curItem = listBox1.SelectedItem.ToString();
                int index = listBox1.FindString(curItem);
                if (listBox1.SelectedIndex == -1)
                    MessageBox.Show("Item ListBox1 içinde bulunamıyor HATA!!!");
                else
                {
                    listBox1.SetSelected(index, true);
                    int sec = listBox1.SelectedIndex;
                    listBox1.Items.RemoveAt(sec);  
                }

            }
        }
        private void radioBTNlinq_Selected(object sender,EventArgs e) 
        {
            
        }
        private void Satir_sayi_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLNQ_Click(object sender, EventArgs e)
        {
            if (radioBTNlinq.Checked == true)
            {
                // listedeki elemanları diziye aktararılacak.
                string[] isimler = new string[list_len];
                for (int i = 0; i < list_len; i++)
                {
                    isimler[i] = liste[i];
                }
                // linq ile listbox içinde görünen isimler ilk harfe göre sıralanacak
                string[] dizidekiIsimler = isimler;
                IEnumerable<string> query = from kelime in dizidekiIsimler
                                            orderby kelime.Substring(0,1) 
                                            select kelime;
                foreach (string str in query)
                {
                    listBox2.Items.Add(str);
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
