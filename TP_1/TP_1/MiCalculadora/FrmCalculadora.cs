using Entidades;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        private Operando num1;
        private Operando num2;
        private bool binario;

        public FrmCalculadora()
        {
            InitializeComponent();

            num1 = new Operando("stringPrueba");
            num2 = new Operando();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Asigna a la varibles Operando los valores actuales de los textbox, verifica operador, llama a la acción Operar, escribe el resultado
        /// Setea como falso, que el resultado este expresado en binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            char auxChar;

            num1.Numero = txtNumero1.Text;
            num2.Numero = txtNumero2.Text;

            if (cmbOperador.SelectedItem == null)
                auxChar = '+';
            else
                auxChar = char.Parse(cmbOperador.SelectedItem.ToString());

            if (auxChar == '/' && txtNumero2.Text == "0")
                lblResultado.Text = "Error no se puede dividir por 0";
            else
            {
                lblResultado.Text = Operar(num1, num2, auxChar);
                listOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.SelectedItem} {txtNumero2.Text} = {lblResultado.Text}");

                binario = false;
            }
        }

        /// <summary>
        /// Llama a la función Limpiar, limpia los valores en pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Llama al cierra el formulario, validando salida antes de cerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Llama al método para realizar una conversión de numero decimal a numero binario.
        /// Setea como falso, que el resultado este expresado en decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (!binario && lblResultado.Text != "")
            {
                this.lblResultado.Text = Operando.DecimalBinario(this.lblResultado.Text).ToString();
                this.binario = true;
            }
        }

        /// <summary>
        /// Llama al método para realizar una conversión de numero binario a numero decimal.
        /// Setea como falso, que el resultado este expresado en binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (binario && lblResultado.Text != "")
            {
                this.lblResultado.Text = Operando.BinarioDecimal((this.lblResultado.Text).ToString());
                this.binario = false;
            }
        }

        /// <summary>
        /// Cierra el formulario, muestra el mensaje de confirmación de salida previamente        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        /// <summary>
        /// Limpia los valores de los objetos componentes del form calculadora (borra valores en cuadros de texto y combobox)
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.SelectedIndex = -1;
            this.listOperaciones.Clear();
            this.lblResultado.Text = "";
        }

        /// <summary>
        /// Llama al método Operar de la clase Calculadora, pasándole los Operando como parámetros
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resultado del método Operar de la clase Calculadora, en formato string</returns>
        private static string Operar(Operando num1, Operando num2, char operador)
        {
            return Calculadora.Operar(num1, num2, operador).ToString();
        }
    }
}