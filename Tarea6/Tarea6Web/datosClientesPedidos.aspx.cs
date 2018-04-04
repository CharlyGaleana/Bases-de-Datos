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
    String cadSql, rfc;
    String tipoUsuario;

    //Acciones iniciales
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            //recuperamos los objetos de la base de datos
            GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
            rfc = Session["rfc"].ToString();

            //pone los datos del cliente en la tabla
            cadSql = "select * from pcusuarios u, pcclientes c where u.rfc = c.rfc and c.rfc = '" + rfc + "'";
            GestorBD.consBD(cadSql, DSGeneral, "info");


            if (DSGeneral.Tables["info"].Rows.Count > 0)
            {
                tipoUsuario = "cliente";
                //Rellenar los datos del cliente en la tabla
                fila = DSGeneral.Tables["info"].Rows[0];
                Table1.Rows[1].Cells[0].Text = fila["rfc"].ToString();
                Table1.Rows[1].Cells[1].Text = fila["nombre"].ToString();
                Table1.Rows[1].Cells[2].Text = fila["domicilio"].ToString();
                //Cargar el dropdownlist con sus pedidos
                cadSql = "select * from pcpedidos where rfcc = '" + rfc + "'";
                GestorBD.consBD(cadSql, DSPedidos, "Pedidos");
                objComun.cargaDDL(DropDownList1, DSPedidos, "Pedidos", "foliop");
                Session["DSPedidos"] = DSPedidos;
            }
            else {
                tipoUsuario = "empleado";
                Label1.Visible = tblCliente.Visible = false;
            }
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}