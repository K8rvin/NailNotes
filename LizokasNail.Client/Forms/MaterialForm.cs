using System.Windows.Forms;

namespace LizokasNail.Client.Forms
{
    public partial class MaterialForm : Form
    {
        /// <summary>
        /// экземпляр класса (паттерн Singleton)
        /// </summary>
        private static MaterialForm _instance;

        /// <summary>
        /// Экземпляр класса (паттерн Singleton)
        /// </summary>
        public static MaterialForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new MaterialForm();
                }
                _instance.Activate();
                return _instance;
            }
        }

        public MaterialForm()
        {
            InitializeComponent();
        }
    }
}
