
namespace SampleDemo
{
    public class Model
    {
        public DateTime  Months { get; set; }
        public double Sales { get; set; }
        public double Target { get; set; }

        public Model(DateTime months, double sales, double target)
        {
            Months = months;
            Sales = sales;
            Target = target;
        }
    }
}
