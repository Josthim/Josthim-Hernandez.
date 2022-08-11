namespace ControlMultasTransito
{
    public partial class frmMultas : Form
    {
        public frmMultas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMultas_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // CAPTURANDO LOS DATOS
            string Placa =  txtPlaca.Text;
            double Velocidad = double.Parse(txtVelocidad.Text);
            DateTime Fecha = DateTime.Parse(lblFecha.Text);
            DateTime Hora = DateTime.Parse(lblHora.Text);

            // PROCESANDO
            double Multa = 0;
            if (Velocidad <= 70)
                Multa = 0;
            else if (Velocidad > 70 && Velocidad <= 90)
                Multa = 120;
            else if (Velocidad > 90 && Velocidad <= 100)
                Multa = 240;
            else if (Velocidad > 100)
                Multa = 350;

            // IMPRIMIENDO LOS RESULTADOS
            ListViewItem fila = new ListViewItem(Placa);
            fila.SubItems.Add(lblFecha.Text);
            fila.SubItems.Add(lblHora.Text);
            fila.SubItems.Add(Velocidad.ToString("0.00"));
            fila.SubItems.Add(Multa.ToString("C"));
            lvMultas.Items.Add(fila);
        }

        ListViewItem item;

        private void lvMultas_MouseClick(object sender, MouseEventArgs e)
        {
            item = lvMultas.GetItemAt(e.X, e.Y);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (item != null)
            {
                lvMultas.Items.Remove(item);
                MessageBox.Show(" ¡LA MULTA HA SIDO ELIMINADA! ");
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UNA MULTA DE LA LISTA");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ESTA SEGURO DE SALIR",
                                             "CONTROL DE MULTAS DE TRANSITO",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();

        }
    }
}