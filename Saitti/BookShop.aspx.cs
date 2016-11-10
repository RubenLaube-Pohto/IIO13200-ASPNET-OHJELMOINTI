using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookShop : System.Web.UI.Page
{
    protected static BookShopEntities ctx;
    protected static bool isCustomerSelected;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ctx = new BookShopEntities();
            FillControls();
        }
    }

    #region METHODS
    protected void ShowCustomers()
    {
        gvCustomers.DataSource = ctx.Customers.ToList();
        gvCustomers.DataBind();
        int i = ctx.Customers.Count();
        lblMessage.Text = string.Format("Found {0} customers.", i);
    }

    protected void ShowBooks()
    {
        gvBooks.DataSource = ctx.Books.ToList();
        gvBooks.DataBind();
        int i = ctx.Books.Count();
        lblMessage.Text = string.Format("Found {0} books.", i);
    }

    protected void FillControls()
    {
        //var returnValue = ctx.Customers;
        //var returnValue = from c in ctx.Customers orderby c.lastname select c;
        var returnValue = ctx.Customers.OrderBy(c => c.lastname);
        ddlCustomers.DataSource = returnValue.ToList();
        ddlCustomers.DataTextField = "lastname";
        ddlCustomers.DataValueField = "id";
        ddlCustomers.DataBind();
        // add empty item in front
        ddlCustomers.Items.Insert(0, string.Empty);
        // for crud
        txtFirstName.Text = string.Empty;
        txtLastName.Text = string.Empty;
        SetButtons();
    }

    protected void SetButtons()
    {
        // control usability of buttons
        btnNew.Enabled = !isCustomerSelected;
        btnSave.Enabled = isCustomerSelected;
        btnDelete.Enabled = isCustomerSelected;
    }

    protected void ShowCustomersOrders(Customer c)
    {
        ltResult.Text = string.Format("Customer {0} {1} has {2} order(s).", c.firstname, c.lastname, c.Orders.Count);

        foreach (var o in c.Orders)
        {
            ltResult.Text += string.Format("<br>- order {0} holding {1} book(s):", o.odate.ToShortDateString(), o.Orderitems.Count);
            foreach (var i in o.Orderitems)
            {
                ltResult.Text += string.Format("<br>-- book {0} by {1}, {2} item(s)", i.Book.name, i.Book.author, i.count);
            }
        }
    }
    #endregion

    protected void btnGetCustomers_Click(object sender, EventArgs e)
    {
        ShowCustomers();
    }

    protected void btnGetBooks_Click(object sender, EventArgs e)
    {
        ShowBooks();
    }

    protected void ddlCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCustomers.SelectedIndex > 0)
        {
            int id = int.Parse(ddlCustomers.SelectedValue);
            //var returnValue = from c in ctx.Customers where c.id == id select c;
            var returnValue = ctx.Customers.Where(c => c.id == id);
            Customer customer = returnValue.FirstOrDefault();
            ShowCustomersOrders(customer);
            isCustomerSelected = true;
            txtFirstName.Text = customer.firstname;
            txtLastName.Text = customer.lastname;
            SetButtons();
        }
        else
        {
            ltResult.Text = string.Empty;
            isCustomerSelected = false;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            SetButtons();
        }
    }

    protected void btnNew_Click(object sender, EventArgs e)
    {
        // create a new customer to context if one with the same name doesn't exist
        bool isThere = ctx.Customers.Any(c => c.firstname.Contains(txtFirstName.Text) && c.lastname.Contains(txtLastName.Text));
        if (isThere)
        {
            lblMessage.Text = string.Format("Customer {0} {1} already exists.", txtFirstName.Text, txtLastName.Text);
        }
        else
        {
            Customer customer = new Customer();
            customer.firstname = txtFirstName.Text;
            customer.lastname = txtLastName.Text;
            ctx.Customers.Add(customer);
            ctx.SaveChanges();
            lblMessage.Text = string.Format("New customer {0}: {1} {2} created successfully",
                customer.id,
                customer.firstname,
                customer.lastname);
            FillControls();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        // get selected customer id
        int id = int.Parse(ddlCustomers.SelectedValue);
        if (id > 0)
        {
            var ret = ctx.Customers.Where(c => c.id == id);
            Customer customer = ret.FirstOrDefault();
            if (customer != null)
            {
                if (customer.firstname != txtFirstName.Text)
                    customer.firstname = txtFirstName.Text;
                if (customer.lastname != txtLastName.Text)
                    customer.lastname = txtLastName.Text;
                ctx.SaveChanges();
                FillControls();
            }
        }
    }
}