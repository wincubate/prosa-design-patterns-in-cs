namespace Wincubate.DecoratorExamples;

public class Rental : VehicleDecorator
{
    public bool IsAvailableForRent { get; private set; }

    public IEnumerable<string> RentalHistory => _rentalHistory;
    private readonly List<string> _rentalHistory;

    public override string ToString() =>
        base.ToString() +
        $"{Environment.NewLine}Is{(IsAvailableForRent == false ? " not" : "")} available for rent." +
        $"{Environment.NewLine}{string.Join(Environment.NewLine, _rentalHistory)}{Environment.NewLine}";

    public Rental(IVehicle decoratee, bool isAvailableForRent = true) : base(decoratee)
    {
        IsAvailableForRent = isAvailableForRent;

        _rentalHistory = new List<string>();
    }

    public void Rent(string customer)
    {
        if (IsAvailableForRent)
        {
            _rentalHistory.Add($"{DateTime.Now}: Rented by {customer}");
            IsAvailableForRent = false;
        }
    }

    public void Return()
    {
        _rentalHistory.Add($"{DateTime.Now}: Returned");
        IsAvailableForRent = true;
    }
}