using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Client.Utils;
using System;
using System.Windows.Forms;
using Unity;

namespace LizokasNail.Client.UserControls
{
    public partial class UCMonthReport : UserControl
    {
        private readonly IReportRepo _repo;
        private MonthReportViewModel viewModel;

        public UCMonthReport()
        {
            InitializeComponent();
            _repo = Di.Container.Instance.Resolve<IReportRepo>();
            viewModel = new MonthReportViewModel();

            numericUpDownTotalCost.DataBindings.Add("Value", viewModel, nameof(viewModel.TotalCost));
            numericUpDownTotalPrice.DataBindings.Add("Value", viewModel, nameof(viewModel.TotalPrice));
            numericUpDownTotalIncoming.DataBindings.Add("Value", viewModel, nameof(viewModel.TotalIncoming));

            numericUpDownTotalCost.Controls[0].Enabled = false;  // Disable the arrow buttons.
            numericUpDownTotalPrice.Controls[0].Enabled = false;
            numericUpDownTotalIncoming.Controls[0].Enabled = false;
        }

        public void Init()
        {
            var today = DateTime.Today;
            barEditItemYear.EditValue = today.Year;
            barEditItemMonth.EditValue = today.Month;
            RefreshGrid();
        }

        private void RefreshGrid() => LoadingBar.Instance.ShowLoading(ParentForm, GetData, SettingsData);

        private void GetData()
        {
            var dateStart = new DateTime(int.Parse(barEditItemYear.EditValue.ToString()), (int)barEditItemMonth.EditValue, 1);
            var dateEnd = dateStart.AddMonths(1).AddDays(-1);
            viewModel.Items = _repo.GetMonthReport(dateStart, dateEnd);            
        }

        private void SettingsData()
        {
            gridControlReport.DataSource = viewModel.Items;
            InvokeTotals();
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshGrid();
        }

        private void gridViewReport_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            InvokeTotals();
        }

        private void InvokeTotals()
        {
            viewModel.OnPropertyChanged(nameof(viewModel.TotalCost));
            viewModel.OnPropertyChanged(nameof(viewModel.TotalPrice));
            viewModel.OnPropertyChanged(nameof(viewModel.TotalIncoming));
        }
    }
}
