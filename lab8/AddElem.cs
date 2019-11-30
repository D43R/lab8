using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class AddElem : Form
    {
        public AddElem()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        public Form ReturnForm;
        public bool ok = false, bs;
        public int bn, rn;
        public string dn;


        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void RouteNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8) { }
            else { e.Handled = true; }
        }

        private void BusNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8) { }
            else { e.Handled = true; }
        }

        private void AddRouteForm_Load(object sender, EventArgs e)
        {

        }

        private void AddElem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ReturnForm.Show();
        }

        private void CancelBut_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] names = { "Джимми Гокинс", "Бен Ганн", "Слепой Пью", "Джон Сильвер", "Черный Пес", "Сквайр Трелони", "Доктор Ливси" };
            dn = names[rand.Next(0, names.Length)];
            bn = rand.Next(1, 1000);
            rn = rand.Next(1, 1000);
            bs = Convert.ToBoolean(rand.Next(-1, 1));
            ok = true;
            this.Close();
        }

        private void DriverNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] nonLegitSigns = { ',', '?', ':', ';', '$', '#', '!', '@', '%', '"', '>', '|', '/' };
            if (Char.IsDigit(e.KeyChar) || Array.IndexOf(nonLegitSigns, e.KeyChar) >= 0)
            {
                e.Handled = true;
            }
        }

        private void OKBut_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.BusNumTextBox.Text) || String.IsNullOrWhiteSpace(this.routeNumTextBox.Text)
                || String.IsNullOrWhiteSpace(this.DriverNameTextBox.Text) || (!this.InPark.Checked && !this.OnRoute.Checked))
            {
                MessageBox.Show("Заполните поля");
            }
            else
            {
                ok = Int32.TryParse(this.BusNumTextBox.Text, out bn);
                if (ok)
                {
                    ok = Int32.TryParse(this.routeNumTextBox.Text, out rn);
                }
                dn = this.DriverNameTextBox.Text;
                if (InPark.Checked)
                {
                    bs = true;
                }
                else
                {
                    bs = false;
                }
                if (!ok)
                {
                    MessageBox.Show("Ошибка.Повторите ввод");
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
