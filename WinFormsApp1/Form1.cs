namespace WinFormsApp1
{
    public partial class dtgTableroLetras : Form
    {
        private int tamaño = 15;
        private ClsGeneradorPalabras generador;

        public frmTableroLetras()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            generador = new ClsGeneradorPalabras(tamaño);//intanciar
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
