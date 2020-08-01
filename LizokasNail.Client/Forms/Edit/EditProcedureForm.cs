using LisokasNail.Models;
using LizokasNail.Client.Di;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LizokasNail.Client.Forms.Edit
{
    public partial class EditProcedureForm : Form
    {
        private readonly IProcedureRepo _repo;
        private ProcedureBl _item;

        public EditProcedureForm(IProcedureRepo repo, ProcedureBl item = null)
        {
            InitializeComponent();
            _repo = repo;
            _item = item;

            if (item != null)
            {
                Text = "Редактирование процедуры";
            }
            else
            {
                Text = "Новая процедура";
                _item = new ProcedureBl();
            }

            textEditName.DataBindings.Add("EditValue", _item, nameof(_item.Name));
            textEditShortName.DataBindings.Add("EditValue", _item, nameof(_item.ShortName));
        }

        private bool Validation()
        {
            var items = _repo.Get();
            if (items.Any(x => x.Name.Trim().ToLower() == _item.Name.Trim().ToLower() && x.Id != _item.Id))
            {
                MessageBox.Show("Процедура с таким названием уже существует");
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
