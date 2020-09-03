using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LisokasNail.Models
{
    public class MonthReportViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion


        public MonthReportViewModel()
        {
        }

        public List<MonthReportBl> Items { get; set; } = new List<MonthReportBl>();
        public double TotalCost => Items.Any() ? Items.Sum(x => x.CostSumm) : 0;
        public double TotalPrice => Items.Any() ? Items.Sum(x => x.PriceSumm) : 0;
        public double TotalIncoming => TotalPrice - TotalCost;
    }
}
