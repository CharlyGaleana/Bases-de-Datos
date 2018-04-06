using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class datosClientesPedidos : System.Web.UI.Page
{
    //Variables de la clase.
    DataSet DSGeneral = new DataSet(), DSPedidos = new DataSet();
    DataSet DSArtículos = new DataSet(), DSPagos = new DataSet();
    DataSet DSPedido = new DataSet();
    DataRow fila;
    GestorBD.GestorBD GestorBD;       //Para manejar la BD.
    Comunes objComun = new Comunes();     //Para manejar las rutinas de uso común.
    String cadSql, rfc, tipo;

    //Acciones iniciales
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            //recuperamos los objetos de la base de datos
            GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
            rfc = Session["rfc"].ToString();
            tipo = Session["tipo"].ToString();

            if (tipo == "Cli") // El usuario es un Cliente
            {
                //pone los datos del cliente en la tabla
                cadSql = "select * from pcusuarios u, pcclientes c where u.rfc = c.rfc and c.rfc = '" + rfc + "'";
                GestorBD.consBD(cadSql, DSGeneral, "info");
                fila = DSGeneral.Tables["info"].Rows[0];
                tblInfoCliente.Rows[1].Cells[0].Text = fila["rfc"].ToString();
                tblInfoCliente.Rows[1].Cells[1].Text = fila["nombre"].ToString();
                tblInfoCliente.Rows[1].Cells[2].Text = fila["domicilio"].ToString();
                
                //Cargar el dropdownlist con sus pedidos
                cadSql = "select * from pcpedidos where rfcc = '" + rfc + "'";
                GestorBD.consBD(cadSql, DSPedidos, "Pedidos");
                objComun.cargaDDL(ddlFPedidos, DSPedidos, "Pedidos", "foliop");
                Session["DSPedidos"] = DSPedidos;
                Label2.Text = "Pedidos Cliente:";
            }
            else { // El usuario es un empleado
                Label1.Visible = tblInfoCliente.Visible = false;
                Label2.Text = "Pedidos Empleado:";

                //Cargar el dropdownlist con los pedidos que fueron levantados por él
                cadSql = "select * from pcpedidos where rfce = '" + rfc + "'";
                GestorBD.consBD(cadSql, DSPedidos, "Pedidos");
                objComun.cargaDDL(ddlFPedidos, DSPedidos, "Pedidos", "foliop");
                Session["DSPedidos"] = DSPedidos;
            }
        }
    }


    //Carga la tabla con la información del pedido seleccionado
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        cadSql = "select * from pcpedidos where foliop = " + Convert.ToInt16(ddlFPedidos.SelectedValue.ToString());
        GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
        GestorBD.consBD(cadSql, DSPedido, "Pedido");

        fila = DSPedido.Tables["Pedido"].Rows[0];
        tblInfoPedidos.Rows[1].Cells[0].Text = fila["foliop"].ToString();
        tblInfoPedidos.Rows[1].Cells[1].Text = fila["fechaped"].ToString();
        tblInfoPedidos.Rows[1].Cells[2].Text = fila["monto"].ToString();
        tblInfoPedidos.Rows[1].Cells[3].Text = fila["saldocli"].ToString();
        tblInfoPedidos.Rows[1].Cells[4].Text = fila["saldofacs"].ToString();
    }
}