using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Client.Forms.Edit;
using LizokasNail.Client.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace LizokasNail.Client.UserControls
{
    public partial class UCCheck : UserControl
    {
        public UCCheck()
        {
            InitializeComponent();
            _repo = Di.Container.Instance.Resolve<ICheckRepo>();
        }

        private readonly ICheckRepo _repo;
        private List<CheckBl> _items = new List<CheckBl>();

        public void Init()
        {
            var today = DateTime.Today;
            barEditItemDateStart.EditValue = new DateTime(today.Year, today.Month, 1);
            barEditItemDateEnd.EditValue = ((DateTime)barEditItemDateStart.EditValue).AddMonths(1).AddDays(-1);
            RefreshGrid();
        }

        private void RefreshGrid() => LoadingBar.Instance.ShowLoading(MainForm.Instance, GetData, SettingsData);

        private void GetData()
        {
            if (barEditItemDateStart.EditValue != null && barEditItemDateEnd.EditValue != null)
                _items = _repo.GetByPeriod((DateTime)barEditItemDateStart.EditValue, (DateTime)barEditItemDateEnd.EditValue);
        }

        private void SettingsData()
        {
            gridControlCheck.DataSource = _items;
            gridViewCheck.BestFitColumns();
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshGrid();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new EditCheckForm(_repo);
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
                form.Dispose();
                gridViewCheck.FocusedRowHandle = _items.Count - 1;
            }
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowEditForm();
        }

        private void gridViewUser_DoubleClick(object sender, System.EventArgs e)
        {
            ShowEditForm();
        }

        private void ShowEditForm()
        {
            if (gridViewCheck.GetFocusedRow() is CheckBl selected)
            {
                var form = new EditCheckForm(_repo, selected);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                    form.Dispose();
                }
            }
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = gridViewCheck.GetFocusedRow() as CheckBl;
            if (selected != null)
            {
                if (MessageBox.Show($"Удалить расчет по {selected.Record.DisplayName} ?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _repo.Delete(selected.Id);
                    _items.Remove(selected);
                    gridViewCheck.RefreshData();
                }
            }
        }

        private void barEditItemDate_EditValueChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
