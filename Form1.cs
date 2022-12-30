namespace AppBancario
{
    public partial class Form1 : Form
    {
        public Conta cc1;
        public Cliente cli1;

        public void CriarConta()
        {
            this.cli1 = new Cliente
                (
                    textBoxNome.Text,
                    maskedTextBoxCPF.Text,
                    textBoxEmail.Text,
                    dateTimeNasc.Text
                );
            this.cc1 = new Conta();
            cc1.num_cc = 11992;
            cc1.Depositar(false, 0.50);
        }

        public void MostrarSaldo() 
        {
            double saldo_atual = cc1.saldo_cc;
            string saldo_menu = "";
            saldo_menu = Convert.ToString(saldo_atual);
            SaldoShow.Text = saldo_menu;
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriarConta();

            panel1.Enabled = false;
            panel2.Show();
            button1.Visible = false;

            label2.Text = "DADOS PESSOAIS";
            groupBox1.Height = 330;

            NomeCabec.Text = cli1.nome_cli;

            int numcc_atual = cc1.num_cc;
            string numcc_menu = "";
            numcc_menu = Convert.ToString(numcc_atual);
            NumCCShow.Text = numcc_menu;
        }
        private void SaldoShow_Click(object sender, EventArgs e)
        {
            MostrarSaldo();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeNasc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NomeCabec_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NumCCShow_Click(object sender, EventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double transacoes = Convert.ToDouble(vlrTransTextBox.Text);
            cc1.Sacar(transacoes);
            MostrarSaldo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double transacoes = Convert.ToDouble(vlrTransTextBox.Text);
            cc1.Depositar(true, transacoes);
            MostrarSaldo();
        }
    }
}