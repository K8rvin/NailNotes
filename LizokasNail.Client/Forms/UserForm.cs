using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Client.Forms.Edit;
using LizokasNail.Client.Utils;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace LizokasNail.Client.Forms
{
    public partial class UserForm : Form
    {
        private readonly IUserRepo _repo;
        private List<UserBl> _items = new List<UserBl>();

        public UserForm()
        {
            InitializeComponent();
            _repo = Di.Container.Instance.Resolve<IUserRepo>();
            RefreshGrid();
        }

        private void RefreshGrid() => LoadingBar.Instance.ShowLoading(this, GetData, SettingsData);

        private void GetData()
        {
            _items = _repo.Get();
        }

        private void SettingsData()
        {
            gridControlUser.DataSource = _items;
            gridViewUser.BestFitColumns();
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshGrid();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditUserForm form = new EditUserForm(_repo);
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
                form.Dispose();
                gridViewUser.FocusedRowHandle = _items.Count - 1;
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
            UserBl selected = gridViewUser.GetFocusedRow() as UserBl;
            if (selected != null)
            {
                var form = new EditUserForm(_repo, selected);
                form.ShowDialog();
                form.Dispose();
            }
        }
    }
}
