namespace WinFormsApp1
{
    public partial class dtgTableroLetras : Form
    {
        private int tama�o = 15;
        private ClsGeneradorPalabras generador;

        public frmTableroLetras()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            generador = new ClsGeneradorPalabras(tama�o);//intanciar
        }

   
        private void ConfigurarDataGridView()
        {
           dtgTableroLetras.Data
        }
        private void dtgTableroLetras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
