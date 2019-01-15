using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartItem
/// </summary>
public class CartItem
{
    private string title;
    private double price;

    public CartItem(string title, double price)
    {
        this.Title = title;
        this.Price = price;
    }

    public double Price
    {
        get
        {
            return price;
        }

        set
        {
            price = value;
        }
    }

    public string Title
    {
        get
        {
            return title;
        }

        set
        {
            title = value;
        }
    }

    public string getInfo()
    {
        return String.Format("{0} - {1}", Title, Price);
    }
}