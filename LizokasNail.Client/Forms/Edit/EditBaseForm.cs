using LisokasNail.Models;
using LizokasNail.Client.Di;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LizokasNail.Client.Forms.Edit
{
    public partial class EditBaseForm : Form
    {
        private readonly IBaseRepo _repo;
        private BaseBl _item;

        public EditBaseForm(IBaseRepo repo, BaseBl item = null)
        {
            InitializeComponent();
            _repo = repo;
            _item = item;

            if (item != null)
            {
                Text = "Редактирование базы";
            }
            else
            {
                Text = "Новая база";
                _item = new BaseBl();
            }

            textEditName.DataBindings.Add("EditValue", _item, nameof(_item.Name));
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
