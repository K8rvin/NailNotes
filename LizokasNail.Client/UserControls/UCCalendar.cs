using LisokasNail.Models;
using LizokasNail.Client.Di;
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
        private List<RecordBl> _items = new List<RecordBl>();
        private List<Tuple<DateTime, DateTime>> Periods = new List<Tuple<DateTime, DateTime>>();

        public UCCalendar()
        {
            InitializeComponent();
            _repo = Di.Container.Instance.Resolve<IRecordRepo>();

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
            gridControlYesterday.DataSource = _items.Where(x=>x.RecordDate >= Periods[0].Item1 && x.RecordDate <= Periods[0].Item2);
            //gridViewYesterday.BestFitColumns();
            gridControlCurrentDate.DataSource = _items.Where(x => x.RecordDate >= Periods[1].Item1 && x.RecordDate <= Periods[1].Item2);
            //gridViewCurrentDate.BestFitColumns();
            gridControlTomorrow.DataSource = _items.Where(x => x.RecordDate >= Periods[2].Item1 && x.RecordDate <= Periods[2].Item2);
            //gridViewTomorrow.BestFitColumns();
        }
    }
}
