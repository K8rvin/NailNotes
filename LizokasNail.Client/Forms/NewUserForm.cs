using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Contract.Enum;
using System;
using System.Windows.Forms;
using Unity;

namespace LizokasNail.Client.Forms
{
    public partial class NewUserForm : Form
    {
        private readonly IRecordRepo _repo;
        private RecordBl _item;

        public NewUserForm()
        {
            InitializeComponent();
            _repo = Di.Container.Instance.Resolve<IRecordRepo>();
            _item = new RecordBl() { User = new UserBl(), RecordDate = DateTime.Today};

            textEditName.DataBindings.Add("EditValue", _item.User, nameof(_item.User.Name));
            textEditPhone.DataBindings.Add("EditValue", _item.User, nameof(_item.User.Phone));
            textEditComment.DataBindings.Add("EditValue", _item.User, nameof(_item.User.Comment));

            imageComboBoxEditCommunication.Properties.Items.AddEnum<CommunicationType>();
            imageComboBoxEditCommunication.DataBindings.Add("EditValue", _item.User, nameof(_item.User.CommunicationType));

            dateNavigator1.DataBindings.Add("DateTime", _item, nameof(_item.RecordDate));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            _repo.AddNewUserRecord(_item);
            DialogResult = DialogResult.OK;
        }
    }
}
