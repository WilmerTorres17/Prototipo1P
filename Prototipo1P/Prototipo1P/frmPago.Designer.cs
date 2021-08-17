
namespace Prototipo1P
{
    partial class frmPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPago));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBotonEliminar = new System.Windows.Forms.Panel();
            this.pnlCampoTipoPago = new System.Windows.Forms.Panel();
            this.cbxTipoPago = new System.Windows.Forms.ComboBox();
            this.lblITipoPago = new System.Windows.Forms.Label();
            this.pnlCampoCantidadP = new System.Windows.Forms.Panel();
            this.txtCantidadP = new System.Windows.Forms.TextBox();
            this.lblCantidadP = new System.Windows.Forms.Label();
            this.pnlCampoCodPago = new System.Windows.Forms.Panel();
            this.txtCodCobro = new System.Windows.Forms.TextBox();
            this.lblCodPago = new System.Windows.Forms.Label();
            this.dgvCobro = new System.Windows.Forms.DataGridView();
            this.idUbicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUbicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusUbicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotonBuscatr = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.pnlBordeEliminar = new System.Windows.Forms.Panel();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.pnlBordeIngresar = new System.Windows.Forms.Panel();
            this.pnlBordeModificar = new System.Windows.Forms.Panel();
            this.lblModificar = new System.Windows.Forms.Label();
            this.pnlBorde = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCampoCompraEnc = new System.Windows.Forms.Panel();
            this.cbxCompraEnc = new System.Windows.Forms.ComboBox();
            this.lblCompraEnc = new System.Windows.Forms.Label();
            this.pnlLLenarCamposPag = new System.Windows.Forms.Panel();
            this.pnlNormal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.btnCobro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoBitaTrans)).BeginInit();
            this.btnPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoPiloto)).BeginInit();
            this.pnlCampoTipoPago.SuspendLayout();
            this.pnlCampoCantidadP.SuspendLayout();
            this.pnlCampoCodPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobro)).BeginInit();
            this.pnlBorde.SuspendLayout();
            this.pnlCampoCompraEnc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNormal
            // 
            this.pnlNormal.BackColor = System.Drawing.Color.Gray;
            this.pnlNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlNormal.Controls.Add(this.pictureBox1);
            this.pnlNormal.Controls.Add(this.btnCobro);
            this.pnlNormal.Controls.Add(this.btnPago);
            this.pnlNormal.Location = new System.Drawing.Point(0, -1);
            this.pnlNormal.Name = "pnlNormal";
            this.pnlNormal.Size = new System.Drawing.Size(179, 480);
            this.pnlNormal.TabIndex = 9;
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
            this.lblCobro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblCobro_MouseClick);
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
            this.picIconoBitaTrans.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picIconoBitaTrans_MouseClick);
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
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(323, 281);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(53, 57);
            this.panel4.TabIndex = 71;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(401, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(54, 57);
            this.panel2.TabIndex = 70;
            // 
            // pnlBotonEliminar
            // 
            this.pnlBotonEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBotonEliminar.BackgroundImage")));
            this.pnlBotonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBotonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBotonEliminar.Location = new System.Drawing.Point(492, 281);
            this.pnlBotonEliminar.Name = "pnlBotonEliminar";
            this.pnlBotonEliminar.Size = new System.Drawing.Size(49, 57);
            this.pnlBotonEliminar.TabIndex = 69;
            // 
            // pnlCampoTipoPago
            // 
            this.pnlCampoTipoPago.Controls.Add(this.cbxTipoPago);
            this.pnlCampoTipoPago.Controls.Add(this.lblITipoPago);
            this.pnlCampoTipoPago.Location = new System.Drawing.Point(207, 209);
            this.pnlCampoTipoPago.Name = "pnlCampoTipoPago";
            this.pnlCampoTipoPago.Size = new System.Drawing.Size(152, 48);
            this.pnlCampoTipoPago.TabIndex = 67;
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
            // pnlCampoCantidadP
            // 
            this.pnlCampoCantidadP.Controls.Add(this.txtCantidadP);
            this.pnlCampoCantidadP.Controls.Add(this.lblCantidadP);
            this.pnlCampoCantidadP.Location = new System.Drawing.Point(414, 140);
            this.pnlCampoCantidadP.Name = "pnlCampoCantidadP";
            this.pnlCampoCantidadP.Size = new System.Drawing.Size(130, 48);
            this.pnlCampoCantidadP.TabIndex = 66;
            // 
            // txtCantidadP
            // 
            this.txtCantidadP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadP.Location = new System.Drawing.Point(3, 27);
            this.txtCantidadP.Name = "txtCantidadP";
            this.txtCantidadP.Size = new System.Drawing.Size(124, 13);
            this.txtCantidadP.TabIndex = 11;
            this.txtCantidadP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCantidadP
            // 
            this.lblCantidadP.AutoSize = true;
            this.lblCantidadP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadP.Location = new System.Drawing.Point(3, 9);
            this.lblCantidadP.Name = "lblCantidadP";
            this.lblCantidadP.Size = new System.Drawing.Size(90, 13);
            this.lblCantidadP.TabIndex = 10;
            this.lblCantidadP.Text = "Cantidad Pago";
            // 
            // pnlCampoCodPago
            // 
            this.pnlCampoCodPago.Controls.Add(this.txtCodCobro);
            this.pnlCampoCodPago.Controls.Add(this.lblCodPago);
            this.pnlCampoCodPago.Location = new System.Drawing.Point(207, 142);
            this.pnlCampoCodPago.Name = "pnlCampoCodPago";
            this.pnlCampoCodPago.Size = new System.Drawing.Size(130, 48);
            this.pnlCampoCodPago.TabIndex = 65;
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
            // lblCodPago
            // 
            this.lblCodPago.AutoSize = true;
            this.lblCodPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPago.Location = new System.Drawing.Point(3, 9);
            this.lblCodPago.Name = "lblCodPago";
            this.lblCodPago.Size = new System.Drawing.Size(79, 13);
            this.lblCodPago.TabIndex = 10;
            this.lblCodPago.Text = "Codigo Pago";
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
            this.dgvCobro.Location = new System.Drawing.Point(619, 166);
            this.dgvCobro.Name = "dgvCobro";
            this.dgvCobro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(102)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCobro.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCobro.RowHeadersWidth = 45;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(102)))), ((int)(((byte)(107)))));
            this.dgvCobro.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCobro.Size = new System.Drawing.Size(307, 150);
            this.dgvCobro.TabIndex = 62;
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
            this.pnlBotonBuscatr.Location = new System.Drawing.Point(882, 135);
            this.pnlBotonBuscatr.Name = "pnlBotonBuscatr";
            this.pnlBotonBuscatr.Size = new System.Drawing.Size(22, 22);
            this.pnlBotonBuscatr.TabIndex = 64;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Location = new System.Drawing.Point(655, 135);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(221, 13);
            this.txtBuscar.TabIndex = 63;
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblIngresar.Location = new System.Drawing.Point(220, 80);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(57, 16);
            this.lblIngresar.TabIndex = 56;
            this.lblIngresar.Text = "Ingresar";
            // 
            // pnlBordeEliminar
            // 
            this.pnlBordeEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBordeEliminar.BackgroundImage")));
            this.pnlBordeEliminar.Location = new System.Drawing.Point(728, 105);
            this.pnlBordeEliminar.Name = "pnlBordeEliminar";
            this.pnlBordeEliminar.Size = new System.Drawing.Size(60, 3);
            this.pnlBordeEliminar.TabIndex = 61;
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblEliminar.Location = new System.Drawing.Point(725, 86);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(56, 16);
            this.lblEliminar.TabIndex = 58;
            this.lblEliminar.Text = "Eliminar";
            // 
            // pnlBordeIngresar
            // 
            this.pnlBordeIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBordeIngresar.BackgroundImage")));
            this.pnlBordeIngresar.Location = new System.Drawing.Point(224, 99);
            this.pnlBordeIngresar.Name = "pnlBordeIngresar";
            this.pnlBordeIngresar.Size = new System.Drawing.Size(55, 3);
            this.pnlBordeIngresar.TabIndex = 59;
            // 
            // pnlBordeModificar
            // 
            this.pnlBordeModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBordeModificar.BackgroundImage")));
            this.pnlBordeModificar.Location = new System.Drawing.Point(464, 99);
            this.pnlBordeModificar.Name = "pnlBordeModificar";
            this.pnlBordeModificar.Size = new System.Drawing.Size(60, 3);
            this.pnlBordeModificar.TabIndex = 60;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblModificar.Location = new System.Drawing.Point(461, 82);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(63, 16);
            this.lblModificar.TabIndex = 57;
            this.lblModificar.Text = "Modificar";
            // 
            // pnlBorde
            // 
            this.pnlBorde.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBorde.BackgroundImage")));
            this.pnlBorde.Controls.Add(this.panel1);
            this.pnlBorde.Location = new System.Drawing.Point(218, 42);
            this.pnlBorde.Name = "pnlBorde";
            this.pnlBorde.Size = new System.Drawing.Size(90, 3);
            this.pnlBorde.TabIndex = 55;
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
            this.lblTitulo.Location = new System.Drawing.Point(208, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(86, 33);
            this.lblTitulo.TabIndex = 54;
            this.lblTitulo.Text = "Pago";
            // 
            // pnlCampoCompraEnc
            // 
            this.pnlCampoCompraEnc.Controls.Add(this.cbxCompraEnc);
            this.pnlCampoCompraEnc.Controls.Add(this.lblCompraEnc);
            this.pnlCampoCompraEnc.Location = new System.Drawing.Point(414, 206);
            this.pnlCampoCompraEnc.Name = "pnlCampoCompraEnc";
            this.pnlCampoCompraEnc.Size = new System.Drawing.Size(152, 48);
            this.pnlCampoCompraEnc.TabIndex = 72;
            // 
            // cbxCompraEnc
            // 
            this.cbxCompraEnc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompraEnc.FormattingEnabled = true;
            this.cbxCompraEnc.Location = new System.Drawing.Point(3, 24);
            this.cbxCompraEnc.Name = "cbxCompraEnc";
            this.cbxCompraEnc.Size = new System.Drawing.Size(136, 21);
            this.cbxCompraEnc.TabIndex = 46;
            // 
            // lblCompraEnc
            // 
            this.lblCompraEnc.AutoSize = true;
            this.lblCompraEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCompraEnc.Location = new System.Drawing.Point(7, 7);
            this.lblCompraEnc.Name = "lblCompraEnc";
            this.lblCompraEnc.Size = new System.Drawing.Size(123, 13);
            this.lblCompraEnc.TabIndex = 47;
            this.lblCompraEnc.Text = "Compra Encabezado";
            // 
            // pnlLLenarCamposPag
            // 
            this.pnlLLenarCamposPag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLLenarCamposPag.BackgroundImage")));
            this.pnlLLenarCamposPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLLenarCamposPag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLLenarCamposPag.Location = new System.Drawing.Point(727, 335);
            this.pnlLLenarCamposPag.Name = "pnlLLenarCamposPag";
            this.pnlLLenarCamposPag.Size = new System.Drawing.Size(119, 22);
            this.pnlLLenarCamposPag.TabIndex = 77;
            this.pnlLLenarCamposPag.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlLLenarCamposPag_MouseClick);
            // 
            // frmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1000, 480);
            this.Controls.Add(this.pnlLLenarCamposPag);
            this.Controls.Add(this.pnlCampoCompraEnc);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBotonEliminar);
            this.Controls.Add(this.pnlCampoTipoPago);
            this.Controls.Add(this.pnlCampoCantidadP);
            this.Controls.Add(this.pnlCampoCodPago);
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
            this.Name = "frmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPago";
            this.Load += new System.EventHandler(this.frmPago_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPago_MouseDown);
            this.pnlNormal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.btnCobro.ResumeLayout(false);
            this.btnCobro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoBitaTrans)).EndInit();
            this.btnPago.ResumeLayout(false);
            this.btnPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoPiloto)).EndInit();
            this.pnlCampoTipoPago.ResumeLayout(false);
            this.pnlCampoTipoPago.PerformLayout();
            this.pnlCampoCantidadP.ResumeLayout(false);
            this.pnlCampoCantidadP.PerformLayout();
            this.pnlCampoCodPago.ResumeLayout(false);
            this.pnlCampoCodPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobro)).EndInit();
            this.pnlBorde.ResumeLayout(false);
            this.pnlCampoCompraEnc.ResumeLayout(false);
            this.pnlCampoCompraEnc.PerformLayout();
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlBotonEliminar;
        private System.Windows.Forms.Panel pnlCampoTipoPago;
        private System.Windows.Forms.ComboBox cbxTipoPago;
        private System.Windows.Forms.Label lblITipoPago;
        private System.Windows.Forms.Panel pnlCampoCantidadP;
        private System.Windows.Forms.TextBox txtCantidadP;
        private System.Windows.Forms.Label lblCantidadP;
        private System.Windows.Forms.Panel pnlCampoCodPago;
        private System.Windows.Forms.TextBox txtCodCobro;
        private System.Windows.Forms.Label lblCodPago;
        private System.Windows.Forms.DataGridView dgvCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUbicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUbicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusUbicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlBotonBuscatr;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Panel pnlBordeEliminar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Panel pnlBordeIngresar;
        private System.Windows.Forms.Panel pnlBordeModificar;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Panel pnlBorde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCampoCompraEnc;
        private System.Windows.Forms.ComboBox cbxCompraEnc;
        private System.Windows.Forms.Label lblCompraEnc;
        private System.Windows.Forms.Panel pnlLLenarCamposPag;
    }
}