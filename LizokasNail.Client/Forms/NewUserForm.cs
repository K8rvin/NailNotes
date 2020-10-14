using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Contract.Dto;
using LizokasNail.Contract.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace LizokasNail.Client.Forms
{
    public partial class NewUserForm : Form
    {
        private readonly IRecordRepo _repo;
        private readonly IProcedureRepo _procedureRepo;
        private RecordBl _item;

        public NewUserForm()
        {
            InitializeComponent();
            _repo = Di.Container.Instance.Resolve<IRecordRepo>();
            _procedureRepo = Di.Container.Instance.Resolve<IProcedureRepo>();
            _item = new RecordBl() { User = new UserBl(), RecordDate = DateTime.Today};

            textEditName.DataBindings.Add("EditValue", _item.User, nameof(_item.User.Name), true, DataSourceUpdateMode.OnPropertyChanged);
            textEditPhone.DataBindings.Add("EditValue", _item.User, nameof(_item.User.Phone), true, DataSourceUpdateMode.OnPropertyChanged);
            textEditComment.DataBindings.Add("EditValue", _item.User, nameof(_item.User.Comment), true, DataSourceUpdateMode.OnPropertyChanged);

            imageComboBoxEditCommunication.Properties.Items.AddEnum<CommunicationType>();
            imageComboBoxEditCommunication.DataBindings.Add("EditValue", _item.User, nameof(_item.User.CommunicationType), true, DataSourceUpdateMode.OnPropertyChanged);

            dateNavigator1.DataBindings.Add("DateTime", _item, nameof(_item.RecordDate), true, DataSourceUpdateMode.OnPropertyChanged);

            var procedures = _procedureRepo.Get();
            SetProcedures(procedures);
        }

        private void SetProcedures(List<ProcedureBl> procedures)
        {
            if (procedures?.Any() == true)
            {
                foreach (var item in procedures)
                {
                    CreateProcedureCheckBox(item);
                }
            }
        }

        private void CreateProcedureCheckBox(ProcedureBl procedure)
        {
            layoutControl1.BeginUpdate();
            try
            {
                //Create checkbox element 
                CheckEdit checkBox = new CheckEdit();
                checkBox.Text = procedure.Name;
                checkBox.Checked = _item.Record2Procedure.Any(x => x.IdProcedure == procedure.Id);
                checkBox.Tag = procedure;

                // Create a layout item and insert checkbox
                LayoutControlItem layoutItem = new LayoutControlItem(layoutControl1, checkBox);
                layoutItem.Parent = layoutControlGroup1;
                layoutItem.Name = "layoutItemProcedure" + procedure.Id;
                layoutItem.TextVisible = false;
                layoutItem.Move(emptySpaceItem1, InsertType.Top);
            }
            finally
            {
                // Unlock and update the layout control.
                layoutControl1.EndUpdate();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            ProcessTabKey(true);
            GetProcedures();

            if (Validation() == false)
            {
                MessageBox.Show("Не заполнены все необходимые поля");
                return;
            }

            _repo.AddNewUserRecord(_item);
            DialogResult = DialogResult.OK;
        }

        private void GetProcedures()
        {
            var procedureLabels = layoutControlGroup1.Items.Where(x => x.GetType() == typeof(LayoutControlItem) && x.Name.Contains("layoutItemProcedure"));
            var checkBoxesChecked = procedureLabels.Select(x => (CheckEdit)(x as LayoutControlItem).Control).Where(x => x.Checked);
            var items = checkBoxesChecked.Select(x => (ProcedureBl)x.Tag);
            _item.Record2Procedure = items.Select(x => new Record2ProcedureDto(x, _item.Id));
        }

        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(_item.UserName)) return false;

            return true;
        }
    }
}
