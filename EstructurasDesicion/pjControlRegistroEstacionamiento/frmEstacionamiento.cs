namespace pjControlRegistroEstacionamiento
{
    public partial class frmEstacionamiento : Form
    {
        string dia;
        public frmEstacionamiento()
        {
            InitializeComponent();
        }

        private void frmEstacionamiento_Load(object sender, EventArgs e)
        {
            //Mostrando la fecha actual
            lblFecha.Text = DateTime.Now.ToShortDateString();

            // Determinar el dia
            DateTime Fecha = DateTime.Parse(lblFecha.Text);
            dia = Fecha.ToString("ddddd");

            double costo = 0;
            switch (dia)
            {
                case "domingo": costo = 2; break;
                case "lunes":
                case "martes":
                case "mércoles":
                case "jueves":
                    costo = 4; break;
                case "viernes":
                case "sabado":
                    costo = 7; break;
            }
            lBLCosto.Text = costo.ToString("0.00");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Capturando los datos del formulario
            string placa = txtPlaca.Text;
            double costo = double.Parse(lBLCosto.Text);
            DateTime fecha = DateTime.Parse(lblFecha.Text);
            DateTime horaInicio = DateTime.Parse(txtHoraInicio.Text);
            DateTime horaFin = DateTime.Parse(txtHoraFin.Text);

            // Calcular la hora
            TimeSpan hora = horaFin - horaInicio;

            // Calcular el importe
            double importe = costo * (hora.TotalHours);

            ListViewItem FILA = new ListViewItem(placa);
            FILA.SubItems.Add(fecha.ToString("d"));
            FILA.SubItems.Add(horaInicio.ToString("t"));
            FILA.SubItems.Add(horaFin.ToString("t"));
            FILA.SubItems.Add(hora.TotalHours.ToString());
            FILA.SubItems.Add(costo.ToString("C"));
            FILA.SubItems.Add(importe.ToString("C"));
            lvRegistro.Items.Add(FILA);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPlaca.Clear();
            txtHoraInicio.Clear();
            txtHoraFin.Clear();
            txtPlaca.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de salir?",
                                             "Estacionamiento",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}