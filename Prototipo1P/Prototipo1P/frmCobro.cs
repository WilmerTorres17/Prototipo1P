using MySql.Data.MySqlClient;
using Prototipo1P.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1P
{
    public partial class frmCobro : Form
    {
        /* Codigo para redondear el panel */
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        /* Codigo para mover el panel */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        /* Varibles para cambiar color de mi Boton */
        Color colorHoverCobro = Color.FromArgb(80, 115, 119);
        Color colorNormalCobro = Color.FromArgb(59, 102, 107);

        public frmCobro()
        {
            InitializeComponent();
            /* Codigo para redondear mi panel */
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            lblTitulo.Visible = true;
            pnlBorde.Visible = false;
            lblIngresar.Visible = false;
            pnlBordeIngresar.Visible = false;
            lblModificar.Visible = false;
            pnlBordeModificar.Visible = false;
            lblEliminar.Visible = false;
            pnlBordeEliminar.Visible = false;

            pnlCampoCodCobro.Visible = false;
            pnlCampoTipoPago.Visible = false;
            pnlCampoCantidadC.Visible = false;
            pnlCampoVentaEnc.Visible = false;

            pnlBotonGuardar.Visible = false;
            pnlBotonModificar.Visible = false;
            pnlBotonEliminar.Visible = false;

            txtBuscar.Visible = false;
            pnlBotonBuscatr.Visible = false;
            dgvCobro.Visible = false;
            pnlLLenarCamposCob.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void frmCobro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlNormal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblModificarCobro_Click(object sender, EventArgs e)
        {

        }

        private void btnCobro_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnPago_MouseClick(object sender, MouseEventArgs e)
        {
            frmPago obj = new frmPago();
            obj.Visible = true;

            Visible = false;
        }

        private void lblPago_MouseClick(object sender, MouseEventArgs e)
        {
            frmPago obj = new frmPago();
            obj.Visible = true;

            Visible = false;
        }

        private void picIconoPiloto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPago obj = new frmPago();
            obj.Visible = true;

            Visible = false;
        }

        private void btnTipoPago_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lblTipoPago_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void picIconoInventario_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnCobro_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void lblCobro_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void picIconoBitaTrans_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnCobro_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void lblCobro_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void picIconoBitaTrans_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void pnlBotonGuardar_MouseClick(object sender, MouseEventArgs e)
        {
            funCargarTabla(null);
            //funVaciarCampos();
            /* Inicio de ejecucion de funcion insertar un empleado */
            //String ordena = "0";
            Cobro cobro = funObtenerTxt();
            cobro.funInsertar();
            /* Final de ejecucion de funcion insertar un empleado */
            funCargarTabla(null);
            funVaciarCampos();
        }

        private void pnlBotonModificar_MouseClick(object sender, MouseEventArgs e)
        {
            String codCobro = txtCodCobro.Text;
            Cobro cobro = funObtenerTxt();

            cobro.funModificar(codCobro);
            funCargarTabla(null);
            cobro.funBuscarSetearTxt(txtCodCobro, cbxTipoPago, txtCantidadC, cbxVentaEnc, codCobro);
        }

        private void pnlBotonEliminar_MouseClick(object sender, MouseEventArgs e)
        {
            String codCobro = txtCodCobro.Text;
            Cobro cobro = funObtenerTxt();

            cobro.funEliminar(codCobro);
            funCargarTabla(null);
            cobro.funBuscarSetearTxt(txtCodCobro, cbxTipoPago, txtCantidadC, cbxVentaEnc, codCobro);
        }

        private void txtBuscar_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pnlBotonBuscatr_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarCobro = txtBuscar.Text;
            funCargarTabla(buscarCobro);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            /* Final Vaciando los campos */
        }
        public void funVaciarCampos()
        {
            txtCodCobro.Text = "";
            cbxTipoPago.SelectedItem = "";
            txtCantidadC.Text = "";
            cbxVentaEnc.SelectedItem = "";
        }
        public Cobro funObtenerTxt()
        {
            /*Inicio obteniedo variables a usar con mi ABC  */
            String pCodCobro = txtCodCobro.Text;
            String pTipoPago = cbxTipoPago.SelectedValue.ToString();
            String pCantCobro = txtCantidadC.Text;
            String pVentEnc = cbxVentaEnc.SelectedValue.ToString();
            /*Final obteniedo variables a usar con mi ABC */

            /* Inicio creamos un objeto de tipo empleado para poder utilizar el metodo de insertar Ruta */
            Cobro cobro = new Cobro(pCodCobro, pTipoPago, pCantCobro, pVentEnc);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar Ruta */

            return cobro;
        }
        private void funCargarTabla(string dato)
        {
            //List<Bodega> lista = new List<Bodega>();
            Cobro cobro = new Cobro();

            dgvCobro.DataSource = cobro.consulta(dato);
        }

        private void pnlLLenarCamposCob_MouseClick(object sender, MouseEventArgs e)
        {
            Cobro cobro = new Cobro();
          
            txtCodCobro.Text = dgvCobro.CurrentRow.Cells[0].Value.ToString();

            String idTipoP = dgvCobro.CurrentRow.Cells[1].Value.ToString();
            cobro.obtenerNombreTipoPago(idTipoP);
            cbxTipoPago.SelectedValue = idTipoP;

            txtCantidadC.Text = dgvCobro.CurrentRow.Cells[2].Value.ToString();

            String idVentaEnc = dgvCobro.CurrentRow.Cells[1].Value.ToString();
            cobro.obtenerNombreVentaEnca(idVentaEnc);
            cbxVentaEnc.SelectedValue = idVentaEnc;

        }

        private void pnlLlenarCamposCobDB_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lblTitulo_MouseClick(object sender, MouseEventArgs e)
        {

            lblTitulo.Visible = true;
            pnlBorde.Visible = true;
            lblIngresar.Visible = true;
            pnlBordeIngresar.Visible = false;
            lblModificar.Visible = true;
            pnlBordeModificar.Visible = false;
            lblEliminar.Visible = true;
            pnlBordeEliminar.Visible = false;

            pnlCampoCodCobro.Visible = false;
            pnlCampoTipoPago.Visible = false;
            pnlCampoCantidadC.Visible = false;
            pnlCampoVentaEnc.Visible = false;

            pnlBotonGuardar.Visible = false;
            pnlBotonModificar.Visible = false;
            pnlBotonEliminar.Visible = false;

            txtBuscar.Visible = false;
            pnlBotonBuscatr.Visible = false;
            dgvCobro.Visible = false;
            pnlLLenarCamposCob.Visible = false;
        }

        private void lblIngresar_MouseClick(object sender, MouseEventArgs e)
        {

            lblIngresar.Visible = true;
            pnlBordeIngresar.Visible = true;
            lblModificar.Visible = true;
            pnlBordeModificar.Visible = false;
            lblEliminar.Visible = true;
            pnlBordeEliminar.Visible = false;

            pnlCampoCodCobro.Visible = true;
            pnlCampoTipoPago.Visible = true;
            pnlCampoCantidadC.Visible = true;
            pnlCampoVentaEnc.Visible = true;

            pnlBotonGuardar.Visible = true;
            pnlBotonModificar.Visible = false;
            pnlBotonEliminar.Visible = false;

            txtBuscar.Visible = true;
            pnlBotonBuscatr.Visible = true;
            dgvCobro.Visible = true;
            pnlLLenarCamposCob.Visible = true;
        }

        private void lblModificar_MouseClick(object sender, MouseEventArgs e)
        {
            lblIngresar.Visible = true;
            pnlBordeIngresar.Visible = false;
            lblModificar.Visible = true;
            pnlBordeModificar.Visible = true;
            lblEliminar.Visible = true;
            pnlBordeEliminar.Visible = false;

            pnlCampoCodCobro.Visible = true;
            pnlCampoTipoPago.Visible = true;
            pnlCampoCantidadC.Visible = true;
            pnlCampoVentaEnc.Visible = true;

            pnlBotonGuardar.Visible = false;
            pnlBotonModificar.Visible = true;
            pnlBotonEliminar.Visible = false;

            txtBuscar.Visible = true;
            pnlBotonBuscatr.Visible = true;
            dgvCobro.Visible = true;
            pnlLLenarCamposCob.Visible = true;
        }

        private void lblEliminar_MouseClick(object sender, MouseEventArgs e)
        {
            lblIngresar.Visible = true;
            pnlBordeIngresar.Visible = false;
            lblModificar.Visible = true;
            pnlBordeModificar.Visible = false;
            lblEliminar.Visible = true;
            pnlBordeEliminar.Visible = true;

            pnlCampoCodCobro.Visible = true;
            pnlCampoTipoPago.Visible = true;
            pnlCampoCantidadC.Visible = true;
            pnlCampoVentaEnc.Visible = true;

            pnlBotonGuardar.Visible = false;
            pnlBotonModificar.Visible = false;
            pnlBotonEliminar.Visible = true;

            txtBuscar.Visible = true;
            pnlBotonBuscatr.Visible = true;
            dgvCobro.Visible = true;
            pnlLLenarCamposCob.Visible = true;
        }
    }
}
