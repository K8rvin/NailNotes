using LisokasNail.Models;
using LizokasNail.Client.Di;
using System;
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
