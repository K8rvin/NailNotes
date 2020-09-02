using System.Windows.Forms;

namespace LizokasNail.Client.Forms
{
    public partial class ReportForm : Form
    {
        /// <summary>
        /// экземпляр класса (паттерн Singleton)
        /// </summary>
        private static ReportForm _instance;

        /// <summary>
        /// Экземпляр класса (паттерн Singleton)
        /// </summary>
        public static ReportForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new ReportForm();
                }
                _instance.Activate();
                return _instance;
            }
        }

        public ReportForm()
        {
            InitializeComponent();
            ucMonthReport1.Init();
        }
    }
}
