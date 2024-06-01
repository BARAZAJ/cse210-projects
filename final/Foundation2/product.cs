namespace EventPlanning
{
    public class Product
    {
        private string _name;
        private double _price;
        private int _quantity;

        public Product(string name, double price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        public double GetTotalPrice()
        {
            return _price * _quantity;
        }

        public string GetProductDetails()
        {
            return $"Product: {_name}\nPrice: {_price:C}\nQuantity: {_quantity}\nTotal: {GetTotalPrice():C}";
        }
    }
}
