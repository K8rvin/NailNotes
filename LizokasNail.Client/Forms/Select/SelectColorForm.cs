using DevExpress.XtraEditors;
using LisokasNail.Models;
using LizokasNail.Client.Di;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LizokasNail.Client.Forms.Edit
{
    public partial class SelectColorForm : Form
    {
        private readonly IColorRepo _repo;
        public ColorBl _item;
        private List<ColorBl> _colors = new List<ColorBl>();

        public SelectColorForm(IColorRepo repo)
        {
            InitializeComponent();
            _repo = repo;
            _item = new ColorBl();

            textEditComment.DataBindings.Add("EditValue", _item, nameof(_item.Comment), true, DataSourceUpdateMode.OnPropertyChanged);

            _colors = _repo.Get();
            searchLookUpEditColor.Properties.DataSource = _colors;
            searchLookUpEditColor.Properties.ValueMember = "Id";
            searchLookUpEditColor.Properties.DisplayMember = "Name";
            searchLookUpEditColor.DataBindings.Add("EditValue", _item, nameof(_item.Id), true, DataSourceUpdateMode.OnPropertyChanged);
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

        private void searchLookUpEditColor_EditValueChanged(object sender, EventArgs e)
        {
            SearchLookUpEdit searchLookUpEdit = (SearchLookUpEdit)sender;
            int selectedId = (int)searchLookUpEdit.EditValue;
            if (selectedId != 0)
            {
                var item = _colors.FirstOrDefault(x => x.Id == selectedId);
                _item.Comment = item.Comment;
                _item.Name = item.Name;
            }
        }
    }
}
