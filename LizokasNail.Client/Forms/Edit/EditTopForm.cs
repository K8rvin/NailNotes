using LisokasNail.Models;
using LizokasNail.Client.Di;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LizokasNail.Client.Forms.Edit
{
    public partial class EditTopForm : Form
    {
        private readonly ITopRepo _repo;
        public TopBl _item;

        public EditTopForm(ITopRepo repo, TopBl item = null)
        {
            InitializeComponent();
            _repo = repo;
            _item = item;

            if (item != null)
            {
                Text = "Редактирование топа";
            }
            else
            {
                Text = "Новый топ";
                _item = new TopBl();
            }

            textEditName.DataBindings.Add("EditValue", _item, nameof(_item.Name), true, DataSourceUpdateMode.OnPropertyChanged);
            textEditComment.DataBindings.Add("EditValue", _item, nameof(_item.Comment), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private bool Validation()
        {
            var items = _repo.Get();
            if (items.Any(x => x.Name.Trim().ToLower() == _item.Name.Trim().ToLower() && x.Id != _item.Id))
            {
                MessageBox.Show("База с таким названием уже существует");
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
                _item = _repo.Add(_item);
            }
            else
            {
                _repo.Update(_item);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
