namespace CompraVenta
{
    partial class VistaMovimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaMovimientos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectorBusqueda = new System.Windows.Forms.ComboBox();
            this.compraVentaDataSet = new CompraVenta.CompraVentaDataSet();
            this.movimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movimientosTableAdapter = new CompraVenta.CompraVentaDataSetTableAdapters.MovimientosTableAdapter();
            this.tableAdapterManager = new CompraVenta.CompraVentaDataSetTableAdapters.TableAdapterManager();
            this.movimientosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.movimientosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.movimientosDataGridView = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoMo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compraVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosBindingNavigator)).BeginInit();
            this.movimientosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.movimientosDataGridView);
            this.panel1.Controls.Add(this.SelectorBusqueda);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 474);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar por:";
            // 
            // SelectorBusqueda
            // 
            this.SelectorBusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SelectorBusqueda.DisplayMember = "0";
            this.SelectorBusqueda.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.SelectorBusqueda.FormattingEnabled = true;
            this.SelectorBusqueda.Items.AddRange(new object[] {
            "Referencia",
            "Fecha",
            "Fecha Mayor A",
            "Fecha Menor A",
            "Valor Mayor A",
            "Valor Menor A",
            "Tipo de movimiento"});
            this.SelectorBusqueda.Location = new System.Drawing.Point(16, 57);
            this.SelectorBusqueda.Name = "SelectorBusqueda";
            this.SelectorBusqueda.Size = new System.Drawing.Size(645, 29);
            this.SelectorBusqueda.TabIndex = 5;
            // 
            // compraVentaDataSet
            // 
            this.compraVentaDataSet.DataSetName = "CompraVentaDataSet";
            this.compraVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movimientosBindingSource
            // 
            this.movimientosBindingSource.DataMember = "Movimientos";
            this.movimientosBindingSource.DataSource = this.compraVentaDataSet;
            // 
            // movimientosTableAdapter
            // 
            this.movimientosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CajaDiariaTableAdapter = null;
            this.tableAdapterManager.CajaMenorTableAdapter = null;
            this.tableAdapterManager.CaracteristicasTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.ComentarioTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.ContratoTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.EncargadoTableAdapter = null;
            this.tableAdapterManager.gastosTableAdapter = null;
            this.tableAdapterManager.ingresosTableAdapter = null;
            this.tableAdapterManager.MovimientosTableAdapter = this.movimientosTableAdapter;
            this.tableAdapterManager.pagoTableAdapter = null;
            this.tableAdapterManager.PeriodoPruebaTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProrrogaTableAdapter = null;
            this.tableAdapterManager.TrazabilidadTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CompraVenta.CompraVentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // movimientosBindingNavigator
            // 
            this.movimientosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.movimientosBindingNavigator.BindingSource = this.movimientosBindingSource;
            this.movimientosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.movimientosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.movimientosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.movimientosBindingNavigatorSaveItem});
            this.movimientosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.movimientosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.movimientosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.movimientosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.movimientosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.movimientosBindingNavigator.Name = "movimientosBindingNavigator";
            this.movimientosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.movimientosBindingNavigator.Size = new System.Drawing.Size(517, 25);
            this.movimientosBindingNavigator.TabIndex = 1;
            this.movimientosBindingNavigator.Text = "bindingNavigator1";
            this.movimientosBindingNavigator.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // movimientosBindingNavigatorSaveItem
            // 
            this.movimientosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.movimientosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("movimientosBindingNavigatorSaveItem.Image")));
            this.movimientosBindingNavigatorSaveItem.Name = "movimientosBindingNavigatorSaveItem";
            this.movimientosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.movimientosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.movimientosBindingNavigatorSaveItem.Click += new System.EventHandler(this.movimientosBindingNavigatorSaveItem_Click);
            // 
            // movimientosDataGridView
            // 
            this.movimientosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movimientosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.NoMo,
            this.valor,
            this.Meses,
            this.tipMov,
            this.descuento});
            this.movimientosDataGridView.Location = new System.Drawing.Point(16, 177);
            this.movimientosDataGridView.Name = "movimientosDataGridView";
            this.movimientosDataGridView.Size = new System.Drawing.Size(645, 220);
            this.movimientosDataGridView.TabIndex = 5;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // NoMo
            // 
            this.NoMo.HeaderText = "Referencia";
            this.NoMo.Name = "NoMo";
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // Meses
            // 
            this.Meses.HeaderText = "Meses";
            this.Meses.Name = "Meses";
            // 
            // tipMov
            // 
            this.tipMov.HeaderText = "Tipo de movimiento";
            this.tipMov.Name = "tipMov";
            // 
            // descuento
            // 
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            // 
            // VistaMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 474);
            this.Controls.Add(this.movimientosBindingNavigator);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VistaMovimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.VistaMovimientos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compraVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosBindingNavigator)).EndInit();
            this.movimientosBindingNavigator.ResumeLayout(false);
            this.movimientosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectorBusqueda;
        private CompraVentaDataSet compraVentaDataSet;
        private System.Windows.Forms.BindingSource movimientosBindingSource;
        private CompraVentaDataSetTableAdapters.MovimientosTableAdapter movimientosTableAdapter;
        private CompraVentaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator movimientosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton movimientosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView movimientosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoMo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meses;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
    }
}