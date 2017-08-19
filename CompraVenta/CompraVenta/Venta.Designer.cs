namespace CompraVenta
{
    partial class Venta
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
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label ValorVentaLbl;
            System.Windows.Forms.Label CantidadLbl;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            this.DescuentoLbl = new System.Windows.Forms.Label();
            this.ProcentajeLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaEncargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LblTipoBusqueda = new System.Windows.Forms.Label();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.BusquedaFecha = new System.Windows.Forms.DateTimePicker();
            this.TipoBusquedaCombo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.noImportalbl = new System.Windows.Forms.Label();
            this.pesotxt = new System.Windows.Forms.TextBox();
            this.NombreProductoCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ReferenciaTxt = new System.Windows.Forms.TextBox();
            this.DepartamentoCombo = new System.Windows.Forms.ComboBox();
            this.QuitarCbtn = new System.Windows.Forms.Button();
            this.AgregarCbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescuentoValor = new System.Windows.Forms.NumericUpDown();
            this.RegistrarVentaBtn = new System.Windows.Forms.Button();
            this.DescuentoChk = new System.Windows.Forms.CheckBox();
            this.CantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.ValorVentaText = new System.Windows.Forms.TextBox();
            this.FechaVenta = new System.Windows.Forms.DateTimePicker();
            this.VendedorLbl = new System.Windows.Forms.Label();
            this.NoVentaLbl = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            ValorVentaLbl = new System.Windows.Forms.Label();
            CantidadLbl = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DescuentoValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(15, 78);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(115, 21);
            fechaLabel.TabIndex = 45;
            fechaLabel.Text = "Fecha de venta:";
            // 
            // ValorVentaLbl
            // 
            ValorVentaLbl.AutoSize = true;
            ValorVentaLbl.Location = new System.Drawing.Point(15, 158);
            ValorVentaLbl.Name = "ValorVentaLbl";
            ValorVentaLbl.Size = new System.Drawing.Size(89, 21);
            ValorVentaLbl.TabIndex = 47;
            ValorVentaLbl.Text = "Valor Venta:";
            // 
            // CantidadLbl
            // 
            CantidadLbl.AutoSize = true;
            CantidadLbl.Location = new System.Drawing.Point(15, 116);
            CantidadLbl.Name = "CantidadLbl";
            CantidadLbl.Size = new System.Drawing.Size(75, 21);
            CantidadLbl.TabIndex = 49;
            CantidadLbl.Text = "Cantidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 37);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(113, 21);
            label2.TabIndex = 55;
            label2.Text = "Departamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 75);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 21);
            label3.TabIndex = 56;
            label3.Text = "Referencia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 114);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(135, 21);
            label4.TabIndex = 59;
            label4.Text = "Nombre Producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 154);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 21);
            label5.TabIndex = 61;
            label5.Text = "Peso:\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(18, 42);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(81, 21);
            label7.TabIndex = 46;
            label7.Text = "Busqueda:";
            // 
            // DescuentoLbl
            // 
            this.DescuentoLbl.AutoSize = true;
            this.DescuentoLbl.Location = new System.Drawing.Point(15, 198);
            this.DescuentoLbl.Name = "DescuentoLbl";
            this.DescuentoLbl.Size = new System.Drawing.Size(86, 21);
            this.DescuentoLbl.TabIndex = 51;
            this.DescuentoLbl.Text = "Descuento:";
            this.DescuentoLbl.Visible = false;
            // 
            // ProcentajeLbl
            // 
            this.ProcentajeLbl.AutoSize = true;
            this.ProcentajeLbl.Location = new System.Drawing.Point(262, 198);
            this.ProcentajeLbl.Name = "ProcentajeLbl";
            this.ProcentajeLbl.Size = new System.Drawing.Size(23, 21);
            this.ProcentajeLbl.TabIndex = 54;
            this.ProcentajeLbl.Text = "%";
            this.ProcentajeLbl.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.QuitarCbtn);
            this.panel1.Controls.Add(this.AgregarCbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 631);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.TxtBusqueda);
            this.groupBox3.Controls.Add(this.LblTipoBusqueda);
            this.groupBox3.Controls.Add(this.BuscarBtn);
            this.groupBox3.Controls.Add(this.BusquedaFecha);
            this.groupBox3.Controls.Add(this.TipoBusquedaCombo);
            this.groupBox3.Controls.Add(label7);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.groupBox3.Location = new System.Drawing.Point(551, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 598);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ventas";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 52);
            this.button3.TabIndex = 53;
            this.button3.Text = "Mostrar Todo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noVenta,
            this.noProducto,
            this.CedulaC,
            this.valorVenta,
            this.cantidad,
            this.DateVenta,
            this.CedulaEncargado});
            this.dataGridView1.Location = new System.Drawing.Point(22, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 296);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // noVenta
            // 
            this.noVenta.HeaderText = "N° de Venta";
            this.noVenta.Name = "noVenta";
            // 
            // noProducto
            // 
            this.noProducto.HeaderText = "Referencia de producto";
            this.noProducto.Name = "noProducto";
            // 
            // CedulaC
            // 
            this.CedulaC.HeaderText = "Cedula Cliente";
            this.CedulaC.Name = "CedulaC";
            // 
            // valorVenta
            // 
            this.valorVenta.HeaderText = "Valor Venta";
            this.valorVenta.Name = "valorVenta";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // DateVenta
            // 
            this.DateVenta.HeaderText = "Fecha de venta";
            this.DateVenta.Name = "DateVenta";
            // 
            // CedulaEncargado
            // 
            this.CedulaEncargado.HeaderText = "Cedula de Encargado";
            this.CedulaEncargado.Name = "CedulaEncargado";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(22, 115);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(360, 29);
            this.TxtBusqueda.TabIndex = 51;
            this.TxtBusqueda.Visible = false;
            // 
            // LblTipoBusqueda
            // 
            this.LblTipoBusqueda.AutoSize = true;
            this.LblTipoBusqueda.Location = new System.Drawing.Point(18, 81);
            this.LblTipoBusqueda.Name = "LblTipoBusqueda";
            this.LblTipoBusqueda.Size = new System.Drawing.Size(81, 21);
            this.LblTipoBusqueda.TabIndex = 50;
            this.LblTipoBusqueda.Text = "Busqueda:";
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(388, 115);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(78, 30);
            this.BuscarBtn.TabIndex = 49;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // BusquedaFecha
            // 
            this.BusquedaFecha.Location = new System.Drawing.Point(22, 114);
            this.BusquedaFecha.Name = "BusquedaFecha";
            this.BusquedaFecha.Size = new System.Drawing.Size(360, 29);
            this.BusquedaFecha.TabIndex = 48;
            this.BusquedaFecha.Visible = false;
            // 
            // TipoBusquedaCombo
            // 
            this.TipoBusquedaCombo.FormattingEnabled = true;
            this.TipoBusquedaCombo.Items.AddRange(new object[] {
            "Cedula de cliente",
            "Cedula de empleado",
            "Identificador de compra",
            "Fecha menor A",
            "Fecha mayor A",
            "Compra Menor A",
            "Compra Mayor A"});
            this.TipoBusquedaCombo.Location = new System.Drawing.Point(105, 39);
            this.TipoBusquedaCombo.Name = "TipoBusquedaCombo";
            this.TipoBusquedaCombo.Size = new System.Drawing.Size(361, 29);
            this.TipoBusquedaCombo.TabIndex = 47;
            this.TipoBusquedaCombo.SelectedIndexChanged += new System.EventHandler(this.TipoBusquedaCombo_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.noImportalbl);
            this.groupBox2.Controls.Add(this.pesotxt);
            this.groupBox2.Controls.Add(label5);
            this.groupBox2.Controls.Add(this.NombreProductoCombo);
            this.groupBox2.Controls.Add(label4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.ReferenciaTxt);
            this.groupBox2.Controls.Add(this.DepartamentoCombo);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.groupBox2.Location = new System.Drawing.Point(16, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 254);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información producto";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.button2.Location = new System.Drawing.Point(347, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 41);
            this.button2.TabIndex = 65;
            this.button2.Text = "Ver Caracteristica";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(189, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "No";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // noImportalbl
            // 
            this.noImportalbl.AutoSize = true;
            this.noImportalbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noImportalbl.ForeColor = System.Drawing.Color.Red;
            this.noImportalbl.Location = new System.Drawing.Point(7, 194);
            this.noImportalbl.Name = "noImportalbl";
            this.noImportalbl.Size = new System.Drawing.Size(171, 20);
            this.noImportalbl.TabIndex = 63;
            this.noImportalbl.Text = "Documento de Propiedad:";
            // 
            // pesotxt
            // 
            this.pesotxt.Enabled = false;
            this.pesotxt.Location = new System.Drawing.Point(58, 151);
            this.pesotxt.Name = "pesotxt";
            this.pesotxt.Size = new System.Drawing.Size(290, 29);
            this.pesotxt.TabIndex = 62;
            // 
            // NombreProductoCombo
            // 
            this.NombreProductoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NombreProductoCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.NombreProductoCombo.FormattingEnabled = true;
            this.NombreProductoCombo.Location = new System.Drawing.Point(148, 111);
            this.NombreProductoCombo.Name = "NombreProductoCombo";
            this.NombreProductoCombo.Size = new System.Drawing.Size(351, 29);
            this.NombreProductoCombo.TabIndex = 60;
            this.NombreProductoCombo.SelectedIndexChanged += new System.EventHandler(this.NombreProductoCombo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.button1.Location = new System.Drawing.Point(392, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 29);
            this.button1.TabIndex = 55;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReferenciaTxt
            // 
            this.ReferenciaTxt.Location = new System.Drawing.Point(96, 72);
            this.ReferenciaTxt.Name = "ReferenciaTxt";
            this.ReferenciaTxt.Size = new System.Drawing.Size(290, 29);
            this.ReferenciaTxt.TabIndex = 58;
            // 
            // DepartamentoCombo
            // 
            this.DepartamentoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.DepartamentoCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DepartamentoCombo.FormattingEnabled = true;
            this.DepartamentoCombo.Location = new System.Drawing.Point(126, 34);
            this.DepartamentoCombo.Name = "DepartamentoCombo";
            this.DepartamentoCombo.Size = new System.Drawing.Size(373, 29);
            this.DepartamentoCombo.TabIndex = 57;
            this.DepartamentoCombo.SelectedIndexChanged += new System.EventHandler(this.DepartamentoCombo_SelectedIndexChanged);
            // 
            // QuitarCbtn
            // 
            this.QuitarCbtn.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.QuitarCbtn.Location = new System.Drawing.Point(344, 12);
            this.QuitarCbtn.Name = "QuitarCbtn";
            this.QuitarCbtn.Size = new System.Drawing.Size(146, 34);
            this.QuitarCbtn.TabIndex = 43;
            this.QuitarCbtn.Text = "Quitar Cliente";
            this.QuitarCbtn.UseVisualStyleBackColor = true;
            this.QuitarCbtn.Visible = false;
            // 
            // AgregarCbtn
            // 
            this.AgregarCbtn.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.AgregarCbtn.Location = new System.Drawing.Point(181, 12);
            this.AgregarCbtn.Name = "AgregarCbtn";
            this.AgregarCbtn.Size = new System.Drawing.Size(146, 34);
            this.AgregarCbtn.TabIndex = 42;
            this.AgregarCbtn.Text = "Agregar Cliente";
            this.AgregarCbtn.UseVisualStyleBackColor = true;
            this.AgregarCbtn.Click += new System.EventHandler(this.AgregarCbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(138, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(12, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Cliente Agregado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DescuentoValor);
            this.groupBox1.Controls.Add(this.RegistrarVentaBtn);
            this.groupBox1.Controls.Add(this.ProcentajeLbl);
            this.groupBox1.Controls.Add(this.DescuentoChk);
            this.groupBox1.Controls.Add(this.DescuentoLbl);
            this.groupBox1.Controls.Add(this.CantidadProducto);
            this.groupBox1.Controls.Add(CantidadLbl);
            this.groupBox1.Controls.Add(this.ValorVentaText);
            this.groupBox1.Controls.Add(ValorVentaLbl);
            this.groupBox1.Controls.Add(this.FechaVenta);
            this.groupBox1.Controls.Add(fechaLabel);
            this.groupBox1.Controls.Add(this.VendedorLbl);
            this.groupBox1.Controls.Add(this.NoVentaLbl);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.groupBox1.Location = new System.Drawing.Point(16, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de venta";
            // 
            // DescuentoValor
            // 
            this.DescuentoValor.Location = new System.Drawing.Point(136, 196);
            this.DescuentoValor.Name = "DescuentoValor";
            this.DescuentoValor.Size = new System.Drawing.Size(120, 29);
            this.DescuentoValor.TabIndex = 56;
            this.DescuentoValor.Visible = false;
            this.DescuentoValor.ValueChanged += new System.EventHandler(this.DescuentoValor_ValueChanged);
            // 
            // RegistrarVentaBtn
            // 
            this.RegistrarVentaBtn.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.RegistrarVentaBtn.Location = new System.Drawing.Point(204, 243);
            this.RegistrarVentaBtn.Name = "RegistrarVentaBtn";
            this.RegistrarVentaBtn.Size = new System.Drawing.Size(146, 34);
            this.RegistrarVentaBtn.TabIndex = 44;
            this.RegistrarVentaBtn.Text = "Registrar Venta";
            this.RegistrarVentaBtn.UseVisualStyleBackColor = true;
            this.RegistrarVentaBtn.Click += new System.EventHandler(this.RegistrarVentaBtn_Click);
            // 
            // DescuentoChk
            // 
            this.DescuentoChk.AutoSize = true;
            this.DescuentoChk.Location = new System.Drawing.Point(332, 197);
            this.DescuentoChk.Name = "DescuentoChk";
            this.DescuentoChk.Size = new System.Drawing.Size(101, 25);
            this.DescuentoChk.TabIndex = 52;
            this.DescuentoChk.Text = "Descuento";
            this.DescuentoChk.UseVisualStyleBackColor = true;
            this.DescuentoChk.CheckedChanged += new System.EventHandler(this.DescuentoChk_CheckedChanged);
            // 
            // CantidadProducto
            // 
            this.CantidadProducto.Location = new System.Drawing.Point(136, 114);
            this.CantidadProducto.Name = "CantidadProducto";
            this.CantidadProducto.Size = new System.Drawing.Size(363, 29);
            this.CantidadProducto.TabIndex = 50;
            this.CantidadProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ValorVentaText
            // 
            this.ValorVentaText.Location = new System.Drawing.Point(136, 155);
            this.ValorVentaText.Name = "ValorVentaText";
            this.ValorVentaText.Size = new System.Drawing.Size(363, 29);
            this.ValorVentaText.TabIndex = 48;
            this.ValorVentaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ValorVentaText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorVentaText_KeyPress);
            // 
            // FechaVenta
            // 
            this.FechaVenta.Location = new System.Drawing.Point(136, 72);
            this.FechaVenta.Name = "FechaVenta";
            this.FechaVenta.Size = new System.Drawing.Size(363, 29);
            this.FechaVenta.TabIndex = 46;
            // 
            // VendedorLbl
            // 
            this.VendedorLbl.AutoSize = true;
            this.VendedorLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendedorLbl.Location = new System.Drawing.Point(272, 39);
            this.VendedorLbl.Name = "VendedorLbl";
            this.VendedorLbl.Size = new System.Drawing.Size(78, 17);
            this.VendedorLbl.TabIndex = 44;
            this.VendedorLbl.Text = "No. Venta:";
            // 
            // NoVentaLbl
            // 
            this.NoVentaLbl.AutoSize = true;
            this.NoVentaLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoVentaLbl.Location = new System.Drawing.Point(42, 39);
            this.NoVentaLbl.Name = "NoVentaLbl";
            this.NoVentaLbl.Size = new System.Drawing.Size(78, 17);
            this.NoVentaLbl.TabIndex = 43;
            this.NoVentaLbl.Text = "No. Venta:";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 622);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.ModuloVenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DescuentoValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AgregarCbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button QuitarCbtn;
        private System.Windows.Forms.Label VendedorLbl;
        private System.Windows.Forms.Label NoVentaLbl;
        private System.Windows.Forms.DateTimePicker FechaVenta;
        private System.Windows.Forms.TextBox ValorVentaText;
        private System.Windows.Forms.NumericUpDown CantidadProducto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox NombreProductoCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ReferenciaTxt;
        private System.Windows.Forms.ComboBox DepartamentoCombo;
        private System.Windows.Forms.Button RegistrarVentaBtn;
        private System.Windows.Forms.CheckBox DescuentoChk;
        private System.Windows.Forms.TextBox pesotxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label noImportalbl;
        private System.Windows.Forms.NumericUpDown DescuentoValor;
        private System.Windows.Forms.Label DescuentoLbl;
        private System.Windows.Forms.Label ProcentajeLbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox TipoBusquedaCombo;
        private System.Windows.Forms.Label LblTipoBusqueda;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.DateTimePicker BusquedaFecha;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn noProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaEncargado;
        private System.Windows.Forms.Button button3;
    }
}