using System.Collections.Generic;
using System.Linq;

namespace ExerciseOopHierarchy;

public class Order
{
    private List<MenuItem> _items;

    public IReadOnlyCollection<MenuItem> Items => this._items.AsReadOnly();

    public Order()
    {
        this._items = new List<MenuItem>();
    }

    public void AddItem(MenuItem item)
    {
        _items.Add(item);
    }

    public decimal GetTotal()
    {
        return this._items.Select(i => i.Price).Sum();
    }
}
