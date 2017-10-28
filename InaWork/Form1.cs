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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 2);
            Font textFont = new Font("Times New Roman", 14);
            Font titleFont = new Font("Arial", 24, FontStyle.Underline | FontStyle.Bold);

            e.Graphics.DrawString(DateTime.Now.ToLongDateString(), textFont, Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString("דו\"ח נהגים", titleFont, Brushes.Black, new Point(0, 100));

            int w = 100, h = 400, j, i;
            for (i = 0; i < driversDataGridView.Columns.Count; i++, w += 100)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(w, h, driversDataGridView.Columns[0].Width, driversDataGridView.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(w, h, driversDataGridView.Columns[0].Width, driversDataGridView.Rows[0].Height));
                e.Graphics.DrawString(driversDataGridView.Columns[i].HeaderText.ToString(), textFont, Brushes.Black, new Rectangle(w, h, driversDataGridView.Columns[0].Width, driversDataGridView.Rows[0].Height));
            }

            w = 100;
            h += 22;
            for (i = 0; i < driversDataGridView.Rows.Count - 1; i++, h += 22)
            {
                for (j = 0, w = 100; j < driversDataGridView.Columns.Count; j++, w += 100)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(w, h, driversDataGridView.Columns[0].Width, driversDataGridView.Rows[0].Height));
                    e.Graphics.DrawString(driversDataGridView.Rows[i].Cells[j].FormattedValue.ToString(), driversDataGridView.Font, Brushes.Black, new Rectangle(w, h, driversDataGridView.Columns[0].Width, driversDataGridView.Rows[0].Height));
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
            printPreviewDialog1.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                printDocument1.Print();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (printDialog2.ShowDialog().Equals(DialogResult.OK))
            {
                printDocument2.Print();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pageSetupDialog2.ShowDialog();
            printPreviewDialog2.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 2);
            Font textFont = new Font("Times New Roman", 14);
            Font titleFont = new Font("Arial", 24, FontStyle.Underline | FontStyle.Bold);

            e.Graphics.DrawString(DateTime.Now.ToLongDateString(), textFont, Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString("דו\"ח נהג", titleFont, Brushes.Black, new Point(0, 100));

            for (int i = 0; i < driversDataGridView.Columns.Count; i++)
            {
                e.Graphics.DrawString(driversDataGridView.Columns[i].HeaderText, textFont, Brushes.Black, new Point(10, 200 + 50 * i));
                e.Graphics.DrawString(driversDataGridView.CurrentRow.Cells[i].FormattedValue.ToString(), textFont, Brushes.Black, new Point(200, 200 + 50 * i));
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(databaseDataSet.Tables["Drivers"]);
            dv.RowFilter = "Address LIKE '%" + textBox1.Text + "%'";
            driversDataGridView.DataSource = dv;

            button11_Click(null, null);

            driversDataGridView.DataSource = driversBindingSource;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(databaseDataSet.Tables["Drivers"]);
            dv.RowFilter = "BirthDate < '" + new DateTime(int.Parse(textBox2.Text), 1, 1).ToString() + "'";
            driversDataGridView.DataSource = dv;

            button11_Click(null, null);

            driversDataGridView.DataSource = driversBindingSource;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            (driversDataGridView.DataSource as BindingSource).Filter = "FullName LIKE '%" + textBox3.Text + "%'";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            (driversDataGridView.DataSource as BindingSource).Filter = "1 = 1";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            (driversDataGridView.DataSource as BindingSource).Filter = "ID LIKE '%" + textBox3.Text + "%'";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
