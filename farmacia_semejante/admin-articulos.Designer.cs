namespace farmacia_semejante
{
    partial class admin_articulos
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
            System.Windows.Forms.Label nombre_ComercialLabel;
            System.Windows.Forms.Label presentacionLabel;
            System.Windows.Forms.Label departamentoLabel;
            System.Windows.Forms.Label provedorLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label totalLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreComercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRTICULOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._bd_farmacia_semejanteDataSet = new farmacia_semejante._bd_farmacia_semejanteDataSet();
            this.aRTICULOSTableAdapter = new farmacia_semejante._bd_farmacia_semejanteDataSetTableAdapters.ARTICULOSTableAdapter();
            this.tableAdapterManager = new farmacia_semejante._bd_farmacia_semejanteDataSetTableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nombre_ComercialTextBox = new System.Windows.Forms.TextBox();
            this.presentacionTextBox = new System.Windows.Forms.TextBox();
            this.departamentoComboBox = new System.Windows.Forms.ComboBox();
            this.dEPARTAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._bd_farmacia_semejanteDataSet1 = new farmacia_semejante._bd_farmacia_semejanteDataSet1();
            this.provedorComboBox = new System.Windows.Forms.ComboBox();
            this.pROVEDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdfarmaciasemejanteDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._bd_farmacia_semejanteDataSet2 = new farmacia_semejante._bd_farmacia_semejanteDataSet2();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.dEPARTAMENTOTableAdapter = new farmacia_semejante._bd_farmacia_semejanteDataSet1TableAdapters.DEPARTAMENTOTableAdapter();
            this.pROVEDORESTableAdapter = new farmacia_semejante._bd_farmacia_semejanteDataSet2TableAdapters.PROVEDORESTableAdapter();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            nombre_ComercialLabel = new System.Windows.Forms.Label();
            presentacionLabel = new System.Windows.Forms.Label();
            departamentoLabel = new System.Windows.Forms.Label();
            provedorLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bd_farmacia_semejanteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bd_farmacia_semejanteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEDORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfarmaciasemejanteDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bd_farmacia_semejanteDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(32, 158);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(23, 16);
            iDLabel.TabIndex = 5;
            iDLabel.Text = "ID:";
            // 
            // nombre_ComercialLabel
            // 
            nombre_ComercialLabel.AutoSize = true;
            nombre_ComercialLabel.Location = new System.Drawing.Point(32, 186);
            nombre_ComercialLabel.Name = "nombre_ComercialLabel";
            nombre_ComercialLabel.Size = new System.Drawing.Size(123, 16);
            nombre_ComercialLabel.TabIndex = 7;
            nombre_ComercialLabel.Text = "Nombre Comercial:";
            // 
            // presentacionLabel
            // 
            presentacionLabel.AutoSize = true;
            presentacionLabel.Location = new System.Drawing.Point(32, 214);
            presentacionLabel.Name = "presentacionLabel";
            presentacionLabel.Size = new System.Drawing.Size(89, 16);
            presentacionLabel.TabIndex = 9;
            presentacionLabel.Text = "Presentacion:";
            // 
            // departamentoLabel
            // 
            departamentoLabel.AutoSize = true;
            departamentoLabel.Location = new System.Drawing.Point(32, 242);
            departamentoLabel.Name = "departamentoLabel";
            departamentoLabel.Size = new System.Drawing.Size(96, 16);
            departamentoLabel.TabIndex = 11;
            departamentoLabel.Text = "Departamento:";
            // 
            // provedorLabel
            // 
            provedorLabel.AutoSize = true;
            provedorLabel.Location = new System.Drawing.Point(32, 272);
            provedorLabel.Name = "provedorLabel";
            provedorLabel.Size = new System.Drawing.Size(66, 16);
            provedorLabel.TabIndex = 13;
            provedorLabel.Text = "Provedor:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(32, 302);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(64, 16);
            cantidadLabel.TabIndex = 15;
            cantidadLabel.Text = "Cantidad:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(32, 330);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(49, 16);
            precioLabel.TabIndex = 17;
            precioLabel.Text = "Precio:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(32, 358);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(41, 16);
            totalLabel.TabIndex = 19;
            totalLabel.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Herramientas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vista Previa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreComercialDataGridViewTextBoxColumn,
            this.presentacionDataGridViewTextBoxColumn,
            this.departamentoDataGridViewTextBoxColumn,
            this.provedorDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aRTICULOSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(354, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(763, 275);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombreComercialDataGridViewTextBoxColumn
            // 
            this.nombreComercialDataGridViewTextBoxColumn.DataPropertyName = "Nombre Comercial";
            this.nombreComercialDataGridViewTextBoxColumn.HeaderText = "Nombre Comercial";
            this.nombreComercialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreComercialDataGridViewTextBoxColumn.Name = "nombreComercialDataGridViewTextBoxColumn";
            this.nombreComercialDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreComercialDataGridViewTextBoxColumn.Width = 125;
            // 
            // presentacionDataGridViewTextBoxColumn
            // 
            this.presentacionDataGridViewTextBoxColumn.DataPropertyName = "Presentacion";
            this.presentacionDataGridViewTextBoxColumn.HeaderText = "Presentacion";
            this.presentacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.presentacionDataGridViewTextBoxColumn.Name = "presentacionDataGridViewTextBoxColumn";
            this.presentacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.presentacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // departamentoDataGridViewTextBoxColumn
            // 
            this.departamentoDataGridViewTextBoxColumn.DataPropertyName = "Departamento";
            this.departamentoDataGridViewTextBoxColumn.HeaderText = "Departamento";
            this.departamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departamentoDataGridViewTextBoxColumn.Name = "departamentoDataGridViewTextBoxColumn";
            this.departamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.departamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // provedorDataGridViewTextBoxColumn
            // 
            this.provedorDataGridViewTextBoxColumn.DataPropertyName = "Provedor";
            this.provedorDataGridViewTextBoxColumn.HeaderText = "Provedor";
            this.provedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.provedorDataGridViewTextBoxColumn.Name = "provedorDataGridViewTextBoxColumn";
            this.provedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.provedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // aRTICULOSBindingSource
            // 
            this.aRTICULOSBindingSource.DataMember = "ARTICULOS";
            this.aRTICULOSBindingSource.DataSource = this._bd_farmacia_semejanteDataSet;
            // 
            // _bd_farmacia_semejanteDataSet
            // 
            this._bd_farmacia_semejanteDataSet.DataSetName = "_bd_farmacia_semejanteDataSet";
            this._bd_farmacia_semejanteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aRTICULOSTableAdapter
            // 
            this.aRTICULOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARTICULOSTableAdapter = this.aRTICULOSTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = farmacia_semejante._bd_farmacia_semejanteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(161, 155);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(121, 22);
            this.iDTextBox.TabIndex = 6;
            // 
            // nombre_ComercialTextBox
            // 
            this.nombre_ComercialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Nombre Comercial", true));
            this.nombre_ComercialTextBox.Location = new System.Drawing.Point(161, 183);
            this.nombre_ComercialTextBox.Name = "nombre_ComercialTextBox";
            this.nombre_ComercialTextBox.Size = new System.Drawing.Size(121, 22);
            this.nombre_ComercialTextBox.TabIndex = 8;
            // 
            // presentacionTextBox
            // 
            this.presentacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Presentacion", true));
            this.presentacionTextBox.Location = new System.Drawing.Point(161, 211);
            this.presentacionTextBox.Name = "presentacionTextBox";
            this.presentacionTextBox.Size = new System.Drawing.Size(121, 22);
            this.presentacionTextBox.TabIndex = 10;
            // 
            // departamentoComboBox
            // 
            this.departamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Departamento", true));
            this.departamentoComboBox.DataSource = this.dEPARTAMENTOBindingSource;
            this.departamentoComboBox.DisplayMember = "DEPARTAMENTO";
            this.departamentoComboBox.FormattingEnabled = true;
            this.departamentoComboBox.Location = new System.Drawing.Point(161, 239);
            this.departamentoComboBox.Name = "departamentoComboBox";
            this.departamentoComboBox.Size = new System.Drawing.Size(121, 24);
            this.departamentoComboBox.TabIndex = 12;
            this.departamentoComboBox.ValueMember = "ID";
            // 
            // dEPARTAMENTOBindingSource
            // 
            this.dEPARTAMENTOBindingSource.DataMember = "DEPARTAMENTO";
            this.dEPARTAMENTOBindingSource.DataSource = this._bd_farmacia_semejanteDataSet1;
            // 
            // _bd_farmacia_semejanteDataSet1
            // 
            this._bd_farmacia_semejanteDataSet1.DataSetName = "_bd_farmacia_semejanteDataSet1";
            this._bd_farmacia_semejanteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provedorComboBox
            // 
            this.provedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Provedor", true));
            this.provedorComboBox.DataSource = this.pROVEDORESBindingSource;
            this.provedorComboBox.DisplayMember = "NOMBRE";
            this.provedorComboBox.FormattingEnabled = true;
            this.provedorComboBox.Location = new System.Drawing.Point(161, 269);
            this.provedorComboBox.Name = "provedorComboBox";
            this.provedorComboBox.Size = new System.Drawing.Size(121, 24);
            this.provedorComboBox.TabIndex = 14;
            this.provedorComboBox.ValueMember = "ID";
            // 
            // pROVEDORESBindingSource
            // 
            this.pROVEDORESBindingSource.DataMember = "PROVEDORES";
            this.pROVEDORESBindingSource.DataSource = this.bdfarmaciasemejanteDataSet2BindingSource;
            // 
            // bdfarmaciasemejanteDataSet2BindingSource
            // 
            this.bdfarmaciasemejanteDataSet2BindingSource.DataSource = this._bd_farmacia_semejanteDataSet2;
            this.bdfarmaciasemejanteDataSet2BindingSource.Position = 0;
            // 
            // _bd_farmacia_semejanteDataSet2
            // 
            this._bd_farmacia_semejanteDataSet2.DataSetName = "_bd_farmacia_semejanteDataSet2";
            this._bd_farmacia_semejanteDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(161, 299);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(121, 22);
            this.cantidadTextBox.TabIndex = 16;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(161, 327);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(121, 22);
            this.precioTextBox.TabIndex = 18;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(161, 355);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(121, 22);
            this.totalTextBox.TabIndex = 20;
            // 
            // dEPARTAMENTOTableAdapter
            // 
            this.dEPARTAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // pROVEDORESTableAdapter
            // 
            this.pROVEDORESTableAdapter.ClearBeforeFill = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(29, 410);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 39);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(147, 410);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 39);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(255, 410);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(91, 39);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1021, 419);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 43);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // admin_articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 501);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nombre_ComercialLabel);
            this.Controls.Add(this.nombre_ComercialTextBox);
            this.Controls.Add(presentacionLabel);
            this.Controls.Add(this.presentacionTextBox);
            this.Controls.Add(departamentoLabel);
            this.Controls.Add(this.departamentoComboBox);
            this.Controls.Add(provedorLabel);
            this.Controls.Add(this.provedorComboBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "admin_articulos";
            this.Text = "admin_articulos";
            this.Load += new System.EventHandler(this.admin_articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bd_farmacia_semejanteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bd_farmacia_semejanteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEDORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfarmaciasemejanteDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bd_farmacia_semejanteDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _bd_farmacia_semejanteDataSet _bd_farmacia_semejanteDataSet;
        private System.Windows.Forms.BindingSource aRTICULOSBindingSource;
        private _bd_farmacia_semejanteDataSetTableAdapters.ARTICULOSTableAdapter aRTICULOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreComercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private _bd_farmacia_semejanteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nombre_ComercialTextBox;
        private System.Windows.Forms.TextBox presentacionTextBox;
        private System.Windows.Forms.ComboBox departamentoComboBox;
        private System.Windows.Forms.ComboBox provedorComboBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private _bd_farmacia_semejanteDataSet1 _bd_farmacia_semejanteDataSet1;
        private System.Windows.Forms.BindingSource dEPARTAMENTOBindingSource;
        private _bd_farmacia_semejanteDataSet1TableAdapters.DEPARTAMENTOTableAdapter dEPARTAMENTOTableAdapter;
        private System.Windows.Forms.BindingSource bdfarmaciasemejanteDataSet2BindingSource;
        private _bd_farmacia_semejanteDataSet2 _bd_farmacia_semejanteDataSet2;
        private System.Windows.Forms.BindingSource pROVEDORESBindingSource;
        private _bd_farmacia_semejanteDataSet2TableAdapters.PROVEDORESTableAdapter pROVEDORESTableAdapter;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
    }
}