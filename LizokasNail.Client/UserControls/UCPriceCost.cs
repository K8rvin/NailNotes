using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Client.Forms.Edit;
using LizokasNail.Client.Utils;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace LizokasNail.Client.UserControls
{
    public partial class UCPriceCost : UserControl
    {
        private readonly IPriceCostRepo _repo;
        private List<PriceCostBl> _items = new List<PriceCostBl>();

        public UCPriceCost()
        {
            InitializeComponent();
            _repo = Di.Container.Instance.Resolve<IPriceCostRepo>();
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
            gridControlPriceCost.DataSource = _items;
            gridViewPriceCost.BestFitColumns();
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshGrid();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new EditPriceCostForm(_repo);
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
                form.Dispose();
                gridViewPriceCost.FocusedRowHandle = _items.Count - 1;
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
            if (gridViewPriceCost.GetFocusedRow() is PriceCostBl selected)
            {
                var form = new EditPriceCostForm(_repo, selected);
                form.ShowDialog();
                form.Dispose();
            }
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = gridViewPriceCost.GetFocusedRow() as PriceCostBl;
            if (selected != null)
            {
                if (MessageBox.Show($"Удалить себестоимость {selected.Type} {selected.Procedure} за {selected.DateEnd:Y} ?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _repo.Delete(selected.Id);
                    _items.Remove(selected);
                    gridViewPriceCost.RefreshData();
                }
            }
        }

        private void UCBase_Load(object sender, System.EventArgs e)
        {
            RefreshGrid();
        }
    }
}
