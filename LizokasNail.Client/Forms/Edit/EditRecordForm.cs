using LisokasNail.Models;
using LizokasNail.Client.Di;
using System;
using System.Windows.Forms;
using Unity;

namespace LizokasNail.Client.Forms.Edit
{
    public partial class EditRecordForm : Form
    {
        private readonly IRecordRepo _repo;
        private readonly IUserRepo _userRepo;
        private RecordBl _item;

        public EditRecordForm(IRecordRepo repo, RecordBl item = null)
        {
            InitializeComponent();
            _repo = repo;
            _userRepo = Di.Container.Instance.Resolve<IUserRepo>();

            _item = item;

            if (item != null)
            {
                Text = "Редактирование записи";
            }
            else
            {
                Text = "Новая запись на прием";
                _item = new RecordBl();
                _item.RecordDate = DateTime.Today;
            }
            
            dateEdit.DataBindings.Add("EditValue", _item, nameof(_item.RecordDate));

            searchLookUpEditUser.Properties.DataSource = _userRepo.Get();
            searchLookUpEditUser.Properties.ValueMember = "Id";
            searchLookUpEditUser.Properties.DisplayMember = "Name";
            searchLookUpEditUser.DataBindings.Add("EditValue", _item, nameof(_item.UserId));
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
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
    }
}
