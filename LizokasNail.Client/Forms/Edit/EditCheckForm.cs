using LisokasNail.Models;
using LizokasNail.Client.Di;
using System;
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

            searchLookUpEditRecord.Properties.DataSource = _recordRepo.GetWithoutCheck();
            searchLookUpEditRecord.Properties.ValueMember = "Id";
            searchLookUpEditRecord.Properties.DisplayMember = "DisplayName";
            searchLookUpEditRecord.DataBindings.Add("EditValue", _item, nameof(_item.RecordId));

            searchLookUpEditBase.Properties.DataSource = _baseRepo.Get();
            searchLookUpEditBase.Properties.ValueMember = "Id";
            searchLookUpEditBase.Properties.DisplayMember = "Name";
            searchLookUpEditBase.DataBindings.Add("EditValue", _item, nameof(_item.BaseId), true, DataSourceUpdateMode.OnPropertyChanged);

            searchLookUpEditColor.Properties.DataSource = _colorRepo.Get();
            searchLookUpEditColor.Properties.ValueMember = "Id";
            searchLookUpEditColor.Properties.DisplayMember = "Name";
            searchLookUpEditColor.DataBindings.Add("EditValue", _item, nameof(_item.ColorId), true, DataSourceUpdateMode.OnPropertyChanged);

            searchLookUpEditTop.Properties.DataSource = _topRepo.Get();
            searchLookUpEditTop.Properties.ValueMember = "Id";
            searchLookUpEditTop.Properties.DisplayMember = "Name";
            searchLookUpEditTop.DataBindings.Add("EditValue", _item, nameof(_item.TopId), true, DataSourceUpdateMode.OnPropertyChanged);

            gridControlDesign.DataSource = _item.Designs; //_designRepo.Get();//
            repositoryItemSearchLookUpEditDesign.DataSource = _designRepo.Get();
        }

        private bool Validation()
        {
            //var record = _repo.GetByRecord(_item.RecordId);
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
