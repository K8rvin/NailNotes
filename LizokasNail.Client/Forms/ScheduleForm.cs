using System;
using System.Linq;
using System.Windows.Forms;

namespace LizokasNail.Client.Forms
{
    public partial class ScheduleForm : Form
    {
        /// <summary>
        /// экземпляр класса (паттерн Singleton)
        /// </summary>
        private static ScheduleForm _instance;

        /// <summary>
        /// Экземпляр класса (паттерн Singleton)
        /// </summary>
        public static ScheduleForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new ScheduleForm();
                }
                _instance.Activate();
                return _instance;
            }
        }

        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void simpleButtonLeft_Click(object sender, System.EventArgs e)
        {
            barEditItemDate.EditValue = ucSchedule1.Periods.First().Item1.AddDays(-7);
        }

        private void simpleButtonRight_Click(object sender, System.EventArgs e)
        {
            barEditItemDate.EditValue = ucSchedule1.Periods.First().Item1.AddDays(7);
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barEditItemDate.EditValue = ucSchedule1.Periods.First().Item1;
        }

        private void barEditItemDate_EditValueChanged(object sender, System.EventArgs e)
        {
            ucSchedule1.Init((DateTime) barEditItemDate.EditValue);
        }
    }
}
