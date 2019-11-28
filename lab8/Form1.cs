using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace lab8
{
    public partial class MainForm : Form
    {
        List<bus> mainList = new List<bus>();
        BinaryFormatter bf = new BinaryFormatter();
        public MainForm()
        {
            InitializeComponent();
            SetDataGrid();
        }

        public void SetDataGrid()
        {
            DBOutput.Columns.Add("Column1", "Номер маршрута");
            DBOutput.Columns.Add("Column2", "Номер автобуса");
            DBOutput.Columns.Add("Column3", "ФИО водителя");
            DBOutput.Columns.Add("Column4", "В парке/На маршруте");
            DBOutput.Columns[2].Width = 200;
            DBOutput.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void GetItemsFromList(List<bus> a)
        {
            int countOnRoute = 0;
            a.Sort();
            foreach (bus i in a)
            {
                if (i.busState == false)
                {
                    countOnRoute++;
                }
                DBOutput.Rows.Add(i.routeNumber, i.busNumber, i.driverName, i.busStateString);
            }
            this.countOnRouteLabel.Text = countOnRoute.ToString();
        }

        private void OpenDBbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы bin|*.bin";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Deserialization(OPF.FileName);
                }
                catch
                {
                    MessageBox.Show("Ошибка при чтении файла.");
                }
            }
            DBOutput.Rows.Clear();
            GetItemsFromList(mainList);
        }

        private void Deserialization(string filename)
        {
            FileStream f1 = new FileStream(filename, FileMode.Open);
            mainList = (List<bus>)bf.Deserialize(f1);
            f1.Close();
        }

        private void SaveDBButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "Файлы bin|*.bin";
            
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                SerializeAndSave(SFD.FileName);
            }
        }
        private void SerializeAndSave(string filename)
        {
            FileStream f2 = new FileStream(filename, FileMode.Create);
            bf.Serialize(f2, mainList);
            MessageBox.Show("Файл сохранен");
            f2.Close();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            AddElem a = new AddElem();
            a.ReturnForm = this;
            this.Hide();
            a.ShowDialog();
            if (a.ok)
            {
                bus pazik = new bus(a.rn, a.dn, a.bn, a.bs);
                mainList.Add(pazik);
                DBOutput.Rows.Clear();
                GetItemsFromList(mainList);
            }
        }

        private void EditElem_Click(object sender, EventArgs e)
        {
            try
            {
                int k = DBOutput.CurrentRow.Index;
                AddElem a = new AddElem();
                a.ReturnForm = this;
                InitializeEditWindow(a, mainList[k]);
                this.Hide();
                a.ShowDialog();
                if (a.ok)
                {
                    mainList[k].busNumber = a.bn;
                    mainList[k].routeNumber = a.rn;
                    mainList[k].driverName = a.dn;
                    mainList[k].busState = a.bs;
                    if (mainList[k].busState)
                    {
                        mainList[k].busStateString = "В парке";
                    }
                    else mainList[k].busStateString = "На маршруте";
                    DBOutput.Rows.Clear();
                    GetItemsFromList(mainList);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }

        }
        private void InitializeEditWindow(AddElem a, bus b)
        {
            a.Text = "Редактировать элемент";
            a.routeNumTextBox.Text = b.routeNumber.ToString();
            a.DriverNameTextBox.Text = b.driverName;
            a.BusNumTextBox.Text = b.busNumber.ToString();

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DBOutput.RowCount; i++)
            {
                if (DBOutput[1, i].FormattedValue.ToString().
                    Contains(this.SearchOrDeleteTextBox.Text.Trim()))
                {
                    DBOutput.CurrentCell = DBOutput[0, i];
                    return;
                }
            }
            MessageBox.Show("Элемент не найден");
        }

        private void SearchOrDeleteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8) { }
            else { e.Handled = true; }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SearchOrDeleteTextBox.Text))
            {
                for (int i = 0; i < DBOutput.RowCount; i++)
                {
                    if (DBOutput[1, i].FormattedValue.ToString().
                        Contains(this.SearchOrDeleteTextBox.Text.Trim()))
                    {
                        DBOutput.CurrentCell = DBOutput[0, i];
                        int k = DBOutput.CurrentRow.Index;
                        mainList.Remove(mainList[k]);
                        DBOutput.Rows.Clear();
                        GetItemsFromList(mainList);
                        return;
                    }
                }
                MessageBox.Show("Элемент не найден");
            }
            else { MessageBox.Show("Заполните поле"); }
        }
    }
}
