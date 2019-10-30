namespace DemoApp.Services
{
    public class BaseCalculator
    {
        public int Id { get; set; }

        public virtual double GetANumber()
        {
            return 100 / 2 * 5;
        }
    }
}