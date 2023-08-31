namespace BXRest.Core.Models
{
    public record Order(string Name, OrderDirection direction = OrderDirection.ASC);
}
