using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartItem
/// </summary>
public class CartItem
{
	private int Id;
	private String Name;
	private String Description;
	private double Cost;



    public CartItem()
    {
       
    }
	public CartItem(int Id, String Name, String Description, double Cost)
	{
		this.Id = Id;
		this.Name = Name;
		this.Description = Description;
		this.Cost = Cost;
	}
}