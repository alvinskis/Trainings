namespace DemoApp.Services
{
    public class CalculationServiceThree : BaseCalculator
    {
        public override double GetANumber()
        {
            return base.GetANumber() - 100 / 2 * 5;
        }
    }
}