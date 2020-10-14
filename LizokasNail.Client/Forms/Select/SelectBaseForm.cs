using DevExpress.XtraEditors;
using LisokasNail.Models;
using LizokasNail.Client.Di;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LizokasNail.Client.Forms.Edit
{
    public partial class SelectBaseForm : Form
    {
        private readonly IBaseRepo _repo;
        public BaseBl _item;
        private List<BaseBl> _bases = new List<BaseBl>();

        public SelectBaseForm(IBaseRepo repo)
        {
            InitializeComponent();
            _repo = repo;
            _item = new BaseBl();
            Bind();
        }

        private void Bind()
        {
            textEditComment.DataBindings.Clear();
            textEditComment.DataBindings.Add("EditValue", _item, nameof(_item.Comment), true, DataSourceUpdateMode.OnPropertyChanged);

            _bases = _repo.Get();
            searchLookUpEditBase.Properties.DataSource = _bases;
            searchLookUpEditBase.Properties.ValueMember = "Id";
            searchLookUpEditBase.Properties.DisplayMember = "Name";
            searchLookUpEditBase.DataBindings.Clear();
            searchLookUpEditBase.DataBindings.Add("EditValue", _item, nameof(_item.Id), true, DataSourceUpdateMode.OnPropertyChanged);
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

        private void searchLookUpEditBase_EditValueChanged(object sender, EventArgs e)
        {
            SearchLookUpEdit searchLookUpEdit = (SearchLookUpEdit)sender;
            int selectedId = (int)searchLookUpEdit.EditValue;
            if (selectedId != 0)
            {
                var item = _bases.FirstOrDefault(x => x.Id == selectedId);
                _item.Comment = item.Comment;
                _item.Name = item.Name;
            }
        }

        private void simpleButtonAddBase_Click(object sender, EventArgs e)
        {
            var form = new EditBaseForm(_repo);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _item = form._item;
                Bind();
                form.Dispose();
            }
        }
    }
}
