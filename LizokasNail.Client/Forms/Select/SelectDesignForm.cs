using DevExpress.XtraEditors;
using LisokasNail.Models;
using LizokasNail.Client.Di;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LizokasNail.Client.Forms.Edit
{
    public partial class SelectDesignForm : Form
    {
        private readonly IDesignRepo _repo;
        public DesignBl _item;
        private List<DesignBl> _designs = new List<DesignBl>();

        public SelectDesignForm(IDesignRepo repo)
        {
            InitializeComponent();
            _repo = repo;
            _item = new DesignBl();

            _designs = _repo.Get();
            searchLookUpEditDesign.Properties.DataSource = _designs;
            searchLookUpEditDesign.Properties.ValueMember = "Id";
            searchLookUpEditDesign.Properties.DisplayMember = "Name";
            searchLookUpEditDesign.DataBindings.Add("EditValue", _item, nameof(_item.Id), true, DataSourceUpdateMode.OnPropertyChanged);

            numericUpDownCount.DataBindings.Add("Value", _item, nameof(_item.Count), true, DataSourceUpdateMode.OnPropertyChanged);
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

        private void searchLookUpEditDesign_EditValueChanged(object sender, EventArgs e)
        {
            SearchLookUpEdit searchLookUpEdit = (SearchLookUpEdit)sender;
            int selectedId = (int)searchLookUpEdit.EditValue;
            if (selectedId != 0)
            {
                var item = _designs.FirstOrDefault(x => x.Id == selectedId);
                _item.Comment = item.Comment;
                _item.Name = item.Name;
                _item.Price = item.Price;
                _item.PriceVip = item.PriceVip;
            }
        }
    }
}
