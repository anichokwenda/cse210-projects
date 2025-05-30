using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.CalculateTotalCost();
        }

        decimal shippingCost = customer.LivesInUSA() ? 5 : 35;
        totalPrice += shippingCost;

        return totalPrice;
    }
    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in products)
        {
            label += $"{product.GetName()} ({product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddress().ToString()}";
    }
}

