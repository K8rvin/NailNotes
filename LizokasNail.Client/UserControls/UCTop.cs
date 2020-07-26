using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Client.Forms.Edit;
using LizokasNail.Client.Utils;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace LizokasNail.Client.UserControls
{
    public partial class UCTop : UserControl
    {
        private readonly ITopRepo _repo;
        private List<TopBl> _items = new List<TopBl>();

        public UCTop()
        {
            InitializeComponent();
            _repo = Di.Container.Instance.Resolve<ITopRepo>();
        }

        public void Init()
        {
            RefreshGrid();
        }

        private void RefreshGrid() => LoadingBar.Instance.ShowLoading(MainForm.Instance, GetData, SettingsData);

        private void GetData()
        {
            _items = _repo.Get();
        }

        private void SettingsData()
        {
            gridControlTop.DataSource = _items;
            gridViewTop.BestFitColumns();
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshGrid();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new EditTopForm(_repo);
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
                form.Dispose();
                gridViewTop.FocusedRowHandle = _items.Count - 1;
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
            if (gridViewTop.GetFocusedRow() is TopBl selected)
            {
                var form = new EditTopForm(_repo, selected);
                form.ShowDialog();
                form.Dispose();
            }
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = gridViewTop.GetFocusedRow() as TopBl;
            if (selected != null)
            {
                if (MessageBox.Show($"Удалить базу {selected.Name} ?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _repo.Delete(selected.Id);
                    _items.Remove(selected);
                    gridViewTop.RefreshData();
                }
            }
        }
    }
}
