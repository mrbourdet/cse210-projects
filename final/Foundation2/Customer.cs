using System;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _customerAddress = address;

    }
    public void SetCustomerName(string customerNme)
    {
        _customerName = customerNme;
    }
    public string GetCustomerName ()
    {
        return _customerName;
    }
    public void DisplayShippingLabel()
    {
        //const string NewLine = "\n";
        Console.WriteLine($"{_customerName}\n{_customerAddress.GetFullAddress()}");
    } 
    public bool LivesInUS()
    {
        return _customerAddress.LivesInUSA();
    }
}