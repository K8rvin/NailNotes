using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Contract.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace LizokasNail.Client.Forms.Edit
{
    public partial class EditRecordForm : Form
    {
        private readonly IRecordRepo _repo;
        private readonly IUserRepo _userRepo;
        private readonly IProcedureRepo _procedureRepo;
        private RecordBl _item;

        public EditRecordForm(IRecordRepo repo, RecordBl item = null)
        {
            InitializeComponent();
            _repo = repo;
            _userRepo = Di.Container.Instance.Resolve<IUserRepo>();
            _procedureRepo = Di.Container.Instance.Resolve<IProcedureRepo>();

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
            dateNavigator1.DataBindings.Add("DateTime", _item, nameof(_item.RecordDate));

            searchLookUpEditUser.Properties.DataSource = _userRepo.Get();
            searchLookUpEditUser.Properties.ValueMember = "Id";
            searchLookUpEditUser.Properties.DisplayMember = "Name";
            searchLookUpEditUser.DataBindings.Add("EditValue", _item, nameof(_item.UserId));

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

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            ProcessTabKey(true);
            GetData();

            if (Validation() == false)
            {
                MessageBox.Show("Не заполнены все необходимые поля");
                return;
            }

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

        private void GetData()
        {
            var procedureLabels = layoutControlGroup1.Items.Where(x => x.GetType() == typeof(LayoutControlItem) && x.Name.Contains("layoutItemProcedure"));
            var checkBoxesChecked = procedureLabels.Select(x => (CheckEdit)(x as LayoutControlItem).Control).Where(x => x.Checked);
            var items = checkBoxesChecked.Select(x => (ProcedureBl)x.Tag);
            _item.Record2Procedure = items.Select(x => new Record2ProcedureDto(x, _item.Id));
        }

        private bool Validation()
        {
            if (_item.UserId == 0) return false;

            return true;
        }
    }
}
