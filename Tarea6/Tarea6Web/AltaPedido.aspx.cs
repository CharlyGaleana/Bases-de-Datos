using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class AltaPedido : System.Web.UI.Page
{
    //Variables de la clase 
    DataTable dt;
    GestorBD.GestorBD GestorBD;
    Comunes objeto = new Comunes();
   //Data Sets
    DataSet dsArticulo=new DataSet();
    String cadSql;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Recuperar el gestor
            GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
            //LLenar la ddl de Artículos
            cadSql = "select * from PCArtículos";
            GestorBD.consBD(cadSql, dsArticulo, "Artículo");
            objeto.cargaDDL(Articulos, dsArticulo, "Artículo", "Nombre");
            Session["DSArticulo"] = dsArticulo;
            //
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Nombre", typeof(string)));
            dt.Columns.Add(new DataColumn("Precio", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Cantidad", typeof(Int16)));
            dt.Columns.Add(new DataColumn("Monto Total", typeof(Int32)));
        }
    }

    protected void Articulo_Click(object sender, EventArgs e)
    {
        int id; String Nombre; int Precio; int cantidad; int montoTotal;
        DataRow dr = dt.NewRow();
    }
}