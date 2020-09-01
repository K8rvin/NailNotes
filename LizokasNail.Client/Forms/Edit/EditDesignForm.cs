using LisokasNail.Models;
using LizokasNail.Client.Di;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LizokasNail.Client.Forms.Edit
{
    public partial class EditDesignForm : Form
    {
        private readonly IDesignRepo _repo;
        private DesignBl _item;

        public EditDesignForm(IDesignRepo repo, DesignBl item = null)
        {
            InitializeComponent();
            _repo = repo;
            _item = item;

            if (item != null)
            {
                Text = "Редактирование дизайна";
            }
            else
            {
                Text = "Новый дизайн";
                _item = new DesignBl();
            }

            textEditName.DataBindings.Add("EditValue", _item, nameof(_item.Name), true, DataSourceUpdateMode.OnPropertyChanged);
            textEditComment.DataBindings.Add("EditValue", _item, nameof(_item.Comment), true, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownPrice.DataBindings.Add("Value", _item, nameof(_item.Price), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private bool Validation()
        {
            var items = _repo.Get();
            if (items.Any(x => x.Name.Trim().ToLower() == _item.Name.Trim().ToLower() && x.Id != _item.Id))
            {
                MessageBox.Show("Дизайн с таким названием уже существует");
                return false;
            }

            return true;
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            if (Validation() == false)
                return;
            ProcessTabKey(true);

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
