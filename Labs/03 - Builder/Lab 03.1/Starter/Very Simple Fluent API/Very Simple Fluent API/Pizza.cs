using System.Text;

namespace Wincubate.BuilderLabs;

public class Pizza
{
    public CrustKind Crust { get; set; }
    public bool HasSauce { get; set; }
    public IEnumerable<ToppingKind> Toppings { get; set; }
    public CheeseKind? Cheese { get; set; }
    public bool Oregano { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.Append($"{Crust} pizza {(HasSauce ? "with" : "without")} sauce with ");
        sb.AppendLine($"{Cheese?.ToString().ToLower() ?? "no"} cheese. Toppings: ");

        foreach (ToppingKind topping in Toppings)
        {
            sb.AppendLine($"\t{topping}");
        }

        if (Oregano)
        {
            sb.AppendLine("with oregano on top");
        }

        return sb.ToString();
    }

    public Pizza()
    {
        Toppings = new List<ToppingKind>();
    }
}