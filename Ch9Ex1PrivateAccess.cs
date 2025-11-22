
namespace Ch9Ex1PrivateAccess
{
    class Product
    {
        private int _SKU;
        private string _ProductName;
        private string _ProductDescription;
        private int _Quantity;
        //constructors
        public Product()
        {
            _SKU = 0;
            _ProductName = string.Empty;
            _ProductDescription = string.Empty; 
            _Quantity = 0;
        }
        public Product(int SKU, string productName, string productDescription, int quantity)
        {
            _SKU = SKU;
            _ProductName = productName;
            _ProductDescription = productDescription;
            _Quantity = quantity;
        }
        //get and set methods
        public int GetSku()
        {
            return _SKU;
        }
        public void SetSku(int SKU)
        {
            _SKU = SKU;
        }
        public string GetProductName()
        {
            return _ProductName;
        }
        public void SetProductName(string productName)
        {
            _ProductName= productName;
        }
        public string GetProductDescription()
        {
            return _ProductDescription;
        }
        public void SetProductDescription(string productDescription)
        {
            _ProductDescription= productDescription;
        }
        public int GetQuantity()
        {
            return _Quantity;
        }
        public void SetQuantity(int quantity)
        {
            _Quantity = quantity;
        }
        //print method
        public void Print()
        {
            Console.WriteLine($"SKU:{_SKU}\n" +
                $"Product:{_ProductName}\n" +
                $"Description:\n{_ProductDescription}\n" +
                $"Qty: {_Quantity}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.SetSku(100);
            product.SetProductName("Foo");
            product.SetProductDescription("Bar");
            product.SetQuantity(10);
            Console.WriteLine($"SKU:{product.GetSku()}\n" +
                $"Product:{product.GetProductName()}\n" +
                $"Description:\n{product.GetProductDescription()}\n" +
                $"Qty: {product.GetQuantity()}\n\n");

            Product product2 = new Product(200, "Bar", "Foo", 10);
            product2.Print();



        }
    }
}
