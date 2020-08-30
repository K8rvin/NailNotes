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
    public partial class UCSchedule : UserControl
    {
        private readonly IRecordRepo _repo;
        private readonly ICheckRepo _checkRepo;
        private List<RecordBl> _items = new List<RecordBl>();
        public List<Tuple<DateTime, DateTime>> Periods = new List<Tuple<DateTime, DateTime>>();

        public UCSchedule()
        {
            InitializeComponent();
            _repo = Di.Container.Instance.Resolve<IRecordRepo>();
            _checkRepo = Di.Container.Instance.Resolve<ICheckRepo>();

            DateTime startOfWeek = GetMonday(DateTime.Today);
            InitPeriods(startOfWeek);
        }

        private void InitPeriods(DateTime startOfWeek)
        {
            Periods = new List<Tuple<DateTime, DateTime>>()
            {
                new Tuple<DateTime, DateTime>(startOfWeek, startOfWeek.AddDays(1)),
                new Tuple<DateTime, DateTime>(startOfWeek.AddDays(1), startOfWeek.AddDays(2)),
                new Tuple<DateTime, DateTime>(startOfWeek.AddDays(2), startOfWeek.AddDays(3)),
                new Tuple<DateTime, DateTime>(startOfWeek.AddDays(3), startOfWeek.AddDays(4)),
                new Tuple<DateTime, DateTime>(startOfWeek.AddDays(4), startOfWeek.AddDays(5)),
                new Tuple<DateTime, DateTime>(startOfWeek.AddDays(5), startOfWeek.AddDays(6)),
            };
            gridViewDay1.ViewCaption = startOfWeek.ToLongDateString() + " Пн";
            gridViewDay2.ViewCaption = startOfWeek.AddDays(1).ToLongDateString() + " Вт";
            gridViewDay3.ViewCaption = startOfWeek.AddDays(2).ToLongDateString() + " Ср";
            gridViewDay4.ViewCaption = startOfWeek.AddDays(3).ToLongDateString() + " Чт";
            gridViewDay5.ViewCaption = startOfWeek.AddDays(4).ToLongDateString() + " Пт";
            gridViewDay6.ViewCaption = startOfWeek.AddDays(5).ToLongDateString() + " Сб";
        }

        private void RefreshGrid() => LoadingBar.Instance.ShowLoading(ParentForm, GetData, SettingsData);

        public void Init()
        {
            RefreshGrid();
        }

        public void Init(DateTime date)
        {
            DateTime startOfWeek = GetMonday(date);
            InitPeriods(startOfWeek);
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
            gridControlDay1.DataSource = _items.Where(x => x.RecordDate >= Periods[0].Item1 && x.RecordDate <= Periods[0].Item2);
            gridControlDay2.DataSource = _items.Where(x => x.RecordDate >= Periods[1].Item1 && x.RecordDate <= Periods[1].Item2);
            gridControlDay3.DataSource = _items.Where(x => x.RecordDate >= Periods[2].Item1 && x.RecordDate <= Periods[2].Item2);
            gridControlDay4.DataSource = _items.Where(x => x.RecordDate >= Periods[3].Item1 && x.RecordDate <= Periods[3].Item2);
            gridControlDay5.DataSource = _items.Where(x => x.RecordDate >= Periods[4].Item1 && x.RecordDate <= Periods[4].Item2);
            gridControlDay6.DataSource = _items.Where(x => x.RecordDate >= Periods[5].Item1 && x.RecordDate <= Periods[5].Item2);
        }

        /// <summary>
        /// Понедельник недели
        /// </summary>
        /// <returns></returns>
        private static DateTime GetMonday(DateTime date)
        {
            while (date.DayOfWeek != DayOfWeek.Monday)
                date = date.AddDays(-1);
            return date;
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                RecordBl record = (RecordBl)view.GetRow(info.RowHandle);
                if (info.Column.FieldName == nameof(record.RecordDate) || info.Column.FieldName == nameof(record.UserName))
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
