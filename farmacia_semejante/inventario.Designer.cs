namespace farmacia_semejante
{
    partial class inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventario));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.aRTICULOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._bd_farmacia_semejanteDataSet3 = new farmacia_semejante._bd_farmacia_semejanteDataSet3();
            this.nombre_ComercialTextBox = new System.Windows.Forms.TextBox();
            this.presentacionTextBox = new System.Windows.Forms.TextBox();
            this.departamentoComboBox = new System.Windows.Forms.ComboBox();
            this.provedorComboBox = new System.Windows.Forms.ComboBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.aRTICULOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.aRTICULOSTableAdapter = new farmacia_semejante._bd_farmacia_semejanteDataSet3TableAdapters.ARTICULOSTableAdapter();
            this.tableAdapterManager = new farmacia_semejante._bd_farmacia_semejanteDataSet3TableAdapters.TableAdapterManager();
            this.aRTICULOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aRTICULOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            iDLabel = new System.Windows.Forms.Label();
            nombre_ComercialLabel = new System.Windows.Forms.Label();
            presentacionLabel = new System.Windows.Forms.Label();
            departamentoLabel = new System.Windows.Forms.Label();
            provedorLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bd_farmacia_semejanteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingNavigator)).BeginInit();
            this.aRTICULOSBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(576, 120);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(23, 16);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // nombre_ComercialLabel
            // 
            nombre_ComercialLabel.AutoSize = true;
            nombre_ComercialLabel.Location = new System.Drawing.Point(576, 148);
            nombre_ComercialLabel.Name = "nombre_ComercialLabel";
            nombre_ComercialLabel.Size = new System.Drawing.Size(123, 16);
            nombre_ComercialLabel.TabIndex = 3;
            nombre_ComercialLabel.Text = "Nombre Comercial:";
            // 
            // presentacionLabel
            // 
            presentacionLabel.AutoSize = true;
            presentacionLabel.Location = new System.Drawing.Point(576, 176);
            presentacionLabel.Name = "presentacionLabel";
            presentacionLabel.Size = new System.Drawing.Size(89, 16);
            presentacionLabel.TabIndex = 5;
            presentacionLabel.Text = "Presentacion:";
            // 
            // departamentoLabel
            // 
            departamentoLabel.AutoSize = true;
            departamentoLabel.Location = new System.Drawing.Point(576, 204);
            departamentoLabel.Name = "departamentoLabel";
            departamentoLabel.Size = new System.Drawing.Size(96, 16);
            departamentoLabel.TabIndex = 7;
            departamentoLabel.Text = "Departamento:";
            // 
            // provedorLabel
            // 
            provedorLabel.AutoSize = true;
            provedorLabel.Location = new System.Drawing.Point(576, 234);
            provedorLabel.Name = "provedorLabel";
            provedorLabel.Size = new System.Drawing.Size(66, 16);
            provedorLabel.TabIndex = 9;
            provedorLabel.Text = "Provedor:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(576, 264);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(64, 16);
            cantidadLabel.TabIndex = 11;
            cantidadLabel.Text = "Cantidad:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(576, 292);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(49, 16);
            precioLabel.TabIndex = 13;
            precioLabel.Text = "Precio:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(576, 320);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(41, 16);
            totalLabel.TabIndex = 15;
            totalLabel.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventario";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 94);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 486);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(iDLabel);
            this.tabPage1.Controls.Add(this.iDTextBox);
            this.tabPage1.Controls.Add(nombre_ComercialLabel);
            this.tabPage1.Controls.Add(this.nombre_ComercialTextBox);
            this.tabPage1.Controls.Add(presentacionLabel);
            this.tabPage1.Controls.Add(this.presentacionTextBox);
            this.tabPage1.Controls.Add(departamentoLabel);
            this.tabPage1.Controls.Add(this.departamentoComboBox);
            this.tabPage1.Controls.Add(provedorLabel);
            this.tabPage1.Controls.Add(this.provedorComboBox);
            this.tabPage1.Controls.Add(cantidadLabel);
            this.tabPage1.Controls.Add(this.cantidadTextBox);
            this.tabPage1.Controls.Add(precioLabel);
            this.tabPage1.Controls.Add(this.precioTextBox);
            this.tabPage1.Controls.Add(totalLabel);
            this.tabPage1.Controls.Add(this.totalTextBox);
            this.tabPage1.Controls.Add(this.aRTICULOSDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1045, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Articulos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(705, 117);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(322, 22);
            this.iDTextBox.TabIndex = 2;
            // 
            // aRTICULOSBindingSource
            // 
            this.aRTICULOSBindingSource.DataMember = "ARTICULOS";
            this.aRTICULOSBindingSource.DataSource = this._bd_farmacia_semejanteDataSet3;
            // 
            // _bd_farmacia_semejanteDataSet3
            // 
            this._bd_farmacia_semejanteDataSet3.DataSetName = "_bd_farmacia_semejanteDataSet3";
            this._bd_farmacia_semejanteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombre_ComercialTextBox
            // 
            this.nombre_ComercialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Nombre Comercial", true));
            this.nombre_ComercialTextBox.Location = new System.Drawing.Point(705, 145);
            this.nombre_ComercialTextBox.Name = "nombre_ComercialTextBox";
            this.nombre_ComercialTextBox.Size = new System.Drawing.Size(322, 22);
            this.nombre_ComercialTextBox.TabIndex = 4;
            // 
            // presentacionTextBox
            // 
            this.presentacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Presentacion", true));
            this.presentacionTextBox.Location = new System.Drawing.Point(705, 173);
            this.presentacionTextBox.Name = "presentacionTextBox";
            this.presentacionTextBox.Size = new System.Drawing.Size(322, 22);
            this.presentacionTextBox.TabIndex = 6;
            // 
            // departamentoComboBox
            // 
            this.departamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Departamento", true));
            this.departamentoComboBox.FormattingEnabled = true;
            this.departamentoComboBox.Location = new System.Drawing.Point(705, 201);
            this.departamentoComboBox.Name = "departamentoComboBox";
            this.departamentoComboBox.Size = new System.Drawing.Size(322, 24);
            this.departamentoComboBox.TabIndex = 8;
            // 
            // provedorComboBox
            // 
            this.provedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Provedor", true));
            this.provedorComboBox.FormattingEnabled = true;
            this.provedorComboBox.Location = new System.Drawing.Point(705, 231);
            this.provedorComboBox.Name = "provedorComboBox";
            this.provedorComboBox.Size = new System.Drawing.Size(322, 24);
            this.provedorComboBox.TabIndex = 10;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(705, 261);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(322, 22);
            this.cantidadTextBox.TabIndex = 12;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(705, 289);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(322, 22);
            this.precioTextBox.TabIndex = 14;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(705, 317);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(322, 22);
            this.totalTextBox.TabIndex = 16;
            // 
            // aRTICULOSDataGridView
            // 
            this.aRTICULOSDataGridView.AutoGenerateColumns = false;
            this.aRTICULOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aRTICULOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.aRTICULOSDataGridView.DataSource = this.aRTICULOSBindingSource;
            this.aRTICULOSDataGridView.Location = new System.Drawing.Point(6, 17);
            this.aRTICULOSDataGridView.Name = "aRTICULOSDataGridView";
            this.aRTICULOSDataGridView.RowHeadersWidth = 51;
            this.aRTICULOSDataGridView.RowTemplate.Height = 24;
            this.aRTICULOSDataGridView.Size = new System.Drawing.Size(539, 419);
            this.aRTICULOSDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre Comercial";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Comercial";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Presentacion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Presentacion";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Departamento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Provedor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Provedor";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn7.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn8.HeaderText = "Total";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1045, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Provedores ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1045, 457);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Departamentos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // aRTICULOSTableAdapter
            // 
            this.aRTICULOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARTICULOSTableAdapter = this.aRTICULOSTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DEPARTAMENTOTableAdapter = null;
            this.tableAdapterManager.PROVEDORESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = farmacia_semejante._bd_farmacia_semejanteDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aRTICULOSBindingNavigator
            // 
            this.aRTICULOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aRTICULOSBindingNavigator.BindingSource = this.aRTICULOSBindingSource;
            this.aRTICULOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aRTICULOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aRTICULOSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.aRTICULOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aRTICULOSBindingNavigatorSaveItem});
            this.aRTICULOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aRTICULOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aRTICULOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aRTICULOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aRTICULOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aRTICULOSBindingNavigator.Name = "aRTICULOSBindingNavigator";
            this.aRTICULOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aRTICULOSBindingNavigator.Size = new System.Drawing.Size(1088, 27);
            this.aRTICULOSBindingNavigator.TabIndex = 2;
            this.aRTICULOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // aRTICULOSBindingNavigatorSaveItem
            // 
            this.aRTICULOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aRTICULOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aRTICULOSBindingNavigatorSaveItem.Image")));
            this.aRTICULOSBindingNavigatorSaveItem.Name = "aRTICULOSBindingNavigatorSaveItem";
            this.aRTICULOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.aRTICULOSBindingNavigatorSaveItem.Text = "Guardar datos";
            this.aRTICULOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.aRTICULOSBindingNavigatorSaveItem_Click);
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 592);
            this.Controls.Add(this.aRTICULOSBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "inventario";
            this.Text = "inventario";
            this.Load += new System.EventHandler(this.inventario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bd_farmacia_semejanteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingNavigator)).EndInit();
            this.aRTICULOSBindingNavigator.ResumeLayout(false);
            this.aRTICULOSBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private _bd_farmacia_semejanteDataSet3 _bd_farmacia_semejanteDataSet3;
        private System.Windows.Forms.BindingSource aRTICULOSBindingSource;
        private _bd_farmacia_semejanteDataSet3TableAdapters.ARTICULOSTableAdapter aRTICULOSTableAdapter;
        private _bd_farmacia_semejanteDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aRTICULOSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aRTICULOSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nombre_ComercialTextBox;
        private System.Windows.Forms.TextBox presentacionTextBox;
        private System.Windows.Forms.ComboBox departamentoComboBox;
        private System.Windows.Forms.ComboBox provedorComboBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.DataGridView aRTICULOSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}