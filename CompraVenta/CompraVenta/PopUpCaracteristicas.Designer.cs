namespace CompraVenta
{
    partial class PopUpCaracteristicas
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
            System.Windows.Forms.Label serieLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label referenciaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpCaracteristicas));
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.serieTextBox = new System.Windows.Forms.TextBox();
            this.caracteristicasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraVentaDataSet = new CompraVenta.CompraVentaDataSet();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.referenciaTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.caracteristicasTableAdapter = new CompraVenta.CompraVentaDataSetTableAdapters.CaracteristicasTableAdapter();
            this.tableAdapterManager = new CompraVenta.CompraVentaDataSetTableAdapters.TableAdapterManager();
            this.caracteristicasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.caracteristicasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            serieLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            referenciaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caracteristicasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caracteristicasBindingNavigator)).BeginInit();
            this.caracteristicasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // serieLabel
            // 
            serieLabel.AutoSize = true;
            serieLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            serieLabel.Location = new System.Drawing.Point(12, 41);
            serieLabel.Name = "serieLabel";
            serieLabel.Size = new System.Drawing.Size(124, 21);
            serieLabel.TabIndex = 0;
            serieLabel.Text = "Numero de serie:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            marcaLabel.Location = new System.Drawing.Point(12, 111);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(55, 21);
            marcaLabel.TabIndex = 4;
            marcaLabel.Text = "Marca:";
            // 
            // referenciaLabel
            // 
            referenciaLabel.AutoSize = true;
            referenciaLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            referenciaLabel.Location = new System.Drawing.Point(12, 192);
            referenciaLabel.Name = "referenciaLabel";
            referenciaLabel.Size = new System.Drawing.Size(83, 21);
            referenciaLabel.TabIndex = 6;
            referenciaLabel.Text = "Referencia:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            descripcionLabel.Location = new System.Drawing.Point(12, 261);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(91, 21);
            descripcionLabel.TabIndex = 8;
            descripcionLabel.Text = "Descripcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(509, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(serieLabel);
            this.panel1.Controls.Add(this.serieTextBox);
            this.panel1.Controls.Add(marcaLabel);
            this.panel1.Controls.Add(this.marcaTextBox);
            this.panel1.Controls.Add(referenciaLabel);
            this.panel1.Controls.Add(this.referenciaTextBox);
            this.panel1.Controls.Add(descripcionLabel);
            this.panel1.Controls.Add(this.descripcionTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 441);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.button3.Location = new System.Drawing.Point(197, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 34);
            this.button3.TabIndex = 40;
            this.button3.Text = "Registrar Caracteristicas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // serieTextBox
            // 
            this.serieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caracteristicasBindingSource, "serie", true));
            this.serieTextBox.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.serieTextBox.Location = new System.Drawing.Point(16, 65);
            this.serieTextBox.Name = "serieTextBox";
            this.serieTextBox.Size = new System.Drawing.Size(475, 29);
            this.serieTextBox.TabIndex = 1;
            // 
            // caracteristicasBindingSource
            // 
            this.caracteristicasBindingSource.DataMember = "Caracteristicas";
            this.caracteristicasBindingSource.DataSource = this.compraVentaDataSet;
            // 
            // compraVentaDataSet
            // 
            this.compraVentaDataSet.DataSetName = "CompraVentaDataSet";
            this.compraVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caracteristicasBindingSource, "Marca", true));
            this.marcaTextBox.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.marcaTextBox.Location = new System.Drawing.Point(16, 135);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(475, 29);
            this.marcaTextBox.TabIndex = 5;
            // 
            // referenciaTextBox
            // 
            this.referenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caracteristicasBindingSource, "Referencia", true));
            this.referenciaTextBox.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.referenciaTextBox.Location = new System.Drawing.Point(16, 216);
            this.referenciaTextBox.Name = "referenciaTextBox";
            this.referenciaTextBox.Size = new System.Drawing.Size(475, 29);
            this.referenciaTextBox.TabIndex = 7;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caracteristicasBindingSource, "Descripcion", true));
            this.descripcionTextBox.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.descripcionTextBox.Location = new System.Drawing.Point(16, 295);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(540, 76);
            this.descripcionTextBox.TabIndex = 9;
            // 
            // caracteristicasTableAdapter
            // 
            this.caracteristicasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CajaDiariaTableAdapter = null;
            this.tableAdapterManager.CajaMenorTableAdapter = null;
            this.tableAdapterManager.CaracteristicasTableAdapter = this.caracteristicasTableAdapter;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.ComentarioTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.ContratoTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.EncargadoTableAdapter = null;
            this.tableAdapterManager.gastosTableAdapter = null;
            this.tableAdapterManager.ingresosTableAdapter = null;
            this.tableAdapterManager.MovimientosTableAdapter = null;
            this.tableAdapterManager.pagoTableAdapter = null;
            this.tableAdapterManager.PeriodoPruebaTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProrrogaTableAdapter = null;
            this.tableAdapterManager.TrazabilidadTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CompraVenta.CompraVentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // caracteristicasBindingNavigator
            // 
            this.caracteristicasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.caracteristicasBindingNavigator.BindingSource = this.caracteristicasBindingSource;
            this.caracteristicasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.caracteristicasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.caracteristicasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.caracteristicasBindingNavigatorSaveItem});
            this.caracteristicasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.caracteristicasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.caracteristicasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.caracteristicasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.caracteristicasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.caracteristicasBindingNavigator.Name = "caracteristicasBindingNavigator";
            this.caracteristicasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.caracteristicasBindingNavigator.Size = new System.Drawing.Size(500, 25);
            this.caracteristicasBindingNavigator.TabIndex = 1;
            this.caracteristicasBindingNavigator.Text = "bindingNavigator1";
            this.caracteristicasBindingNavigator.Visible = false;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // caracteristicasBindingNavigatorSaveItem
            // 
            this.caracteristicasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.caracteristicasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("caracteristicasBindingNavigatorSaveItem.Image")));
            this.caracteristicasBindingNavigatorSaveItem.Name = "caracteristicasBindingNavigatorSaveItem";
            this.caracteristicasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.caracteristicasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.caracteristicasBindingNavigatorSaveItem.Click += new System.EventHandler(this.caracteristicasBindingNavigatorSaveItem_Click);
            // 
            // PopUpCaracteristicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 435);
            this.Controls.Add(this.caracteristicasBindingNavigator);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopUpCaracteristicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caracteristicas";
            this.Load += new System.EventHandler(this.PopUpCaracteristicas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caracteristicasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caracteristicasBindingNavigator)).EndInit();
            this.caracteristicasBindingNavigator.ResumeLayout(false);
            this.caracteristicasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CompraVentaDataSet compraVentaDataSet;
        private System.Windows.Forms.BindingSource caracteristicasBindingSource;
        private CompraVentaDataSetTableAdapters.CaracteristicasTableAdapter caracteristicasTableAdapter;
        private CompraVentaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator caracteristicasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton caracteristicasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox serieTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox referenciaTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}