
namespace VendingMachine.Entities

{
    public class BaseEntityItems
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
    }
    public class Item1 : BaseEntityItems { }

    public class Item2 : BaseEntityItems { }

    public class Item3 : BaseEntityItems { }


}
