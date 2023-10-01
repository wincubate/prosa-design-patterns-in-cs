namespace Wincubate.AdapterExamples.Client;

public class AreaClient
{
    private readonly IAreaCalculator _calculator;

    public AreaClient( IAreaCalculator calculator )
    {
        _calculator = calculator;
    }

    public double GetArea( Rectangle rectangle ) => _calculator.Compute(rectangle);
}
