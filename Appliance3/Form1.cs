using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using applicies1;
using Appliance2;

namespace Appliance3
{
    public partial class Form1 : Form
    {
        public static Soket soket = new Soket();
        public Form1()
        {
            InitializeComponent();
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                listBox1.SelectedIndex = 0;
            if (soket.GetAppliances()[listBox1.SelectedIndex] is Computer)
            {
                Computer c = new Computer();
                c = (Computer)soket.GetAppliances()[listBox1.SelectedIndex];
                label2.Text = "Разрядность:";
                label3.Text = "Частота видеокарты:";
                label4.Text = Convert.ToString(c.GetDigit())+" бит";
                label5.Text = Convert.ToString(c.getVideoFrequency())+" ГГц";
            }
            if (soket.GetAppliances()[listBox1.SelectedIndex] is Telephone)
            {
                Telephone t = new Telephone();
                t = (Telephone)soket.GetAppliances()[listBox1.SelectedIndex];
                label2.Text = "Разрядность:";
                label3.Text = "Сопротивление преобразователя:";
                label4.Text = Convert.ToString(t.GetDigit())+" бит";
                label5.Text = Convert.ToString(t.getTransducerResistance())+" КОм";
            }
            if (soket.GetAppliances()[listBox1.SelectedIndex] is Refrigerator)
            {
                Refrigerator r = new Refrigerator();
                r = (Refrigerator)soket.GetAppliances()[listBox1.SelectedIndex];
                label2.Text = "Темпервтурный коэфициент:";
                label3.Text = "Сопротивление якоря:";
                label4.Text = Convert.ToString(r.getTemperatureСoefficient());
                label5.Text = Convert.ToString(r.getAnchorResistance())+ " КОм";
            }
            if (soket.GetAppliances()[listBox1.SelectedIndex] is Microwave)
            {
                Microwave m = new Microwave();
                m = (Microwave)soket.GetAppliances()[listBox1.SelectedIndex];
                label2.Text = "Температурный коэфициент:";
                label3.Text = "КПД Магнетрона:";
                label4.Text = Convert.ToString(m.getTemperatureСoefficient());
                label5.Text = Convert.ToString(m.getMagnetronEfficiency())+" %";
            }
            label8.Text = Convert.ToString(soket.GetAppliances()[listBox1.SelectedIndex].getPower())+ " Вт";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Soket soketfactory = SoketFactory.CreateSoket();
            for (int i = 0; i < soketfactory.GetAppliances().Count(); i++)
            {
                soket.AddAppliance(soketfactory.GetAppliances()[i]);
                listBox1.Items.Add(soketfactory.GetAppliances()[i].Name);
            }
            listBox1.SelectedIndex = 0;
            label7.Text = "Мощность электроприбора";
            label1.Text = Convert.ToString(soket.GetSumPowerty())+" Вт";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            if (soket.GetAppliances().Count() > listBox1.Items.Count)
            {
                int n = soket.GetAppliances().Count();
                listBox1.Items.Add(soket.GetAppliances()[n - 1].Name);
                label1.Text = Convert.ToString(soket.GetSumPowerty())+ " Вт";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int j = listBox1.SelectedIndex;
            Form2 form2 = new Form2(j);
            form2.ShowDialog();
            listBox1.Items[j] = soket.GetAppliances()[j].Name;
            label1.Text = Convert.ToString(soket.GetSumPowerty())+" Вт";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 1)
            {
                MessageBox.Show("Вы не можете удалить последний электроприбор", "Ошибка!", MessageBoxButtons.OK);
            }
            else
            {
                int j = listBox1.SelectedIndex;
                soket.DelAppliance(soket.GetAppliances()[j]);
                listBox1.Items.RemoveAt(j);
                label1.Text = Convert.ToString(soket.GetSumPowerty()) + " Вт";
            }
        }
    }
}
