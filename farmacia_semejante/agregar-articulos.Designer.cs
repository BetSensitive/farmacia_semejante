namespace farmacia_semejante
{
    partial class agregar_articulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregar_articulos));
            this._bd_farmacia_semejanteDataSet = new farmacia_semejante._bd_farmacia_semejanteDataSet();
            this.aRTICULOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aRTICULOSTableAdapter = new farmacia_semejante._bd_farmacia_semejanteDataSetTableAdapters.ARTICULOSTableAdapter();
            this.tableAdapterManager = new farmacia_semejante._bd_farmacia_semejanteDataSetTableAdapters.TableAdapterManager();
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
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nombre_ComercialTextBox = new System.Windows.Forms.TextBox();
            this.presentacionTextBox = new System.Windows.Forms.TextBox();
            this.departamentoComboBox = new System.Windows.Forms.ComboBox();
            this.provedorComboBox = new System.Windows.Forms.ComboBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.bdfarmaciasemejanteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdfarmaciasemejanteDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._bd_farmacia_semejanteDataSet1 = new farmacia_semejante._bd_farmacia_semejanteDataSet1();
            this.dEPARTAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPARTAMENTOTableAdapter = new farmacia_semejante._bd_farmacia_semejanteDataSet1TableAdapters.DEPARTAMENTOTableAdapter();
            this.dEPARTAMENTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._bd_farmacia_semejanteDataSet2 = new farmacia_semejante._bd_farmacia_semejanteDataSet2();
            this.bdfarmaciasemejanteDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROVEDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROVEDORESTableAdapter = new farmacia_semejante._bd_farmacia_semejanteDataSet2TableAdapters.PROVEDORESTableAdapter();
            iDLabel = new System.Windows.Forms.Label();
            nombre_ComercialLabel = new System.Windows.Forms.Label();
            presentacionLabel = new System.Windows.Forms.Label();
            departamentoLabel = new System.Windows.Forms.Label();
            provedorLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._bd_farmacia_semejanteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingNavigator)).BeginInit();
            this.aRTICULOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdfarmaciasemejanteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfarmaciasemejanteDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bd_farmacia_semejanteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bd_farmacia_semejanteDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfarmaciasemejanteDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEDORESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(68, 144);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(23, 16);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // nombre_ComercialLabel
            // 
            nombre_ComercialLabel.AutoSize = true;
            nombre_ComercialLabel.Location = new System.Drawing.Point(68, 172);
            nombre_ComercialLabel.Name = "nombre_ComercialLabel";
            nombre_ComercialLabel.Size = new System.Drawing.Size(123, 16);
            nombre_ComercialLabel.TabIndex = 3;
            nombre_ComercialLabel.Text = "Nombre Comercial:";
            // 
            // presentacionLabel
            // 
            presentacionLabel.AutoSize = true;
            presentacionLabel.Location = new System.Drawing.Point(68, 200);
            presentacionLabel.Name = "presentacionLabel";
            presentacionLabel.Size = new System.Drawing.Size(89, 16);
            presentacionLabel.TabIndex = 5;
            presentacionLabel.Text = "Presentacion:";
            // 
            // departamentoLabel
            // 
            departamentoLabel.AutoSize = true;
            departamentoLabel.Location = new System.Drawing.Point(68, 228);
            departamentoLabel.Name = "departamentoLabel";
            departamentoLabel.Size = new System.Drawing.Size(96, 16);
            departamentoLabel.TabIndex = 7;
            departamentoLabel.Text = "Departamento:";
            // 
            // provedorLabel
            // 
            provedorLabel.AutoSize = true;
            provedorLabel.Location = new System.Drawing.Point(68, 258);
            provedorLabel.Name = "provedorLabel";
            provedorLabel.Size = new System.Drawing.Size(66, 16);
            provedorLabel.TabIndex = 9;
            provedorLabel.Text = "Provedor:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(68, 288);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(64, 16);
            cantidadLabel.TabIndex = 11;
            cantidadLabel.Text = "Cantidad:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(68, 316);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(49, 16);
            precioLabel.TabIndex = 13;
            precioLabel.Text = "Precio:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(68, 344);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(41, 16);
            totalLabel.TabIndex = 15;
            totalLabel.Text = "Total:";
            // 
            // _bd_farmacia_semejanteDataSet
            // 
            this._bd_farmacia_semejanteDataSet.DataSetName = "_bd_farmacia_semejanteDataSet";
            this._bd_farmacia_semejanteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aRTICULOSBindingSource
            // 
            this.aRTICULOSBindingSource.DataMember = "ARTICULOS";
            this.aRTICULOSBindingSource.DataSource = this._bd_farmacia_semejanteDataSet;
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
            this.aRTICULOSBindingNavigator.Size = new System.Drawing.Size(509, 31);
            this.aRTICULOSBindingNavigator.TabIndex = 0;
            this.aRTICULOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // aRTICULOSBindingNavigatorSaveItem
            // 
            this.aRTICULOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aRTICULOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aRTICULOSBindingNavigatorSaveItem.Image")));
            this.aRTICULOSBindingNavigatorSaveItem.Name = "aRTICULOSBindingNavigatorSaveItem";
            this.aRTICULOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.aRTICULOSBindingNavigatorSaveItem.Text = "Guardar datos";
            this.aRTICULOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.aRTICULOSBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(197, 141);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(239, 22);
            this.iDTextBox.TabIndex = 2;
            // 
            // nombre_ComercialTextBox
            // 
            this.nombre_ComercialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Nombre Comercial", true));
            this.nombre_ComercialTextBox.Location = new System.Drawing.Point(197, 169);
            this.nombre_ComercialTextBox.Name = "nombre_ComercialTextBox";
            this.nombre_ComercialTextBox.Size = new System.Drawing.Size(239, 22);
            this.nombre_ComercialTextBox.TabIndex = 4;
            // 
            // presentacionTextBox
            // 
            this.presentacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Presentacion", true));
            this.presentacionTextBox.Location = new System.Drawing.Point(197, 197);
            this.presentacionTextBox.Name = "presentacionTextBox";
            this.presentacionTextBox.Size = new System.Drawing.Size(239, 22);
            this.presentacionTextBox.TabIndex = 6;
            // 
            // departamentoComboBox
            // 
            this.departamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Departamento", true));
            this.departamentoComboBox.DataSource = this.dEPARTAMENTOBindingSource;
            this.departamentoComboBox.DisplayMember = "DEPARTAMENTO";
            this.departamentoComboBox.FormattingEnabled = true;
            this.departamentoComboBox.Location = new System.Drawing.Point(197, 225);
            this.departamentoComboBox.Name = "departamentoComboBox";
            this.departamentoComboBox.Size = new System.Drawing.Size(239, 24);
            this.departamentoComboBox.TabIndex = 8;
            // 
            // provedorComboBox
            // 
            this.provedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Provedor", true));
            this.provedorComboBox.DataSource = this.pROVEDORESBindingSource;
            this.provedorComboBox.DisplayMember = "NOMBRE";
            this.provedorComboBox.FormattingEnabled = true;
            this.provedorComboBox.Location = new System.Drawing.Point(197, 255);
            this.provedorComboBox.Name = "provedorComboBox";
            this.provedorComboBox.Size = new System.Drawing.Size(239, 24);
            this.provedorComboBox.TabIndex = 10;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(197, 285);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(239, 22);
            this.cantidadTextBox.TabIndex = 12;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(197, 313);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(239, 22);
            this.precioTextBox.TabIndex = 14;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(197, 341);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(239, 22);
            this.totalTextBox.TabIndex = 16;
            // 
            // bdfarmaciasemejanteDataSetBindingSource
            // 
            this.bdfarmaciasemejanteDataSetBindingSource.DataSource = this._bd_farmacia_semejanteDataSet;
            this.bdfarmaciasemejanteDataSetBindingSource.Position = 0;
            // 
            // bdfarmaciasemejanteDataSet1BindingSource
            // 
            this.bdfarmaciasemejanteDataSet1BindingSource.DataSource = this._bd_farmacia_semejanteDataSet1;
            this.bdfarmaciasemejanteDataSet1BindingSource.Position = 0;
            // 
            // _bd_farmacia_semejanteDataSet1
            // 
            this._bd_farmacia_semejanteDataSet1.DataSetName = "_bd_farmacia_semejanteDataSet1";
            this._bd_farmacia_semejanteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEPARTAMENTOBindingSource
            // 
            this.dEPARTAMENTOBindingSource.DataMember = "DEPARTAMENTO";
            this.dEPARTAMENTOBindingSource.DataSource = this.bdfarmaciasemejanteDataSet1BindingSource;
            // 
            // dEPARTAMENTOTableAdapter
            // 
            this.dEPARTAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // dEPARTAMENTOBindingSource1
            // 
            this.dEPARTAMENTOBindingSource1.DataMember = "DEPARTAMENTO";
            this.dEPARTAMENTOBindingSource1.DataSource = this.bdfarmaciasemejanteDataSet1BindingSource;
            // 
            // _bd_farmacia_semejanteDataSet2
            // 
            this._bd_farmacia_semejanteDataSet2.DataSetName = "_bd_farmacia_semejanteDataSet2";
            this._bd_farmacia_semejanteDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdfarmaciasemejanteDataSet2BindingSource
            // 
            this.bdfarmaciasemejanteDataSet2BindingSource.DataSource = this._bd_farmacia_semejanteDataSet2;
            this.bdfarmaciasemejanteDataSet2BindingSource.Position = 0;
            // 
            // pROVEDORESBindingSource
            // 
            this.pROVEDORESBindingSource.DataMember = "PROVEDORES";
            this.pROVEDORESBindingSource.DataSource = this.bdfarmaciasemejanteDataSet2BindingSource;
            // 
            // pROVEDORESTableAdapter
            // 
            this.pROVEDORESTableAdapter.ClearBeforeFill = true;
            // 
            // agregar_articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 412);
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
            this.Controls.Add(this.aRTICULOSBindingNavigator);
            this.Name = "agregar_articulos";
            this.Text = "agregar_articulos";
            this.Load += new System.EventHandler(this.agregar_articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this._bd_farmacia_semejanteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingNavigator)).EndInit();
            this.aRTICULOSBindingNavigator.ResumeLayout(false);
            this.aRTICULOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdfarmaciasemejanteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfarmaciasemejanteDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bd_farmacia_semejanteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bd_farmacia_semejanteDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfarmaciasemejanteDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEDORESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _bd_farmacia_semejanteDataSet _bd_farmacia_semejanteDataSet;
        private System.Windows.Forms.BindingSource aRTICULOSBindingSource;
        private _bd_farmacia_semejanteDataSetTableAdapters.ARTICULOSTableAdapter aRTICULOSTableAdapter;
        private _bd_farmacia_semejanteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.BindingSource bdfarmaciasemejanteDataSetBindingSource;
        private System.Windows.Forms.BindingSource bdfarmaciasemejanteDataSet1BindingSource;
        private _bd_farmacia_semejanteDataSet1 _bd_farmacia_semejanteDataSet1;
        private System.Windows.Forms.BindingSource dEPARTAMENTOBindingSource;
        private _bd_farmacia_semejanteDataSet1TableAdapters.DEPARTAMENTOTableAdapter dEPARTAMENTOTableAdapter;
        private System.Windows.Forms.BindingSource bdfarmaciasemejanteDataSet2BindingSource;
        private _bd_farmacia_semejanteDataSet2 _bd_farmacia_semejanteDataSet2;
        private System.Windows.Forms.BindingSource dEPARTAMENTOBindingSource1;
        private System.Windows.Forms.BindingSource pROVEDORESBindingSource;
        private _bd_farmacia_semejanteDataSet2TableAdapters.PROVEDORESTableAdapter pROVEDORESTableAdapter;
    }
}