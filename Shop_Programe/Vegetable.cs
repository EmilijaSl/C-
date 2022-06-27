namespace Shop_Programe
{
    public class Vegetable : Product
    {
        public double Fibers { get; set; }


        public Vegetable() { }
        public Vegetable(string name, decimal price, int barCode, double weight, double fibers)
        {
            Name = name;
            Price = price;
            BarCode = barCode;
            Weight = weight;
            Fibers = fibers;

        }

    }
}
