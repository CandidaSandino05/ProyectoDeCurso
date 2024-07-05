using ProyectoFinal.MAS_FORMS;
using System.Runtime.InteropServices;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {

        frmRegistrar registrar = new frmRegistrar();
        frmNomina frmNomina = new frmNomina();
        frmCalculoIR frmCalculoIR = new frmCalculoIR();
        public Form1()
        {
            InitializeComponent();
            personalizacion();

        }
        private void personalizacion()
        {
            panelnom.Visible = false;


        }
        private void ocultarmenu()
        {

            if (panelnom.Visible == true)
                panelnom.Visible = false;

        }
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }



        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (registrar.Visible == false)
            {
                registrar.MdiParent = this;
                registrar.Dock = DockStyle.Fill;
                registrar.Show();
            }
            else
            {
                registrar.Hide();
            }


        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            showSubMenu(panelnom);
        }

        private void btnNominasal_Click(object sender, EventArgs e)
        {
            if (frmNomina.Visible == false)
            {
                frmNomina = new frmNomina();
                frmNomina.MdiParent = this;
                frmNomina.Dock = DockStyle.Fill;
                frmNomina.Show();

            }
            else
            {
                frmNomina.Hide();
                frmNomina = new frmNomina();


            }




            ocultarmenu();
        }

        private void BtnCalculodelir_Click(object sender, EventArgs e)
        {

            if (frmCalculoIR.Visible == false)
            {
                frmCalculoIR = new frmCalculoIR();
                frmCalculoIR.MdiParent = this;
                frmCalculoIR.Dock = DockStyle.Fill;
                frmCalculoIR.Show();

            }
            else
            {
                frmCalculoIR.Hide();
                frmCalculoIR = new frmCalculoIR();


            }

            ocultarmenu();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            registrar.MdiParent = this;
            registrar.Dock = DockStyle.Fill;

            frmNomina.MdiParent = this;
            frmNomina.Dock = DockStyle.Fill;

            frmCalculoIR.MdiParent = this;
            frmCalculoIR.Dock = DockStyle.Fill;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmNomina = new frmNomina();
            frmNomina.MdiParent = this;
            frmNomina.Dock = DockStyle.Fill;
            frmNomina.Visible = false;
            frmNomina.Hide();

            frmCalculoIR = new frmCalculoIR();
            frmCalculoIR.MdiParent = this;
            frmCalculoIR.Dock = DockStyle.Fill;
            frmCalculoIR.Visible = false;
            frmCalculoIR.Hide();

            registrar = new frmRegistrar();
            registrar.MdiParent = this;
            registrar.Dock = DockStyle.Fill;
            registrar.Visible = false;
            registrar.Hide();

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}