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
            barEditItemDateStart.EditValue = new DateTime(today.Year, today.Month, 1);
            barEditItemDateEnd.EditValue = ((DateTime)barEditItemDateStart.EditValue).AddMonths(1).AddDays(-1);
            RefreshGrid();
        }

        private void RefreshGrid() => LoadingBar.Instance.ShowLoading(ParentForm, GetData, SettingsData);

        private void GetData()
        {
            viewModel.Items = _repo.GetMonthReport((DateTime)barEditItemDateStart.EditValue, (DateTime)barEditItemDateEnd.EditValue);            
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
