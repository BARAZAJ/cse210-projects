using System.Collections.Generic;
using System.Text;

namespace OnlineOrderingSystem
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _products = new List<Product>();
            _customer = customer;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double GetTotalCost()
        {
            double totalCost = 0;
            foreach (var product in _products)
            {
                totalCost += product.GetTotalCost();
            }

            totalCost += _customer.IsInUSA() ? 5 : 35;
            return totalCost;
        }

        public string GetPackingLabel()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var product in _products)
            {
                sb.AppendLine($"{product.GetName()} ({product.GetProductId()})");
            }
            return sb.ToString();
        }

        public string GetShippingLabel()
        {
            return $"{_customer.GetName()}\n{_customer.GetAddress()}";
        }
    }
}



