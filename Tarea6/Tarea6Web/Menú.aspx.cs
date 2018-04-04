using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Menú : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["tipo"].ToString() == "Ger")
            {
                Button2.Enabled = false;
                Button2.Visible = false;
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Server.Transfer("datosClientesPedidos.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("altaPedido.aspx");
    }
}