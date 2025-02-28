namespace calculadora_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int V = 0;
        private System.Windows.Forms.TextBox txtScreen;

        // variaveis
        string operador = "";
        double num1 = 0;
        double num2 = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtScreen.Text = V.ToString();
            num1 = 0;
            num2 = 0;
            operador = V.ToString();


        }
        private void btnBack_Click(object sender, EventArgs e)
          {
            if (txtScreen.TextLength == 1)
                txtScreen.Text = "0";
            else
                txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Length - 1);
        }    
    }
}
