using Microsoft.VisualBasic.Devices;

namespace ParcialTema1.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            txtAltura.Clear();
            txtRadio.Clear();
            txtAltura.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var altura = double.Parse(txtAltura.Text);
                var radio = double.Parse(txtRadio.Text);
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, radio, altura);
                AgregarFila(r);
                MessageBox.Show("Medidas agregadas",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                InicializarControles();
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvMedidas.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, double radio, double altura)
        {
            double Base;
            r.Cells[colAltura.Index].Value = altura;
            r.Cells[colRadio.Index].Value = radio;
            r.Cells[colArea.Index].Value = CalcularArea(radio, altura);
            r.Cells[colBase.Index].Value = CalcularBase(radio);
            r.Cells[colVolumen.Index].Value = CalcularVolumen(radio, altura);
        }

        private object CalcularVolumen(double radio, double altura)
        {
            double Resultado;
            Resultado = (Math.PI * Math.Pow(radio, 2)) * altura;
            return Math.Truncate(Resultado);
        }

        private object CalcularBase(double radio)
        {
            Double Resultado;
            Resultado = Math.PI * Math.Pow(radio, 2);
            return Math.Truncate(Resultado);
        }

        private object CalcularArea(double radio, double altura)
        {
            Double Resultado;
            Resultado = 2 * Math.PI * radio * (altura + radio);
            return Math.Truncate(Resultado);
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvMedidas);
            return r;
        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            errorProvider1.Clear();
            return esValido;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarGrilla();
        }

        private void BorrarGrilla()
        {
            dgvMedidas.Rows.Clear();
            txtAltura.Clear();
            txtRadio.Clear();
            txtAltura.Focus();
        }
    }
}