using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Client.Forms.Edit;
using LizokasNail.Client.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Unity;


namespace LizokasNail.Client.UserControls
{
    public partial class UCCalendar : UserControl
    {
        private readonly IRecordRepo _repo;
        private readonly ICheckRepo _checkRepo;
        private List<RecordBl> _items = new List<RecordBl>();
        private List<Tuple<DateTime, DateTime>> Periods = new List<Tuple<DateTime, DateTime>>();

        public UCCalendar()
        {
            InitializeComponent();
            _repo = Di.Container.Instance.Resolve<IRecordRepo>();
            _checkRepo = Di.Container.Instance.Resolve<ICheckRepo>();

            var today = DateTime.Today;
            Periods = new List<Tuple<DateTime, DateTime>>() 
            { 
                new Tuple<DateTime, DateTime>(today.AddDays(-1), today),
                new Tuple<DateTime, DateTime>(today, today.AddDays(1)),
                new Tuple<DateTime, DateTime>(today.AddDays(1), today.AddDays(2)),
            };
            gridViewYesterday.ViewCaption = today.AddDays(-1).ToLongDateString();
            gridViewCurrentDate.ViewCaption = today.ToLongDateString();
            gridViewTomorrow.ViewCaption = today.AddDays(1).ToLongDateString();
        }

        private void RefreshGrid() => LoadingBar.Instance.ShowLoading(ParentForm, GetData, SettingsData);

        public void Init()
        {
            RefreshGrid();
        }

        private void UCCalendar_Load(object sender, System.EventArgs e)
        {
            RefreshGrid();
        }

        private void GetData()
        {
            _items = _repo.GetByPeriod(Periods.First().Item1, Periods.Last().Item2);
        }

        private void SettingsData()
        {
            gridControlYesterday.DataSource = _items.Where(x=>x.RecordDate >= Periods[0].Item1 && x.RecordDate < Periods[0].Item2);
            gridControlCurrentDate.DataSource = _items.Where(x => x.RecordDate >= Periods[1].Item1 && x.RecordDate < Periods[1].Item2);
            gridControlTomorrow.DataSource = _items.Where(x => x.RecordDate >= Periods[2].Item1 && x.RecordDate < Periods[2].Item2);
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)                 
            {
                RecordBl record = (RecordBl)view.GetRow(info.RowHandle);
                if (info.Column.FieldName == "RecordDate" || info.Column.FieldName == "UserName")
                {                    
                    var form = new EditRecordForm(_repo, record);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        RefreshGrid();
                        form.Dispose();
                    }
                }
                else if (info.Column.FieldName == "Check.Price")
                {
                    var check = _checkRepo.Get(record.Check.Id);
                    if (check == null)
                    {
                        check = new CheckBl() { RecordId = record.Id, Record = record };
                    }
                    var form = new EditCheckForm(_checkRepo, check);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        RefreshGrid();
                        form.Dispose();
                    }
                }
            }
        }
    }
}
