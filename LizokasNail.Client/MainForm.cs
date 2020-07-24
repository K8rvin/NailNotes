using LizokasNail.Client.Forms;
using System.Windows.Forms;

namespace LizokasNail.Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// экземпляр класса (паттерн Singleton)
        /// </summary>
        private static MainForm _instance;

        /// <summary>
        /// Экземпляр класса (паттерн Singleton)
        /// </summary>
        public static MainForm Instance => _instance ?? (_instance = new MainForm());

        private void barButtonItemUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserForm form = new UserForm();
            form.Show();
        }
    }
}
