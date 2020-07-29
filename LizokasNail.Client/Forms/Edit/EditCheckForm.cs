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
    public partial class EditCheckForm : Form
    {
        private readonly ICheckRepo _repo;
        private readonly IRecordRepo _recordRepo;
        private readonly IBaseRepo _baseRepo;
        private readonly IColorRepo _colorRepo;
        private readonly ITopRepo _topRepo;
        private readonly IDesignRepo _designRepo;
        private CheckBl _item;

        public EditCheckForm(ICheckRepo repo, CheckBl item = null)
        {
            InitializeComponent();
            _repo = repo;
            _recordRepo = Di.Container.Instance.Resolve<IRecordRepo>();
            _baseRepo = Di.Container.Instance.Resolve<IBaseRepo>();
            _colorRepo = Di.Container.Instance.Resolve<IColorRepo>();
            _topRepo = Di.Container.Instance.Resolve<ITopRepo>();
            _designRepo = Di.Container.Instance.Resolve<IDesignRepo>();
            _item = item;

            if (item != null)
            {
                Text = "Редактирование расчета";
            }
            else
            {
                Text = "Новый расчет";
                _item = new CheckBl();
            }

            numericUpDownPrice.DataBindings.Add("Value", _item, nameof(_item.Price));
            textEditComment.DataBindings.Add("EditValue", _item, nameof(_item.Comment));

            var records = _recordRepo.GetWithoutCheck();
            if (_item.Record != null && !records.Contains(_item.Record))
            {
                records.Add(_item.Record);
            }
            searchLookUpEditRecord.Properties.DataSource = records;
            searchLookUpEditRecord.Properties.ValueMember = "Id";
            searchLookUpEditRecord.Properties.DisplayMember = "DisplayName";
            searchLookUpEditRecord.DataBindings.Add("EditValue", _item, nameof(_item.RecordId));

            searchLookUpEditColor.Properties.DataSource = _colorRepo.Get();
            searchLookUpEditColor.Properties.ValueMember = "Id";
            searchLookUpEditColor.Properties.DisplayMember = "Name";
            //searchLookUpEditColor.DataBindings.Add("EditValue", _item, nameof(_item.ColorId), true, DataSourceUpdateMode.OnPropertyChanged);

            searchLookUpEditTop.Properties.DataSource = _topRepo.Get();
            searchLookUpEditTop.Properties.ValueMember = "Id";
            searchLookUpEditTop.Properties.DisplayMember = "Name";
            //searchLookUpEditTop.DataBindings.Add("EditValue", _item, nameof(_item.TopId), true, DataSourceUpdateMode.OnPropertyChanged);


            gridControlDesign.DataSource = _item.Designs;
            repositoryItemSearchLookUpEditDesign.DataSource = _designRepo.Get();

            SetBases();
        }

        private void SetBases()
        {
            if (_item.Check2Base?.Any() == true)
            {
                foreach (var item in _item.Check2Base)
                {
                    CreateBaseLabel(new BaseBl(item));
                }
            }
        }

        private bool Validation()
        {
            if (_item.RecordId == 0) return false;
            
            return true;
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            GetBases();

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

        private void GetBases()
        {
            var baseLabels = layoutControlGroup1.Items.Where(x => x.Name.Contains("simpleLabelBase"));
            List<BaseBl>items = baseLabels.Select(x => (BaseBl)x.Tag).ToList();
            _item.Check2Base = items.Select(x => new Check2BaseDto(x, _item.Id));
        }

        private void simpleButtonAddBase_Click(object sender, EventArgs e)
        {
            var selectBaseForm = new SelectBaseForm(_baseRepo);
            if (selectBaseForm.ShowDialog() == DialogResult.OK)
            {
                CreateBaseLabel(selectBaseForm._item);
            }
        }

        private void CreateBaseLabel(BaseBl item)
        {
            layoutControl1.BeginUpdate();
            try
            {
                // Create a layout item that will display a new base                
                SimpleLabelItem simpleLabel = new SimpleLabelItem();
                simpleLabel.Parent = layoutControlGroup1;
                simpleLabel.Name = "simpleLabelBase" + item.Id;
                simpleLabel.Text = $"{item.Name} ({item.Comment})";
                simpleLabel.Tag = item;
                //simpleLabel.OptionsToolTip.ToolTip = $"{item.Name} ({item.Comment})";
                //simpleLabel.OptionsToolTip.ImmediateToolTip = true;
                simpleLabel.DoubleClick += new System.EventHandler(this.baseLable_DoubleClick);
                simpleLabel.Move(layoutControlItemButtonBase, InsertType.Top);
            }
            finally
            {
                // Unlock and update the layout control.
                layoutControl1.EndUpdate();
            }
        }

        private void baseLable_DoubleClick(object sender, EventArgs e)
        {
            if (sender is SimpleLabelItem simpleLabelItem)
            {
                simpleLabelItem.Dispose();
            }
        }
    }
}
