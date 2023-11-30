using System;

public class Product
{
    private string _productName;
    private string _productId;
    private decimal _productPrice;
    private int _productQuantity;

    public Product(string productName, string productId, decimal productPrice, int productQuantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }
    public void SetProductName (string productName)
    {
        _productName = productName;
    }
    public string GetProductName()
    {
        return _productName;
    }
    public void SetProductId (string productId)
    {
        _productId = productId;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public void SetProductPrice(decimal productPrice)
    {
        _productPrice = productPrice;
    }
    public decimal GetProductPrice()
    {
        return _productPrice;
    }
    public void SetProductQuantity(int productQuantity)
    {
        _productQuantity = productQuantity;
    }
    public int GetProductQuantity()
    {
        return _productQuantity;
    }
    public decimal GetTotalPrice()
    {
        return _productPrice * _productQuantity;
    }
}