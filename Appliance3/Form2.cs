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

namespace Appliance3
{
    public partial class Form2 : Form
    {
        int index = 0;
        bool b = false;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int i)
        {
            InitializeComponent();
            index = i;
            b = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "") 
                    MessageBox.Show("Вы не ввели характеристики", "Ошибка!", MessageBoxButtons.OK);
                else
                {
                    if (radioButton1.Checked == true)
                    {
                        Computer c = new Computer();
                        c.Name = textBox1.Text;
                        c.SetDigit(Convert.ToInt32(comboBox1.Text));
                        c.setVideoFrequency(Convert.ToDouble(textBox3.Text));
                        Form1.soket.AddAppliance(c);
                    }
                    if (radioButton2.Checked == true)
                    {
                        Telephone t = new Telephone();
                        t.Name = textBox1.Text;
                        t.SetDigit(Convert.ToInt32(comboBox1.Text));
                        t.setTransducerResistance(Convert.ToDouble(textBox3.Text));
                        Form1.soket.AddAppliance(t);
                    }
                    if (radioButton3.Checked == true)
                    {
                        Refrigerator r = new Refrigerator();
                        r.Name = textBox1.Text;
                        r.setTemperatureCoefficient(Convert.ToDouble(textBox2.Text));
                        r.SetAnchorResistance(Convert.ToDouble(textBox3.Text));
                        Form1.soket.AddAppliance(r);
                    }
                    if (radioButton4.Checked == true)
                    {
                        Microwave m = new Microwave();
                        m.Name = textBox1.Text;
                        m.setTemperatureCoefficient(Convert.ToDouble(textBox2.Text));
                        m.setMagnetronEfficiency(Convert.ToDouble(textBox3.Text));
                        Form1.soket.AddAppliance(m);
                    }
                    this.Close();
                }
            }
            if (b == true)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
                    MessageBox.Show("Вы не ввели характеристики", "Ошибка!", MessageBoxButtons.OK);
                else
                {
                    if (Form1.soket.GetAppliances()[index] is Computer)
                    {
                        Computer c = new Computer();
                        c.Name = textBox1.Text;
                        c.SetDigit(Convert.ToInt32(textBox2.Text));
                        c.setVideoFrequency(Convert.ToDouble(textBox3.Text));
                        Form1.soket.GetAppliances()[index] = c;
                    }
                    if (Form1.soket.GetAppliances()[index] is Telephone)
                    {
                        Telephone t = new Telephone();
                        t.Name = textBox1.Text;
                        t.SetDigit(Convert.ToInt32(textBox2.Text));
                        t.setTransducerResistance(Convert.ToDouble(textBox3.Text));
                        Form1.soket.GetAppliances()[index] = t;
                    }
                    if (Form1.soket.GetAppliances()[index] is Refrigerator)
                    {
                        Refrigerator r = new Refrigerator();
                        r.Name = textBox1.Text;
                        r.setTemperatureCoefficient(Convert.ToDouble(textBox2.Text));
                        r.SetAnchorResistance(Convert.ToDouble(textBox3.Text));
                        Form1.soket.GetAppliances()[index] = r;
                    }
                    if (Form1.soket.GetAppliances()[index] is Microwave)
                    {
                        Microwave m = new Microwave();
                        m.Name = textBox1.Text;
                        m.setTemperatureCoefficient(Convert.ToDouble(textBox2.Text));
                        m.setMagnetronEfficiency(Convert.ToDouble(textBox3.Text));
                        Form1.soket.GetAppliances()[index] = m;
                    }
                    this.Close();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (b == true)
            {
                groupBox2.Hide();
                button1.Text = "Редактировать";
                if (Form1.soket.GetAppliances()[index] is Computer)
                {
                    Computer c = new Computer();
                    c = (Computer)Form1.soket.GetAppliances()[index];
                    textBox2.Hide();
                    comboBox1.Show();
                    label1.Text = "название компьютера";
                    textBox1.Text = c.Name;
                    label2.Text = "разрядность";
                    comboBox1.Text = Convert.ToString(c.GetDigit());
                    label3.Text = "частота видеокарты";
                    textBox3.Text = Convert.ToString(c.getVideoFrequency());
                    textBox2.Text = "1";
                }
                if (Form1.soket.GetAppliances()[index] is Telephone)
                {
                    Telephone t = new Telephone();
                    t = (Telephone)Form1.soket.GetAppliances()[index];
                    textBox2.Hide();
                    comboBox1.Show();
                    label1.Text = "название телефона:";
                    textBox1.Text = t.Name;
                    label2.Text = "разрядность";
                    comboBox1.Text = Convert.ToString(t.GetDigit());
                    label3.Text = "Сопротивление преобразователя:";
                    textBox3.Text = Convert.ToString(t.getTransducerResistance());
                    textBox2.Text = "1";
                }
                if (Form1.soket.GetAppliances()[index] is Refrigerator)
                {
                    Refrigerator r = new Refrigerator();
                    r = (Refrigerator)Form1.soket.GetAppliances()[index];
                    comboBox1.Hide();
                    textBox2.Show();
                    label1.Text = "название холодильника";
                    textBox1.Text = r.Name;
                    label2.Text = "температурный коэффициент";
                    textBox2.Text = Convert.ToString(r.getTemperatureСoefficient());
                    label3.Text = "сопротивление якоря";
                    textBox3.Text = Convert.ToString(r.getAnchorResistance());
                    comboBox1.Text = "1";
                }
                if (Form1.soket.GetAppliances()[index] is Microwave)
                {
                    Microwave m = new Microwave();
                    m = (Microwave)Form1.soket.GetAppliances()[index];
                    comboBox1.Hide();
                    textBox2.Show();
                    label1.Text = "название микроволновки";
                    textBox1.Text = m.Name;
                    label2.Text = "температурный коэффициент";
                    textBox2.Text = Convert.ToString(m.getTemperatureСoefficient());
                    label3.Text = "КПД магнетрона";
                    textBox3.Text = Convert.ToString(m.getMagnetronEfficiency());
                    comboBox1.Text = "1";
                }
            }
            if (b == false)
            {
                radioButton1.Checked = true;
                textBox1.Text = "name";
                textBox2.Text = "0";
                textBox3.Text = "0";
                comboBox1.Text = "0";
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Hide();
            comboBox1.Show();
            label1.Text = "название компьютера";
            label2.Text = "разрядность";
            label3.Text = "частота видеокарты";
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Hide();
            textBox2.Show();
            label1.Text = "название холодильника";
            label2.Text = "температурный коэффициент";
            label3.Text = "сопротивление якоря";
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Hide();
            textBox1.Show();
            label1.Text = "название микроволновки";
            label2.Text = "температурный коэффициент";
            label3.Text = "КПД магнетрона";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Hide();
            comboBox1.Show();
            label1.Text = "название телефона";
            label2.Text = "разрядность";
            label3.Text = "сопротивление преобразователя";
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {}

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
