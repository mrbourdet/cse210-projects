using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public void DisplayCostOfOrder()
    {
        decimal totalPrice = 0;
        foreach (var product in _products)
        {
            totalPrice += product.GetTotalPrice();
        }
        // Add shipping cost
        if (_customer.LivesInUS())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }
        Console.WriteLine(totalPrice);
    }
    public void DisplayPackingLabel()
    {
        string label = "";
        foreach (var product in _products)
        {
            label += $"{product.GetProductName()} (ID: {product.GetProductId()})  Price: ${product.GetProductPrice():0.##}  Qty: {product.GetProductQuantity()}  Ext. Price: ${product.GetTotalPrice():0.##}\n";
        }
        Console.WriteLine(label);
    } 
}