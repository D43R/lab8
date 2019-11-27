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
            bus a = new bus(1, "Жмышенко Валерий Альбертович", 59, true);
            mainList.Add(a);
            InitializeComponent();
            SetDataGrid();
        }
        private void ListOutPut(List<bus> arr)
        {
            foreach(bus b in arr)
            {
               
            }
        }

        public void SetDataGrid()
        {
            DBOutput.Columns.Add("Column1", "Номер маршрута");
            DBOutput.Columns.Add("Column2", "Номер автобуса");
            DBOutput.Columns.Add("Column3", "ФИО водителя");
            DBOutput.Columns.Add("Column4", "В парке/На маршруте");
            DBOutput.Columns[2].Width = 200;
            foreach (bus i in mainList)
            {
                DBOutput.Rows.Add(i.routeNumber, i.busNumber, i.driverName,i.busStateString);
            }
        }

        private void OpenDBbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы bin|*.bin";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                //
            }
        }

        private void SaveDBButton_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //
            }
        }
    }
}
