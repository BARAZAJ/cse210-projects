namespace EventPlanning
{
    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public string GetCustomerDetails()
        {
            return $"Name: {_name}\nAddress: {_address.GetFullAddress()}";
        }
    }
}

