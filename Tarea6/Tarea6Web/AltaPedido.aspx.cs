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
    //Variables de la dataTable 
    DataTable dt;
    DataRow dr;
    DataColumn dc;
    DataView dv;
    //Gestor y Comunes
    GestorBD.GestorBD GestorBD;
    Comunes objeto = new Comunes();
   //Data Sets
    DataSet dsArticulo=new DataSet();
    DataSet dsGeneral = new DataSet();
    DataSet dsUsuarios = new DataSet();
    String cadSql;
    private void crearTable()
    {
        dt = new DataTable();
        //Crear las columnas
        //IdArtículo
        dc = new DataColumn();
        dc.DataType = System.Type.GetType("System.Int32");
        dc.ColumnName = "Id";
        dt.Columns.Add(dc);
        //Nombre
        dc = new DataColumn();
        dc.DataType = System.Type.GetType("System.String");
        dc.ColumnName = "Nombre";
        dt.Columns.Add(dc);
        //Precio
        dc = new DataColumn();
        dc.DataType = System.Type.GetType("System.Int32");
        dc.ColumnName = "Precio";
        dt.Columns.Add(dc);
        //Cantidad
        dc = new DataColumn();
        dc.DataType = System.Type.GetType("System.Int32");
        dc.ColumnName = "Cantidad";
        dt.Columns.Add(dc);
        //Monto Total
        dc = new DataColumn();
        dc.DataType = System.Type.GetType("System.Int32");
        dc.ColumnName = "Monto Total";
        dt.Columns.Add(dc);
        Session["dataTable"] = dt;
        GridViewArticulos.DataSource = dv;
        GridViewArticulos.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Total.Text = "0.00";
            //Recuperar el gestor
            GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
            //LLenar la ddl de Artículos
            cadSql = "select * from PCArtículos";

            GestorBD.consBD(cadSql, dsArticulo, "Artículo");
            objeto.cargaDDL(Articulos, dsArticulo, "Artículo", "Nombre");
            Session["DSArticulo"] = dsArticulo;
            crearTable();
            tblDetalles.Visible = false;
            //Si no es cliente que le de una lista de clientes para encargar
            if (Session["Tipo"].ToString() != "Cli")
            {
                Clientes.Visible = true;
                Label6.Visible = true;
                cadSql = "select * from PCUsuarios";
                GestorBD.consBD(cadSql, dsUsuarios, "Usuarios");
                objeto.cargaDDL(Clientes, dsUsuarios, "Usuarios", "RFC");
            }
        }
    }

    protected void Articulo_Click(object sender, EventArgs e)
    {
        Double total = Double.Parse(Total.Text);
        tblDetalles.Visible = false;
        //Agregar la información
        dt = (DataTable)Session["dataTable"];
        int id; String Nombre = Articulos.SelectedValue; ; Double Precio;
        int cantidad = Int32.Parse(Cantidad.Text); Double montoTotal;
        cadSql = "select * from PCArtículos where Nombre='" + Nombre + "'";
        GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
        GestorBD.consBD(cadSql, dsArticulo, "Info");
        dr = dsArticulo.Tables["Info"].Rows[0];
        id = Int32.Parse(dr["IdArt"].ToString());
        Precio = Double.Parse(dr["Precio"].ToString());
        montoTotal = cantidad * Precio;
        total = total + montoTotal;
        Total.Text = total+"";

        dr = dt.NewRow();
        dr["Id"] = id;
        dr["Nombre"] = Nombre;
        dr["Precio"] = Precio;
        dr["Cantidad"] = cantidad;
        dr["Monto Total"] = montoTotal;
        dt.Rows.Add(dr);
        dv = new DataView(dt);
        GridViewArticulos.DataSource = dv;
        GridViewArticulos.DataBind();
        Session["dataTable"] = dt;
    }

    protected void Generar_Click(object sender, EventArgs e)
    {
        GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
        dt = (DataTable)Session["dataTable"];
        //Generas el pedido
        cadSql = "select max(folioP) as MaxFolio from PcPedidos";
        GestorBD.consBD(cadSql, dsGeneral, "MaxF");
        dr = dsGeneral.Tables["MaxF"].Rows[0];
        int folioP = Int32.Parse(dr["MaxFolio"].ToString())+1;
        String fechaPed = "'" + DateTime.Now.Year.ToString() +"-"+ DateTime.Now.Month.ToString() +"-"+ DateTime.Now.Day.ToString() + "'";
        String fechaFin = null;
        Double Monto = Double.Parse(Total.Text);
        //Saldo Cli y saldo facturas es 0
        String RFCE,RFCC;
        if (Session["Tipo"].ToString() == "Cli")
        {
            RFCE = null;
            RFCC = Session["RFC"].ToString();
        }
        else
        {
            RFCE = Session["rfc"].ToString();
            RFCC = Clientes.SelectedValue;
        }
        cadSql = "insert into PCPedidos values("+folioP+",date"+fechaPed+",null,"+Monto+",0.00,0.00,'"+RFCC+"','"+RFCE+"')";
        GestorBD.altaBD(cadSql);
        tblDetalles.Rows[0].Cells[0].Text = folioP.ToString();
        tblDetalles.Rows[0].Cells[1].Text = fechaPed;
        tblDetalles.Rows[0].Cells[2].Text = "---";
        tblDetalles.Rows[0].Cells[3].Text = Monto.ToString();
        tblDetalles.Rows[0].Cells[4].Text = "0.00";
        tblDetalles.Rows[0].Cells[5].Text = "0.00";
        tblDetalles.Rows[0].Cells[6].Text = RFCC;
        tblDetalles.Rows[0].Cells[7].Text = RFCE;
        foreach (DataRow row in dt.Rows)
        {
            int idArt=Int32.Parse(row["id"].ToString());
            int cantPed = Int32.Parse(row["cantidad"].ToString());
            cadSql = "insert into PCDetalle values(" + folioP + "," + idArt + "," + cantPed + ",0)";
            GestorBD.altaBD(cadSql);
        }
        crearTable();
        tblDetalles.Visible = true;
    }
}