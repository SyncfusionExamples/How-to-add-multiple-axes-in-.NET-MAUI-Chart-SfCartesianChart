using System.Collections.ObjectModel;

namespace SampleDemo
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ViewModel()
        {
            DateTime date = new DateTime(2022, 01, 01);
            Data = new ObservableCollection<Model>();
           
            Data.Add(new Model(date, 15000, 58));
            Data.Add(new Model(date.AddMonths(1), 18000, 83));
            Data.Add(new Model(date.AddMonths(2), 13000, 35));
            Data.Add(new Model(date.AddMonths(3), 17000, 73));
            Data.Add(new Model(date.AddMonths(4), 22000, 95));
            Data.Add(new Model(date.AddMonths(5), 12000, 65));
        }
    }
}
