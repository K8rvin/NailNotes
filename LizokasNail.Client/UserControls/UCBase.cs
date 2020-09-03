using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Client.Forms.Edit;
using LizokasNail.Client.Utils;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace LizokasNail.Client.UserControls
{
    public partial class UCBase : UserControl
    {
        private readonly IBaseRepo _repo;
        private List<BaseBl> _items = new List<BaseBl>();

        public UCBase()
        {
            InitializeComponent();
            _repo = Di.Container.Instance.Resolve<IBaseRepo>();
        }

        public void Init()
        {
            RefreshGrid();
        }

        private void RefreshGrid() => LoadingBar.Instance.ShowLoading(ParentForm, GetData, SettingsData);

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

        private void gridView_DoubleClick(object sender, System.EventArgs e)
        {
            if (GridViewDoubleClick.IsClickInRow(sender, e))
            {
                ShowEditForm();
            }
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

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = gridViewBase.GetFocusedRow() as BaseBl;
            if (selected != null)
            {
                if (MessageBox.Show($"Удалить базу {selected.Name} ?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _repo.Delete(selected.Id);
                    _items.Remove(selected);
                    gridViewBase.RefreshData();
                }
            }
        }

        private void UCBase_Load(object sender, System.EventArgs e)
        {
            RefreshGrid();
        }
    }
}
