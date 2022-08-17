namespace pjControlRegistroParticipante
{
    public partial class frmParticipantes : Form
    {
        int num;
        int cJefe, cOperario, cAdministrativo, cPracticante;
        public frmParticipantes()
        {
            InitializeComponent();
            tHora.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de salir?",
                                             "Participante",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Exclamation);
            if(r == DialogResult.Yes)
                this.Close();
        }

        private void tHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void frmParticipantes_Load(object sender, EventArgs e)
        {
            num++;
            lblNumeros.Text = num.ToString("0000"); 
            lblFecha.Text = DateTime.Now.ToString("d");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Capturando los datos
            DateTime fecha, hora;
            string participante, cargo;
            int numero;
            participante = txtParticipante.Text;
            numero = int.Parse(lblNumeros.Text);
            fecha = DateTime.Parse(lblFecha.Text);
            hora = DateTime.Parse(lblHora.Text);
            cargo = cboCargo.Text;

            // Contabilizar la cantidad segun los cargos
            switch (cargo)
            {
                case "Jefe": cJefe++; break;
                case "Operario": cOperario++; break;
                case "Administrativo": cAdministrativo++; break;
                case "Practicante": cPracticante++; break;
            }

            // Imprimiendo el registro
            ListViewItem fila = new ListViewItem(numero.ToString());
            fila.SubItems.Add(participante);
            fila.SubItems.Add(cargo);
            fila.SubItems.Add(fecha.ToString("d"));
            fila.SubItems.Add(hora.ToString("hh:mm:ss"));
            lvParticipante.Items.Add(fila);

            // Imprimiendo las estatdisticas
            lvEstadistica.Items.Clear();
            string[] elementosFila = new string[2];
            ListViewItem row;

            // Añadimos la primera fila al lvEstadisticas
            elementosFila[0] = "Jefe";
            elementosFila[1] = cJefe.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadistica.Items.Add(row);

            // Añadimos la primera fila al lvEstadisticas
            elementosFila[0] = "Operario";
            elementosFila[1] = cOperario.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadistica.Items.Add(row);

            // Añadimos la primera fila al lvEstadisticas
            elementosFila[0] = "Administrativo";
            elementosFila[1] = cAdministrativo.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadistica.Items.Add(row);

            // Añadimos la primera fila al lvEstadisticas
            elementosFila[0] = "Practicante";
            elementosFila[1] = cPracticante.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadistica.Items.Add(row);

            // Mostrando el nuevo numero de registro
            num++;
            lblNumeros.Text = num.ToString("D4");

            // Limpiando los controles
            txtParticipante.Clear();
            cboCargo.SelectedIndex = -1;
            txtParticipante.Focus();




        }
    }
}