using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AltaPedido : System.Web.UI.Page
{
    GestorBD.GestorBD GestorBD;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
        }
    }

    protected void Articulo_Click(object sender, EventArgs e)
    {
        Detalles.Rows.Add
    }
}