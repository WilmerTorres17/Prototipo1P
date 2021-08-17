//using MySql.Data.MySqlClient;
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
    public partial class frmPago : Form
    {
        /* Codigo para redondear mi panel */
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

        /* Codigo para mover mi panel */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        /* Varibles para cambiar color de mi Boton */
        Color colorHoverPago = Color.FromArgb(80, 115, 119);
        Color colorNormalPago = Color.FromArgb(59, 102, 107);
        public frmPago()
        {
            InitializeComponent();
            /* Codigo para redondear mi panel */
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void frmPago_Load(object sender, EventArgs e)
        {

        }

        private void frmPago_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void btnCobro_MouseClick(object sender, MouseEventArgs e)
        {
            frmCobro obj = new frmCobro();
            obj.Visible = true;

            Visible = false;
        }

        private void lblCobro_MouseClick(object sender, MouseEventArgs e)
        {
            frmCobro obj = new frmCobro();
            obj.Visible = true;

            Visible = false;
        }

        private void picIconoBitaTrans_MouseClick(object sender, MouseEventArgs e)
        {
            frmCobro obj = new frmCobro();
            obj.Visible = true;

            Visible = false;
        }

        private void pnlLLenarCamposPag_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
