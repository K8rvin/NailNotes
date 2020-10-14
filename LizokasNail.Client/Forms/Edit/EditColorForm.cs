using LisokasNail.Models;
using LizokasNail.Client.Di;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LizokasNail.Client.Forms.Edit
{
    public partial class EditColorForm : Form
    {
        private readonly IColorRepo _repo;
        private ColorBl _item;

        public EditColorForm(IColorRepo repo, ColorBl item = null)
        {
            InitializeComponent();
            _repo = repo;
            _item = item;

            if (item != null)
            {
                Text = "Редактирование цвета";
            }
            else
            {
                Text = "Новый цвет";
                _item = new ColorBl();
            }

            textEditName.DataBindings.Add("EditValue", _item, nameof(_item.Name), true, DataSourceUpdateMode.OnPropertyChanged);
            textEditComment.DataBindings.Add("EditValue", _item, nameof(_item.Comment), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private bool Validation()
        {
            var items = _repo.Get();
            if (items.Any(x => x.Name.Trim().ToLower() == _item.Name.Trim().ToLower() && x.Id != _item.Id))
            {
                MessageBox.Show("Цвет с таким названием уже существует");
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
