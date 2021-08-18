
namespace Prototipo1P
{
    partial class frmCobro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlNormal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCobro = new System.Windows.Forms.Panel();
            this.lblCobro = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.picIconoBitaTrans = new System.Windows.Forms.PictureBox();
            this.btnPago = new System.Windows.Forms.Panel();
            this.lblPago = new System.Windows.Forms.Label();
            this.picIconoPiloto = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.pnlBordeEliminar = new System.Windows.Forms.Panel();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.pnlBordeIngresar = new System.Windows.Forms.Panel();
            this.pnlBordeModificar = new System.Windows.Forms.Panel();
            this.lblModificar = new System.Windows.Forms.Label();
            this.pnlBorde = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvCobro = new System.Windows.Forms.DataGridView();
            this.idUbicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUbicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusUbicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotonBuscatr = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pnlCampoCodCobro = new System.Windows.Forms.Panel();
            this.txtCodCobro = new System.Windows.Forms.TextBox();
            this.lblCodCobro = new System.Windows.Forms.Label();
            this.pnlCampoCantidadC = new System.Windows.Forms.Panel();
            this.txtCantidadC = new System.Windows.Forms.TextBox();
            this.lblCantidadC = new System.Windows.Forms.Label();
            this.pnlCampoTipoPago = new System.Windows.Forms.Panel();
            this.cbxTipoPago = new System.Windows.Forms.ComboBox();
            this.lblITipoPago = new System.Windows.Forms.Label();
            this.pnlBotonEliminar = new System.Windows.Forms.Panel();
            this.pnlBotonModificar = new System.Windows.Forms.Panel();
            this.pnlBotonGuardar = new System.Windows.Forms.Panel();
            this.pnlCampoVentaEnc = new System.Windows.Forms.Panel();
            this.cbxVentaEnc = new System.Windows.Forms.ComboBox();
            this.lblVentaEnc = new System.Windows.Forms.Label();
            this.pnlLLenarCamposCob = new System.Windows.Forms.Panel();
            this.pnlNormal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.btnCobro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoBitaTrans)).BeginInit();
            this.btnPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoPiloto)).BeginInit();
            this.pnlBorde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobro)).BeginInit();
            this.pnlCampoCodCobro.SuspendLayout();
            this.pnlCampoCantidadC.SuspendLayout();
            this.pnlCampoTipoPago.SuspendLayout();
            this.pnlCampoVentaEnc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNormal
            // 
            this.pnlNormal.BackColor = System.Drawing.Color.Gray;
            this.pnlNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlNormal.Controls.Add(this.pictureBox1);
            this.pnlNormal.Controls.Add(this.btnCobro);
            this.pnlNormal.Controls.Add(this.btnPago);
            this.pnlNormal.Location = new System.Drawing.Point(0, 0);
            this.pnlNormal.Name = "pnlNormal";
            this.pnlNormal.Size = new System.Drawing.Size(179, 480);
            this.pnlNormal.TabIndex = 8;
            this.pnlNormal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNormal_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(60, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 59);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnCobro
            // 
            this.btnCobro.BackColor = System.Drawing.Color.Gray;
            this.btnCobro.Controls.Add(this.lblCobro);
            this.btnCobro.Controls.Add(this.label15);
            this.btnCobro.Controls.Add(this.picIconoBitaTrans);
            this.btnCobro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobro.Location = new System.Drawing.Point(-3, 128);
            this.btnCobro.Name = "btnCobro";
            this.btnCobro.Size = new System.Drawing.Size(189, 34);
            this.btnCobro.TabIndex = 22;
            this.btnCobro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCobro_MouseClick);
            this.btnCobro.MouseLeave += new System.EventHandler(this.btnCobro_MouseLeave);
            this.btnCobro.MouseHover += new System.EventHandler(this.btnCobro_MouseHover);
            // 
            // lblCobro
            // 
            this.lblCobro.AutoSize = true;
            this.lblCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCobro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.lblCobro.Location = new System.Drawing.Point(83, 10);
            this.lblCobro.Name = "lblCobro";
            this.lblCobro.Size = new System.Drawing.Size(40, 15);
            this.lblCobro.TabIndex = 2;
            this.lblCobro.Text = "Cobro";
            this.lblCobro.MouseLeave += new System.EventHandler(this.lblCobro_MouseLeave);
            this.lblCobro.MouseHover += new System.EventHandler(this.lblCobro_MouseHover);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.Location = new System.Drawing.Point(15, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 1;
            // 
            // picIconoBitaTrans
            // 
            this.picIconoBitaTrans.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picIconoBitaTrans.BackgroundImage")));
            this.picIconoBitaTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picIconoBitaTrans.Location = new System.Drawing.Point(26, 6);
            this.picIconoBitaTrans.Name = "picIconoBitaTrans";
            this.picIconoBitaTrans.Size = new System.Drawing.Size(20, 21);
            this.picIconoBitaTrans.TabIndex = 1;
            this.picIconoBitaTrans.TabStop = false;
            this.picIconoBitaTrans.MouseLeave += new System.EventHandler(this.picIconoBitaTrans_MouseLeave);
            this.picIconoBitaTrans.MouseHover += new System.EventHandler(this.picIconoBitaTrans_MouseHover);
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.Color.Gray;
            this.btnPago.Controls.Add(this.lblPago);
            this.btnPago.Controls.Add(this.picIconoPiloto);
            this.btnPago.Controls.Add(this.label11);
            this.btnPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPago.Location = new System.Drawing.Point(-3, 161);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(189, 34);
            this.btnPago.TabIndex = 23;
            this.btnPago.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPago_MouseClick);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.lblPago.Location = new System.Drawing.Point(86, 10);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(36, 15);
            this.lblPago.TabIndex = 2;
            this.lblPago.Text = "Pago";
            this.lblPago.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblPago_MouseClick);
            // 
            // picIconoPiloto
            // 
            this.picIconoPiloto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picIconoPiloto.BackgroundImage")));
            this.picIconoPiloto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picIconoPiloto.Location = new System.Drawing.Point(26, 11);
            this.picIconoPiloto.Name = "picIconoPiloto";
            this.picIconoPiloto.Size = new System.Drawing.Size(20, 21);
            this.picIconoPiloto.TabIndex = 1;
            this.picIconoPiloto.TabStop = false;
            this.picIconoPiloto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picIconoPiloto_MouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(17, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 1;
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblIngresar.Location = new System.Drawing.Point(221, 85);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(57, 16);
            this.lblIngresar.TabIndex = 18;
            this.lblIngresar.Text = "Ingresar";
            this.lblIngresar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblIngresar_MouseClick);
            // 
            // pnlBordeEliminar
            // 
            this.pnlBordeEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBordeEliminar.BackgroundImage")));
            this.pnlBordeEliminar.Location = new System.Drawing.Point(729, 110);
            this.pnlBordeEliminar.Name = "pnlBordeEliminar";
            this.pnlBordeEliminar.Size = new System.Drawing.Size(60, 3);
            this.pnlBordeEliminar.TabIndex = 23;
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblEliminar.Location = new System.Drawing.Point(726, 91);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(56, 16);
            this.lblEliminar.TabIndex = 20;
            this.lblEliminar.Text = "Eliminar";
            this.lblEliminar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblEliminar_MouseClick);
            // 
            // pnlBordeIngresar
            // 
            this.pnlBordeIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBordeIngresar.BackgroundImage")));
            this.pnlBordeIngresar.Location = new System.Drawing.Point(225, 104);
            this.pnlBordeIngresar.Name = "pnlBordeIngresar";
            this.pnlBordeIngresar.Size = new System.Drawing.Size(55, 3);
            this.pnlBordeIngresar.TabIndex = 21;
            // 
            // pnlBordeModificar
            // 
            this.pnlBordeModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBordeModificar.BackgroundImage")));
            this.pnlBordeModificar.Location = new System.Drawing.Point(465, 104);
            this.pnlBordeModificar.Name = "pnlBordeModificar";
            this.pnlBordeModificar.Size = new System.Drawing.Size(60, 3);
            this.pnlBordeModificar.TabIndex = 22;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblModificar.Location = new System.Drawing.Point(462, 87);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(63, 16);
            this.lblModificar.TabIndex = 19;
            this.lblModificar.Text = "Modificar";
            this.lblModificar.Click += new System.EventHandler(this.lblModificarCobro_Click);
            this.lblModificar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblModificar_MouseClick);
            // 
            // pnlBorde
            // 
            this.pnlBorde.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBorde.BackgroundImage")));
            this.pnlBorde.Controls.Add(this.panel1);
            this.pnlBorde.Location = new System.Drawing.Point(219, 47);
            this.pnlBorde.Name = "pnlBorde";
            this.pnlBorde.Size = new System.Drawing.Size(90, 3);
            this.pnlBorde.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 3);
            this.panel1.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(209, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(99, 33);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Cobro";
            this.lblTitulo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseClick);
            // 
            // dgvCobro
            // 
            this.dgvCobro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.dgvCobro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCobro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCobro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUbicacionDataGridViewTextBoxColumn,
            this.nombreUbicacionDataGridViewTextBoxColumn,
            this.estatusUbicacionDataGridViewTextBoxColumn});
            this.dgvCobro.Location = new System.Drawing.Point(620, 171);
            this.dgvCobro.Name = "dgvCobro";
            this.dgvCobro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(102)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCobro.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCobro.RowHeadersWidth = 45;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(102)))), ((int)(((byte)(107)))));
            this.dgvCobro.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCobro.Size = new System.Drawing.Size(307, 150);
            this.dgvCobro.TabIndex = 24;
            // 
            // idUbicacionDataGridViewTextBoxColumn
            // 
            this.idUbicacionDataGridViewTextBoxColumn.DataPropertyName = "IdUbicacion";
            this.idUbicacionDataGridViewTextBoxColumn.HeaderText = "Id Ubicacion";
            this.idUbicacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idUbicacionDataGridViewTextBoxColumn.Name = "idUbicacionDataGridViewTextBoxColumn";
            this.idUbicacionDataGridViewTextBoxColumn.Width = 115;
            // 
            // nombreUbicacionDataGridViewTextBoxColumn
            // 
            this.nombreUbicacionDataGridViewTextBoxColumn.DataPropertyName = "NombreUbicacion";
            this.nombreUbicacionDataGridViewTextBoxColumn.HeaderText = "Nombre Ubicacion";
            this.nombreUbicacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreUbicacionDataGridViewTextBoxColumn.Name = "nombreUbicacionDataGridViewTextBoxColumn";
            this.nombreUbicacionDataGridViewTextBoxColumn.Width = 115;
            // 
            // estatusUbicacionDataGridViewTextBoxColumn
            // 
            this.estatusUbicacionDataGridViewTextBoxColumn.DataPropertyName = "EstatusUbicacion";
            this.estatusUbicacionDataGridViewTextBoxColumn.HeaderText = "Estatus Ubicacion";
            this.estatusUbicacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estatusUbicacionDataGridViewTextBoxColumn.Name = "estatusUbicacionDataGridViewTextBoxColumn";
            this.estatusUbicacionDataGridViewTextBoxColumn.Width = 115;
            // 
            // pnlBotonBuscatr
            // 
            this.pnlBotonBuscatr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBotonBuscatr.BackgroundImage")));
            this.pnlBotonBuscatr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBotonBuscatr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBotonBuscatr.Location = new System.Drawing.Point(883, 140);
            this.pnlBotonBuscatr.Name = "pnlBotonBuscatr";
            this.pnlBotonBuscatr.Size = new System.Drawing.Size(22, 22);
            this.pnlBotonBuscatr.TabIndex = 26;
            this.pnlBotonBuscatr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBotonBuscatr_MouseClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Location = new System.Drawing.Point(656, 140);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(221, 13);
            this.txtBuscar.TabIndex = 25;
            this.txtBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscar_MouseClick);
            // 
            // pnlCampoCodCobro
            // 
            this.pnlCampoCodCobro.Controls.Add(this.txtCodCobro);
            this.pnlCampoCodCobro.Controls.Add(this.lblCodCobro);
            this.pnlCampoCodCobro.Location = new System.Drawing.Point(208, 147);
            this.pnlCampoCodCobro.Name = "pnlCampoCodCobro";
            this.pnlCampoCodCobro.Size = new System.Drawing.Size(130, 48);
            this.pnlCampoCodCobro.TabIndex = 27;
            // 
            // txtCodCobro
            // 
            this.txtCodCobro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodCobro.Location = new System.Drawing.Point(3, 27);
            this.txtCodCobro.Name = "txtCodCobro";
            this.txtCodCobro.Size = new System.Drawing.Size(124, 13);
            this.txtCodCobro.TabIndex = 11;
            this.txtCodCobro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodCobro
            // 
            this.lblCodCobro.AutoSize = true;
            this.lblCodCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCobro.Location = new System.Drawing.Point(3, 9);
            this.lblCodCobro.Name = "lblCodCobro";
            this.lblCodCobro.Size = new System.Drawing.Size(83, 13);
            this.lblCodCobro.TabIndex = 10;
            this.lblCodCobro.Text = "Codigo Cobro";
            // 
            // pnlCampoCantidadC
            // 
            this.pnlCampoCantidadC.Controls.Add(this.txtCantidadC);
            this.pnlCampoCantidadC.Controls.Add(this.lblCantidadC);
            this.pnlCampoCantidadC.Location = new System.Drawing.Point(415, 145);
            this.pnlCampoCantidadC.Name = "pnlCampoCantidadC";
            this.pnlCampoCantidadC.Size = new System.Drawing.Size(130, 48);
            this.pnlCampoCantidadC.TabIndex = 28;
            // 
            // txtCantidadC
            // 
            this.txtCantidadC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadC.Location = new System.Drawing.Point(3, 27);
            this.txtCantidadC.Name = "txtCantidadC";
            this.txtCantidadC.Size = new System.Drawing.Size(124, 13);
            this.txtCantidadC.TabIndex = 11;
            this.txtCantidadC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCantidadC
            // 
            this.lblCantidadC.AutoSize = true;
            this.lblCantidadC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadC.Location = new System.Drawing.Point(3, 9);
            this.lblCantidadC.Name = "lblCantidadC";
            this.lblCantidadC.Size = new System.Drawing.Size(94, 13);
            this.lblCantidadC.TabIndex = 10;
            this.lblCantidadC.Text = "Cantidad Cobro";
            // 
            // pnlCampoTipoPago
            // 
            this.pnlCampoTipoPago.Controls.Add(this.cbxTipoPago);
            this.pnlCampoTipoPago.Controls.Add(this.lblITipoPago);
            this.pnlCampoTipoPago.Location = new System.Drawing.Point(208, 214);
            this.pnlCampoTipoPago.Name = "pnlCampoTipoPago";
            this.pnlCampoTipoPago.Size = new System.Drawing.Size(152, 48);
            this.pnlCampoTipoPago.TabIndex = 49;
            // 
            // cbxTipoPago
            // 
            this.cbxTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoPago.FormattingEnabled = true;
            this.cbxTipoPago.Location = new System.Drawing.Point(3, 24);
            this.cbxTipoPago.Name = "cbxTipoPago";
            this.cbxTipoPago.Size = new System.Drawing.Size(136, 21);
            this.cbxTipoPago.TabIndex = 46;
            // 
            // lblITipoPago
            // 
            this.lblITipoPago.AutoSize = true;
            this.lblITipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblITipoPago.Location = new System.Drawing.Point(7, 7);
            this.lblITipoPago.Name = "lblITipoPago";
            this.lblITipoPago.Size = new System.Drawing.Size(65, 13);
            this.lblITipoPago.TabIndex = 47;
            this.lblITipoPago.Text = "Tipo Pago";
            // 
            // pnlBotonEliminar
            // 
            this.pnlBotonEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBotonEliminar.BackgroundImage")));
            this.pnlBotonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBotonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBotonEliminar.Location = new System.Drawing.Point(487, 297);
            this.pnlBotonEliminar.Name = "pnlBotonEliminar";
            this.pnlBotonEliminar.Size = new System.Drawing.Size(49, 57);
            this.pnlBotonEliminar.TabIndex = 51;
            this.pnlBotonEliminar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBotonEliminar_MouseClick);
            // 
            // pnlBotonModificar
            // 
            this.pnlBotonModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBotonModificar.BackgroundImage")));
            this.pnlBotonModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBotonModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBotonModificar.Location = new System.Drawing.Point(403, 297);
            this.pnlBotonModificar.Name = "pnlBotonModificar";
            this.pnlBotonModificar.Size = new System.Drawing.Size(54, 57);
            this.pnlBotonModificar.TabIndex = 52;
            this.pnlBotonModificar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBotonModificar_MouseClick);
            // 
            // pnlBotonGuardar
            // 
            this.pnlBotonGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBotonGuardar.BackgroundImage")));
            this.pnlBotonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBotonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBotonGuardar.Location = new System.Drawing.Point(324, 297);
            this.pnlBotonGuardar.Name = "pnlBotonGuardar";
            this.pnlBotonGuardar.Size = new System.Drawing.Size(53, 57);
            this.pnlBotonGuardar.TabIndex = 53;
            this.pnlBotonGuardar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBotonGuardar_MouseClick);
            // 
            // pnlCampoVentaEnc
            // 
            this.pnlCampoVentaEnc.Controls.Add(this.cbxVentaEnc);
            this.pnlCampoVentaEnc.Controls.Add(this.lblVentaEnc);
            this.pnlCampoVentaEnc.Location = new System.Drawing.Point(415, 216);
            this.pnlCampoVentaEnc.Name = "pnlCampoVentaEnc";
            this.pnlCampoVentaEnc.Size = new System.Drawing.Size(152, 48);
            this.pnlCampoVentaEnc.TabIndex = 54;
            // 
            // cbxVentaEnc
            // 
            this.cbxVentaEnc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVentaEnc.FormattingEnabled = true;
            this.cbxVentaEnc.Location = new System.Drawing.Point(3, 24);
            this.cbxVentaEnc.Name = "cbxVentaEnc";
            this.cbxVentaEnc.Size = new System.Drawing.Size(136, 21);
            this.cbxVentaEnc.TabIndex = 46;
            // 
            // lblVentaEnc
            // 
            this.lblVentaEnc.AutoSize = true;
            this.lblVentaEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVentaEnc.Location = new System.Drawing.Point(7, 7);
            this.lblVentaEnc.Name = "lblVentaEnc";
            this.lblVentaEnc.Size = new System.Drawing.Size(114, 13);
            this.lblVentaEnc.TabIndex = 47;
            this.lblVentaEnc.Text = "Venta Encabezado";
            // 
            // pnlLLenarCamposCob
            // 
            this.pnlLLenarCamposCob.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLLenarCamposCob.BackgroundImage")));
            this.pnlLLenarCamposCob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLLenarCamposCob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLLenarCamposCob.Location = new System.Drawing.Point(736, 347);
            this.pnlLLenarCamposCob.Name = "pnlLLenarCamposCob";
            this.pnlLLenarCamposCob.Size = new System.Drawing.Size(119, 22);
            this.pnlLLenarCamposCob.TabIndex = 77;
            this.pnlLLenarCamposCob.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlLLenarCamposCob_MouseClick);
            // 
            // frmCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1000, 480);
            this.Controls.Add(this.pnlLLenarCamposCob);
            this.Controls.Add(this.pnlCampoVentaEnc);
            this.Controls.Add(this.pnlBotonGuardar);
            this.Controls.Add(this.pnlBotonModificar);
            this.Controls.Add(this.pnlBotonEliminar);
            this.Controls.Add(this.pnlCampoTipoPago);
            this.Controls.Add(this.pnlCampoCantidadC);
            this.Controls.Add(this.pnlCampoCodCobro);
            this.Controls.Add(this.dgvCobro);
            this.Controls.Add(this.pnlBotonBuscatr);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.pnlBordeEliminar);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.pnlBordeIngresar);
            this.Controls.Add(this.pnlBordeModificar);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.pnlBorde);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlNormal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCobro_MouseDown);
            this.pnlNormal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.btnCobro.ResumeLayout(false);
            this.btnCobro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoBitaTrans)).EndInit();
            this.btnPago.ResumeLayout(false);
            this.btnPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoPiloto)).EndInit();
            this.pnlBorde.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobro)).EndInit();
            this.pnlCampoCodCobro.ResumeLayout(false);
            this.pnlCampoCodCobro.PerformLayout();
            this.pnlCampoCantidadC.ResumeLayout(false);
            this.pnlCampoCantidadC.PerformLayout();
            this.pnlCampoTipoPago.ResumeLayout(false);
            this.pnlCampoTipoPago.PerformLayout();
            this.pnlCampoVentaEnc.ResumeLayout(false);
            this.pnlCampoVentaEnc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNormal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel btnCobro;
        private System.Windows.Forms.Label lblCobro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox picIconoBitaTrans;
        private System.Windows.Forms.Panel btnPago;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.PictureBox picIconoPiloto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Panel pnlBordeEliminar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Panel pnlBordeIngresar;
        private System.Windows.Forms.Panel pnlBordeModificar;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Panel pnlBorde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUbicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUbicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusUbicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlBotonBuscatr;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel pnlCampoCodCobro;
        private System.Windows.Forms.TextBox txtCodCobro;
        private System.Windows.Forms.Label lblCodCobro;
        private System.Windows.Forms.Panel pnlCampoCantidadC;
        private System.Windows.Forms.TextBox txtCantidadC;
        private System.Windows.Forms.Label lblCantidadC;
        private System.Windows.Forms.Panel pnlCampoTipoPago;
        private System.Windows.Forms.ComboBox cbxTipoPago;
        private System.Windows.Forms.Label lblITipoPago;
        private System.Windows.Forms.Panel pnlBotonEliminar;
        private System.Windows.Forms.Panel pnlBotonModificar;
        private System.Windows.Forms.Panel pnlBotonGuardar;
        private System.Windows.Forms.Panel pnlCampoVentaEnc;
        private System.Windows.Forms.ComboBox cbxVentaEnc;
        private System.Windows.Forms.Label lblVentaEnc;
        private System.Windows.Forms.Panel pnlLLenarCamposCob;
    }
}

