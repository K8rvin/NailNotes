using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Client.Forms.Edit;
using LizokasNail.Client.Utils;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace LizokasNail.Client.UserControls
{
    public partial class UCDesign : UserControl
    {
        public UCDesign()
        {
            InitializeComponent();
            _repo = Di.Container.Instance.Resolve<IDesignRepo>();
        }

        private readonly IDesignRepo _repo;
        private List<DesignBl> _items = new List<DesignBl>();

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
            gridControlDesign.DataSource = _items;
            gridViewDesign.BestFitColumns();
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshGrid();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new EditDesignForm(_repo);
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
                form.Dispose();
                gridViewDesign.FocusedRowHandle = _items.Count - 1;
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
            if (gridViewDesign.GetFocusedRow() is DesignBl selected)
            {
                var form = new EditDesignForm(_repo, selected);
                form.ShowDialog();
                form.Dispose();
            }
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = gridViewDesign.GetFocusedRow() as DesignBl;
            if (selected != null)
            {
                if (MessageBox.Show($"Удалить дизайн {selected.Name} ?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _repo.Delete(selected.Id);
                    _items.Remove(selected);
                    gridViewDesign.RefreshData();
                }
            }
        }

        private void UCDesign_Load(object sender, System.EventArgs e)
        {
            RefreshGrid();
        }
    }
}
