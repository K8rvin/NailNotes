using DevExpress.XtraEditors;
using LisokasNail.Models;
using LizokasNail.Client.Di;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LizokasNail.Client.Forms.Edit
{
    public partial class SelectTopForm : Form
    {
        private readonly ITopRepo _repo;
        public TopBl _item;
        private List<TopBl> _tops = new List<TopBl>();

        public SelectTopForm(ITopRepo repo)
        {
            InitializeComponent();
            _repo = repo;
            _item = new TopBl();

            textEditComment.DataBindings.Add("EditValue", _item, nameof(_item.Comment), true, DataSourceUpdateMode.OnPropertyChanged);

            _tops = _repo.Get();
            searchLookUpEditTop.Properties.DataSource = _tops;
            searchLookUpEditTop.Properties.ValueMember = "Id";
            searchLookUpEditTop.Properties.DisplayMember = "Name";
            searchLookUpEditTop.DataBindings.Add("EditValue", _item, nameof(_item.Id), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private bool Validation()
        {
            if (_item.Id == 0) return false;

            return true;
        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            ProcessTabKey(true);

            if (Validation() == false)
            {
                MessageBox.Show("Не заполнены все необходимые поля");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void searchLookUpEditTop_EditValueChanged(object sender, EventArgs e)
        {
            SearchLookUpEdit searchLookUpEdit = (SearchLookUpEdit)sender;
            int selectedId = (int)searchLookUpEdit.EditValue;
            if (selectedId != 0)
            {
                var item = _tops.FirstOrDefault(x => x.Id == selectedId);
                _item.Comment = item.Comment;
                _item.Name = item.Name;
            }
        }
    }
}
