using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ListaPedidos : System.Web.UI.Page {

    //Variables de la clase.
    DataSet DSGeneral = new DataSet(), DSPedidos = new DataSet();
    DataSet DSArtículos = new DataSet(), DSPagos = new DataSet();
    DataSet DSPedido = new DataSet();
    DataRow fila;
    GestorBD.GestorBD GestorBD;       //Para manejar la BD.
    Comunes objComun = new Comunes();     //Para manejar las rutinas de uso común.
    String cadSql, rfc;

    protected void Page_Load(object sender, EventArgs e) {

        if (!IsPostBack) {
            //Recupera objetos de Session.
            GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
            rfc = Session["rfc"].ToString();

            //Lee los datos del cliente.

            //Lee los datos del cliente
            cadSql = "select * from pcusuarios u, pcclientes c where u.rfc = '" 
                + rfc + "' and u.rfc = c.rfc";

            GestorBD.consBD(cadSql, DSGeneral, "Cliente");
            fila = DSGeneral.Tables["Cliente"].Rows[0];
            tblCliente.Rows[1].Cells[0].Text = fila["RFC"].ToString();
            tblCliente.Rows[1].Cells[1].Text = fila["Nombre"].ToString();
            tblCliente.Rows[1].Cells[2].Text = fila["Domicilio"].ToString();

            //Lee sus pedidos y carga los folios en el ddl de pedidos.
            cadSql = "select * from pcpedidos where rfcc = '" + rfc + "'";
            GestorBD.consBD(cadSql, DSPedidos, "Pedidos");
            objComun.cargaDDL(ddlPedidos, DSPedidos, "Pedidos", "foliop");
            Session["DSPedidos"] = DSPedidos;

        }
    }

    //muestra los datos relacionados en el ddl
    protected void ddlPedidos_SelectedIndexChanged(object sender, EventArgs e) {
        cadSql = "select * from pcpedidos where foliop = " + Convert.ToInt16(ddlPedidos.SelectedValue.ToString());
        GestorBD = (GestorBD.GestorBD) Session["GestorBD"];
        GestorBD.consBD(cadSql, DSPedido, "Pedido");

        fila = DSPedido.Tables["Pedido"].Rows[0];
        tblPedidos.Rows[1].Cells[0].Text = fila["foliop"].ToString();
        tblPedidos.Rows[1].Cells[1].Text = fila["fechaped"].ToString();
        tblPedidos.Rows[1].Cells[2].Text = fila["monto"].ToString();
        tblPedidos.Rows[1].Cells[3].Text = fila["saldocli"].ToString();
        tblPedidos.Rows[1].Cells[4].Text = fila["saldofacs"].ToString();

        //muestra los artículos del pedido
        cadSql = "select Nombre, CantPed, CantEnt from PCDetalle d, PCArtículos a "
            + "where folioP = " + ddlPedidos.Text + " and d.idart = a.idart";
        GestorBD.consBD(cadSql, DSArtículos, "Artículos");
        GrdArticulos.DataSource = DSArtículos.Tables["Artículos"];
        GrdArticulos.DataBind();

        //muestra los pagos realizados al pedido seleccionado
        //Muestra los pagos realizados para el pedido seleccionado.
        cadSql = "select * from PCPagos where FolioP=" + ddlPedidos.Text;
        GestorBD.consBD(cadSql, DSPagos, "Pagos");
        GrdPagos.DataSource = DSPagos.Tables["Pagos"];  //Muestra resultados.
        GrdPagos.DataBind();

    }

    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e) {

    }
}