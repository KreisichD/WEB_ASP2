using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "Cart";
        productsList.Items.Clear();

        if (Session["cartItems"] == null)
        {
            productsList.Visible = false;
            emptyLabel.Visible = true;
            deliveryRBL.Visible = false;
            sumLabel.Visible = false;
            confirmLabel.Visible = false;
        }
        else
        {
            productsList.Visible = true;
            emptyLabel.Visible = false;
            deliveryRBL.Visible = true;
            sumLabel.Visible = true;
            confirmLabel.Visible = true;

            double sum = 0;

            foreach(CartItem item in (HashSet<CartItem>)Session["cartItems"])
            {
                productsList.Items.Add(item.getInfo());
                sum += item.Price;
            }

            if (deliveryRBL.Items[1].Selected)
                sum += 6.5;

            if (deliveryRBL.Items[2].Selected)
                sum += 15.0;

            sumLabel.Text = String.Format("Suma: {0}", sum);
        }
    }
}