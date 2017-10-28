namespace InaWork
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label productionYearLabel;
            System.Windows.Forms.Label driverIDLabel;
            this.databaseDataSet = new InaWork.DatabaseDataSet();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new InaWork.DatabaseDataSetTableAdapters.CarsTableAdapter();
            this.tableAdapterManager = new InaWork.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.productionYearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.driverIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            iDLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            productionYearLabel = new System.Windows.Forms.Label();
            driverIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionYearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.databaseDataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarsTableAdapter = this.carsTableAdapter;
            this.tableAdapterManager.DriversTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InaWork.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.AutoGenerateColumns = false;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.carsDataGridView.DataSource = this.carsBindingSource;
            this.carsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.Size = new System.Drawing.Size(582, 220);
            this.carsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn2.HeaderText = "Model";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn3.HeaderText = "Color";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProductionYear";
            this.dataGridViewTextBoxColumn4.HeaderText = "ProductionYear";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DriverID";
            this.dataGridViewTextBoxColumn5.HeaderText = "DriverID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(16, 244);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDMaskedTextBox
            // 
            this.iDMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "ID", true));
            this.iDMaskedTextBox.Location = new System.Drawing.Point(108, 241);
            this.iDMaskedTextBox.Name = "iDMaskedTextBox";
            this.iDMaskedTextBox.Size = new System.Drawing.Size(120, 20);
            this.iDMaskedTextBox.TabIndex = 2;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(16, 270);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 3;
            modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(108, 267);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(120, 20);
            this.modelTextBox.TabIndex = 4;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(16, 296);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(34, 13);
            colorLabel.TabIndex = 5;
            colorLabel.Text = "Color:";
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(108, 293);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(120, 20);
            this.colorTextBox.TabIndex = 6;
            // 
            // productionYearLabel
            // 
            productionYearLabel.AutoSize = true;
            productionYearLabel.Location = new System.Drawing.Point(16, 319);
            productionYearLabel.Name = "productionYearLabel";
            productionYearLabel.Size = new System.Drawing.Size(86, 13);
            productionYearLabel.TabIndex = 7;
            productionYearLabel.Text = "Production Year:";
            // 
            // productionYearNumericUpDown
            // 
            this.productionYearNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carsBindingSource, "ProductionYear", true));
            this.productionYearNumericUpDown.Location = new System.Drawing.Point(108, 319);
            this.productionYearNumericUpDown.Name = "productionYearNumericUpDown";
            this.productionYearNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.productionYearNumericUpDown.TabIndex = 8;
            // 
            // driverIDLabel
            // 
            driverIDLabel.AutoSize = true;
            driverIDLabel.Location = new System.Drawing.Point(16, 348);
            driverIDLabel.Name = "driverIDLabel";
            driverIDLabel.Size = new System.Drawing.Size(52, 13);
            driverIDLabel.TabIndex = 9;
            driverIDLabel.Text = "Driver ID:";
            // 
            // driverIDMaskedTextBox
            // 
            this.driverIDMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "DriverID", true));
            this.driverIDMaskedTextBox.Location = new System.Drawing.Point(108, 345);
            this.driverIDMaskedTextBox.Name = "driverIDMaskedTextBox";
            this.driverIDMaskedTextBox.Size = new System.Drawing.Size(120, 20);
            this.driverIDMaskedTextBox.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 385);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDMaskedTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(productionYearLabel);
            this.Controls.Add(this.productionYearNumericUpDown);
            this.Controls.Add(driverIDLabel);
            this.Controls.Add(this.driverIDMaskedTextBox);
            this.Controls.Add(this.carsDataGridView);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionYearNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private DatabaseDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.MaskedTextBox iDMaskedTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.NumericUpDown productionYearNumericUpDown;
        private System.Windows.Forms.MaskedTextBox driverIDMaskedTextBox;
    }
}