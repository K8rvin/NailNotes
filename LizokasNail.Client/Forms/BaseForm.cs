using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Client.Forms.Edit;
using LizokasNail.Client.Utils;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace LizokasNail.Client.Forms
{
    public partial class BaseForm : Form
    {
        private readonly IBaseRepo _repo;
        private List<BaseBl> _items = new List<BaseBl>();

        public BaseForm()
        {
            InitializeComponent();
            _repo = Di.Container.Instance.Resolve<IBaseRepo>();
            RefreshGrid();
        }

        private void RefreshGrid() => LoadingBar.Instance.ShowLoading(this, GetData, SettingsData);

        private void GetData()
        {
            _items = _repo.Get();
        }

        private void SettingsData()
        {
            gridControlBase.DataSource = _items;
            gridViewBase.BestFitColumns();
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshGrid();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new EditBaseForm(_repo);
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
                form.Dispose();
                gridViewBase.FocusedRowHandle = _items.Count - 1;
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
            if (gridViewBase.GetFocusedRow() is BaseBl selected)
            {
                var form = new EditBaseForm(_repo, selected);
                form.ShowDialog();
                form.Dispose();
            }
        }
    }
}
