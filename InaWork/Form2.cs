using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace InaWork
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void carsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.databaseDataSet.Drivers);
            // TODO: This line of code loads data into the 'databaseDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.databaseDataSet.Cars);

            button8.Enabled = false;
            iDMaskedTextBox.Enabled = false;
            productionYearNumericUpDown.Maximum = DateTime.Now.Year;

            for (int i = 0; i < driversDataGridView.Rows.Count - 1; i++)
            {
                comboBox1.Items.Add(new IdNamePair(
                    driversDataGridView.Rows[i].Cells[0].Value.ToString(),
                    driversDataGridView.Rows[i].Cells[1].Value.ToString()
                    ));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carsBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carsBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            carsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            carsBindingSource.RemoveCurrent();
            carsDataGridView.Refresh();
            carsBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            carsBindingSource.AddNew();
            iDMaskedTextBox.Enabled = true;
            button6.Enabled = false;
            button8.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            carsTableAdapter.Fill(databaseDataSet.Cars);
            button8.Enabled = false;
            button6.Enabled = true;
            iDMaskedTextBox.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (new Control[] {
                iDMaskedTextBox,
                colorTextBox,
                modelTextBox,
                productionYearNumericUpDown,
                driverIDMaskedTextBox
                    }.Any(x => x.Text == ""))
            {
                MessageBox.Show("None of the fields can be left empty.");
                return;
            }

            foreach (DataGridViewRow row in carsDataGridView.Rows)
            {
                if (row != carsDataGridView.CurrentRow && (string)(row.Cells[0].Value ?? "") == iDMaskedTextBox.Text)
                {
                    MessageBox.Show("Duplicate ID numbers are not allowed.");
                    return;
                }
            }

            if (DateTime.Now < new DateTime((int)productionYearNumericUpDown.Value, 1, 1))
            {
                MessageBox.Show("Future dates are not allowed.");
                return;
            }

            carsBindingSource.EndEdit();
            carsTableAdapter.Update(databaseDataSet.Cars);
            button8.Enabled = false;
            button6.Enabled = true;
            iDMaskedTextBox.Enabled = false;
        }

        class IdNamePair
        {
            public string Id, Name;
            public IdNamePair(string a, string b)
            {
                Id = a;
                Name = b;
            }
            public override string ToString()
            {
                return Name;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            (carsDataGridView.DataSource as BindingSource).Filter = "DriverID = '" + ((IdNamePair)comboBox1.SelectedItem).Id + "'";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            (carsDataGridView.DataSource as BindingSource).Filter = "1 = 1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("CarsNum");
            chart1.Series["CarsNum"].Points.Clear();

            //string sql = "SELECT Drivers.ID, COUNT(Cars.ID) as NumCars FROM Cars INNER JOIN Drivers ON Cars.DriverID = Drivers.ID GROUP BY Drivers.ID";

            Dictionary<string, int> vals = new Dictionary<string, int>();
            for (int i = 0; i < carsDataGridView.Rows.Count - 1; i++)
            {
                if (vals.ContainsKey(carsDataGridView.Rows[i].Cells[4].Value.ToString()))
                {
                    vals[carsDataGridView.Rows[i].Cells[4].Value.ToString()]++;
                }
                else
                {
                    vals[carsDataGridView.Rows[i].Cells[4].Value.ToString()] = 1;
                }
            }
            foreach (KeyValuePair<string, int> a in vals)
            {
                chart1.Series["CarsNum"].Points.AddXY(a.Key, a.Value);
            }

            chart1.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("CarsNum");
            chart1.Series["CarsNum"].Points.Clear();

            //string sql = "SELECT Drivers.ID, COUNT(Cars.ID) as NumCars FROM Cars INNER JOIN Drivers ON Cars.DriverID = Drivers.ID GROUP BY Drivers.ID";

            Dictionary<string, int> vals = new Dictionary<string, int>();
            for (int i = 0; i < carsDataGridView.Rows.Count - 1; i++)
            {
                if (vals.ContainsKey(carsDataGridView.Rows[i].Cells[3].Value.ToString()))
                {
                    vals[carsDataGridView.Rows[i].Cells[3].Value.ToString()]++;
                }
                else
                {
                    vals[carsDataGridView.Rows[i].Cells[3].Value.ToString()] = 1;
                }
            }
            foreach (KeyValuePair<string, int> a in vals)
            {
                chart1.Series["CarsNum"].Points.AddXY(a.Key, a.Value);
            }

            chart1.Visible = true;
        }
    }
}
