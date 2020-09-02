using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Contract.Dto;
using System;
using System.Collections.Generic;
using System.Drawing;
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

            if (DateTime.Today > _item.Record.RecordDate)
            {
                numericUpDownPrice.DataBindings.Add("Value", _item, nameof(_item.Price));
            }
            else
            {
                numericUpDownPrice.DataBindings.Add("Value", _item, nameof(_item.PriceDynamic));
            }
            textEditComment.DataBindings.Add("EditValue", _item, nameof(_item.Comment));

            var records = _recordRepo.GetWithoutCheck();
            if (_item.Record != null && !records.Any(x => x.Id == _item.RecordId))
            {
                records.Add(_item.Record);
            }
            searchLookUpEditRecord.Properties.DataSource = records;
            searchLookUpEditRecord.Properties.ValueMember = "Id";
            searchLookUpEditRecord.Properties.DisplayMember = "DisplayName";
            searchLookUpEditRecord.DataBindings.Add("EditValue", _item, nameof(_item.RecordId));

            gridControlDesign.DataSource = _item.Designs;
            repositoryItemSearchLookUpEditDesign.DataSource = _designRepo.Get();

            textEditPriceFormula.DataBindings.Add("EditValue", _item, nameof(_item.PriceFormula));

            SetData();

            textEditProcedure.Text = string.Join("; ", _item.Record.Record2Procedure.Select(x=>x.Procedure.Name));
            numericUpDownPrice.Controls[0].Enabled = false;  // Disable the arrow buttons.
        }

        private bool Validation()
        {
            if (_item.RecordId == 0) return false;

            return true;
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            if (DateTime.Today > _item.Record.RecordDate)
            {
                var res = MessageBox.Show(
                    $"Вы уверены, что хотите внести изменение в расчет? " +
                    $"\nДата записи {_item.Record.RecordDate} уже в прошлом. Могли измениться цены на дизайны/процедуры. " +
                    $"\nЗафиксированная стоимость: {_item.Price}" +
                    $"\nНовая стоимость: {_item.PriceDynamic}"
                    , "Внимание!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (res == DialogResult.Cancel)
                {
                    return;
                }
                else if (res == DialogResult.No)
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            
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
            var baseLabels = layoutControlGroup1.Items.Where(x => x.Name.Contains("simpleLabelBase"));
            List<BaseBl> items = baseLabels.Select(x => (BaseBl)x.Tag).ToList();
            _item.Check2Base = items.Select(x => new Check2BaseDto(x, _item.Id));

            var colorLabels = layoutControlGroup1.Items.Where(x => x.Name.Contains("simpleLabelColor"));
            List<ColorBl> colors = colorLabels.Select(x => (ColorBl)x.Tag).ToList();
            _item.Check2Color = colors.Select(x => new Check2ColorDto(x, _item.Id));

            var topLabels = layoutControlGroup1.Items.Where(x => x.Name.Contains("simpleLabelTop"));
            List<TopBl> tops = topLabels.Select(x => (TopBl)x.Tag).ToList();
            _item.Check2Top = tops.Select(x => new Check2TopDto(x, _item.Id));
        }

        private void SetData()
        {
            if (_item.Check2Base?.Any() == true)
            {
                foreach (var item in _item.Check2Base)
                {
                    CreateBaseLabel(new BaseBl(item));
                }
            }
            if (_item.Check2Color?.Any() == true)
            {
                foreach (var item in _item.Check2Color)
                {
                    CreateColorLabel(new ColorBl(item));
                }
            }
            if (_item.Check2Top?.Any() == true)
            {
                foreach (var item in _item.Check2Top)
                {
                    CreateTopLabel(new TopBl(item));
                }
            }
        }

        private void simpleButtonAddBase_Click(object sender, EventArgs e)
        {
            var selectBaseForm = new SelectBaseForm(_baseRepo);
            if (selectBaseForm.ShowDialog() == DialogResult.OK)
            {
                CreateBaseLabel(selectBaseForm._item);
            }
        }

        private void simpleButtonAddColor_Click(object sender, EventArgs e)
        {
            var selectColorForm = new SelectColorForm(_colorRepo);
            if (selectColorForm.ShowDialog() == DialogResult.OK)
            {
                CreateColorLabel(selectColorForm._item);
            }
        }

        private void simpleButtonAddTop_Click(object sender, EventArgs e)
        {
            var selectTopForm = new SelectTopForm(_topRepo);
            if (selectTopForm.ShowDialog() == DialogResult.OK)
            {
                CreateTopLabel(selectTopForm._item);
            }
        }

        private void simpleButtonAddDesign_Click(object sender, EventArgs e)
        {
            var selectDesignForm = new SelectDesignForm(_designRepo);
            if (selectDesignForm.ShowDialog() == DialogResult.OK)
            {
                _item.Designs.Add(selectDesignForm._item);
                _item.OnPropertyChanged(nameof(_item.PriceDynamic));
                _item.OnPropertyChanged(nameof(_item.PriceFormula));
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
                simpleLabel.DoubleClick += new System.EventHandler(this.lable_DoubleClick);
                simpleLabel.Move(layoutControlItemButtonBase, InsertType.Top);
            }
            finally
            {
                // Unlock and update the layout control.
                layoutControl1.EndUpdate();
            }
        }

        private void CreateColorLabel(ColorBl item)
        {
            layoutControl1.BeginUpdate();
            try
            {
                // Create a layout item that will display a new base                
                SimpleLabelItem simpleLabel = new SimpleLabelItem();
                simpleLabel.Parent = layoutControlGroup1;
                simpleLabel.Name = "simpleLabelColor" + item.Id;
                simpleLabel.Text = $"{item.Name} ({item.Comment})";
                simpleLabel.Tag = item;
                //simpleLabel.OptionsToolTip.ToolTip = $"{item.Name} ({item.Comment})";
                //simpleLabel.OptionsToolTip.ImmediateToolTip = true;
                simpleLabel.DoubleClick += new System.EventHandler(this.lable_DoubleClick);
                simpleLabel.Move(layoutControlItemButtonColor, InsertType.Top);
            }
            finally
            {
                // Unlock and update the layout control.
                layoutControl1.EndUpdate();
            }
        }

        private void CreateTopLabel(TopBl item)
        {
            layoutControl1.BeginUpdate();
            try
            {
                // Create a layout item that will display a new base                
                SimpleLabelItem simpleLabel = new SimpleLabelItem();
                simpleLabel.Parent = layoutControlGroup1;
                simpleLabel.Name = "simpleLabelTop" + item.Id;
                simpleLabel.Text = $"{item.Name} ({item.Comment})";
                simpleLabel.Tag = item;
                //simpleLabel.OptionsToolTip.ToolTip = $"{item.Name} ({item.Comment})";
                //simpleLabel.OptionsToolTip.ImmediateToolTip = true;
                simpleLabel.DoubleClick += new System.EventHandler(this.lable_DoubleClick);
                simpleLabel.Move(layoutControlItemButtonTop, InsertType.Top);
            }
            finally
            {
                // Unlock and update the layout control.
                layoutControl1.EndUpdate();
            }
        }

        private void lable_DoubleClick(object sender, EventArgs e)
        {
            if (sender is SimpleLabelItem simpleLabelItem)
            {
                simpleLabelItem.Dispose();
            }
        }

        private void gridViewDesign_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo info = view.CalcHitInfo(pt);

            if (info.InDataRow)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.FieldName;

                var des = (DesignBl)gridViewDesign.GetFocusedRow();
                if (des != null && colCaption == nameof(des.Id) || colCaption == nameof(des.PriceFull))
                {
                    _item.Designs.Remove(des);
                    _item.OnPropertyChanged(nameof(_item.PriceDynamic));
                    _item.OnPropertyChanged(nameof(_item.PriceFormula));
                }
            }
        }

        private void gridViewDesign_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            _item.OnPropertyChanged(nameof(_item.PriceDynamic));
            _item.OnPropertyChanged(nameof(_item.PriceFormula));
        }
    }
}
