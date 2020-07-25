using LizokasNail.Client.Forms;
using System.Windows.Forms;

namespace LizokasNail.Client
{
    public partial class MainForm : Form
    {
        #region Ctr

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion Ctr

        #region Props

        /// <summary>
        /// экземпляр класса (паттерн Singleton)
        /// </summary>
        private static MainForm _instance;

        /// <summary>
        /// Экземпляр класса (паттерн Singleton)
        /// </summary>
        public static MainForm Instance => _instance ?? (_instance = new MainForm());

        #endregion Props

        #region Menu

        private void barButtonItemUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new UserForm();
            form.Show();
        }

        private void barButtonItemRecords_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new RecordForm();
            form.Show();
        }

        private void barButtonItemBase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new BaseForm();
            form.Show();
        }

        #endregion Menu


    }
}
