namespace pjControlRegistroMascota
{
    public partial class frmRegistro : Form
    {
    
        frmGato avanzar;
        frmPerro siguiente;

            public frmRegistro()
            {

                InitializeComponent();
            }

            private void btnPerro_Click(object sender, EventArgs e)
            {
                siguiente = new frmPerro();
                siguiente.Show();
                this.Hide();

            }

        private void btnGato_Click(object sender, EventArgs e)
        {
            avanzar = new frmGato();
            avanzar.Show();
            this.Hide();
        }
    }


}