using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InaWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void driversBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driversBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.databaseDataSet.Drivers);

            button8.Enabled = false;
            iDMaskedTextBox.Enabled = false;
            birthDateDateTimePicker.MaxDate = DateTime.Now.AddYears(-17);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            driversBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            driversBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            driversBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            driversBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            driversBindingSource.RemoveCurrent();
            driversDataGridView.Refresh();
            driversBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            driversBindingSource.AddNew();
            iDMaskedTextBox.Enabled = true;
            button6.Enabled = false;
            button8.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            driversTableAdapter.Fill(databaseDataSet.Drivers);
            button8.Enabled = false;
            button6.Enabled = true;
            iDMaskedTextBox.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (new Control[] {
                addressTextBox,
                birthDateDateTimePicker,
                iDMaskedTextBox,
                licenseIDMaskedTextBox,
                phoneNumberMaskedTextBox,
                fullNameTextBox
                    }.Any(x => x.Text == ""))
            {
                MessageBox.Show("None of the fields can be left empty.");
                return;
            }

            foreach (DataGridViewRow row in driversDataGridView.Rows)
            {
                if (row != driversDataGridView.CurrentRow && (string)(row.Cells[0].Value ?? "") == iDMaskedTextBox.Text)
                {
                    MessageBox.Show("Duplicate ID numbers are not allowed.");
                    return;
                }
            }

            if (DateTime.Now.AddYears(-17) < birthDateDateTimePicker.Value)
            {
                MessageBox.Show("Driver's age must be at least 17.");
                return;
            }

            driversBindingSource.EndEdit();
            driversTableAdapter.Update(databaseDataSet.Drivers);
            button8.Enabled = false;
            button6.Enabled = true;
            iDMaskedTextBox.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button8_Click(null, null);
        }
    }
}
