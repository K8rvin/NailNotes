using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Client.Forms.Edit;
using LizokasNail.Client.Utils;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace LizokasNail.Client.UserControls
{
    public partial class UCProcedure : UserControl
    {
        private readonly IProcedureRepo _repo;
        private List<ProcedureBl> _items = new List<ProcedureBl>();

        public UCProcedure()
        {
            InitializeComponent();
            _repo = Di.Container.Instance.Resolve<IProcedureRepo>();
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
            gridControlProcedure.DataSource = _items;
            gridViewProcedure.BestFitColumns();
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshGrid();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new EditProcedureForm(_repo);
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
                form.Dispose();
                gridViewProcedure.FocusedRowHandle = _items.Count - 1;
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
            if (gridViewProcedure.GetFocusedRow() is ProcedureBl selected)
            {
                var form = new EditProcedureForm(_repo, selected);
                form.ShowDialog();
                form.Dispose();
            }
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = gridViewProcedure.GetFocusedRow() as ProcedureBl;
            if (selected != null)
            {
                if (MessageBox.Show($"Удалить процедуру {selected.Name} ?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _repo.Delete(selected.Id);
                    _items.Remove(selected);
                    gridViewProcedure.RefreshData();
                }
            }
        }

        private void UC_Load(object sender, System.EventArgs e)
        {
            RefreshGrid();
        }
    }
}
