using LisokasNail.Models;
using LizokasNail.Client.Di;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LizokasNail.Client.Forms.Edit
{
    public partial class EditPriceCostForm : Form
    {
        private readonly IPriceCostRepo _repo;
        private PriceCostBl _item;

        public EditPriceCostForm(IPriceCostRepo repo, PriceCostBl item = null)
        {
            InitializeComponent();
            _repo = repo;
            _item = item;

            if (item != null)
            {
                Text = "Редактирование себестоимости";
            }
            else
            {
                Text = "Новая себестоимость";
                _item = new PriceCostBl();
                _item.DateEnd = DateTime.Today;
            }

            textEditType.DataBindings.Add("EditValue", _item, nameof(_item.Type), true, DataSourceUpdateMode.OnPropertyChanged);
            textEditProcedure.DataBindings.Add("EditValue", _item, nameof(_item.Procedure), true, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownValue.DataBindings.Add("Value", _item, nameof(_item.Value), true, DataSourceUpdateMode.OnPropertyChanged);
            dateEditDateEnd.DataBindings.Add("EditValue", _item, nameof(_item.DateEnd), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private bool Validation()
        {
            var items = _repo.Get();
            if (items.Any(
                x => x.Type.Trim().ToLower() == _item.Type.Trim().ToLower()
                && x.Procedure.Trim().ToLower() == _item.Procedure.Trim().ToLower()
                && x.DateEnd == new DateTime(_item.DateEnd.Year, _item.DateEnd.Month, 1).AddMonths(1).AddDays(-1)
                && x.Id != _item.Id))
            {
                MessageBox.Show("Себестоимость с таким типом, процедурой и сроком уже существует!");
                return false;
            }

            return true;
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            ProcessTabKey(true);

            if (Validation() == false)
                return;

            if (_item.Id == 0)
            {
                _repo.Add(_item);
            }
            else
            {
                _repo.Update(_item);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
