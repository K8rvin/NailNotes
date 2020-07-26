using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Client.Forms.Edit;
using LizokasNail.Client.Utils;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace LizokasNail.Client.Forms
{
    public partial class ColorForm : Form
    {
        private readonly IColorRepo _repo;
        private List<ColorBl> _items = new List<ColorBl>();

        public ColorForm()
        {
            InitializeComponent();
            _repo = Di.Container.Instance.Resolve<IColorRepo>();
            RefreshGrid();
        }

        private void RefreshGrid() => LoadingBar.Instance.ShowLoading(this, GetData, SettingsData);

        private void GetData()
        {
            _items = _repo.Get();
        }

        private void SettingsData()
        {
            gridControlColor.DataSource = _items;
            gridViewColor.BestFitColumns();
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshGrid();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new EditColorForm(_repo);
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
                form.Dispose();
                gridViewColor.FocusedRowHandle = _items.Count - 1;
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
            if (gridViewColor.GetFocusedRow() is ColorBl selected)
            {
                var form = new EditColorForm(_repo, selected);
                form.ShowDialog();
                form.Dispose();
            }
        }
    }
}
