using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminUsuarios : System.Web.UI.Page
{
  //Variables generales de la página.
  private DataSet DsGeneral= new DataSet(); DataRow fila;
  private GestorBD.GestorBD GestorBD;         //Para manejar la BD.
  private Comunes comunes= new Comunes();     //Para manejar las rutinas de uso común.
  private String cadSql;
    private const int OK = 1;

  //Acciones iniciales.
  protected void Page_Load(object sender, EventArgs e) {

  }


    protected void BtnEjecuta_Click(object sender, EventArgs e) {

        if (Page.IsValid) {
            String oper;

            oper = Session["Operación"].ToString();
            switch (oper) {
                case "Alta":
                    alta();
                    break;
                case "Baja":
                    baja();
                    break;
                case "Cambio":
                    //cambio();
                    break;
            }

            TxtRFC.Visible = false; TxtNombre.Visible = false;
            TxtPassw.Visible = false;
            //TxtPassw.TextMode = TextBoxMode.Password;   //Para que aparezcan asteriscos al dar la contra.
            TxtDomicilio.Visible = false; TxtCat.Visible = false;
            DDLTipo.Text = "Tipo de usuario"; DDLTipo.Visible = false; DDLUsuarios.Visible = false;
            BtnAlta.Enabled = true; BtnBaja.Enabled = true; BtnCambio.Enabled = true;
            BtnEjecuta.Enabled = false;

        }
    }

    //Muestra controles adicionales según el tipo de usuario a dar de alta.
    protected void DDLTipo_SelectedIndexChanged(object sender, EventArgs e) {
        String tipo;

        tipo = DDLTipo.SelectedValue;
        LblMensaje.Text = "Tipo de usuario: " + tipo;
        if (DDLTipo.Text != "Tipo de usuario") {
            if (DDLTipo.SelectedValue == "Cli") {
                TxtDomicilio.Visible = true; TxtCat.Visible = false;
            }
            else {
                TxtDomicilio.Visible = false; TxtCat.Visible = true;
                if (DDLTipo.SelectedValue == "Emp")
                    TxtCat.Text = "Base";          //Tipo de empleado.
                else
                    TxtCat.Text = "Gerente";
            }
            BtnEjecuta.Enabled = true;
        }
        else {
            TxtDomicilio.Visible = false; TxtCat.Visible = false; BtnEjecuta.Enabled = false;
        }
    }

    //Parte 1a: acciones relacionadas con el alta de usuarios.
    //Muestra/deshabilita los controles asociados al alta.
    protected void BtnAlta_Click(object sender, EventArgs e) {
        TxtRFC.Visible = true; TxtNombre.Visible = true;
        TxtPassw.Visible = true; DDLTipo.Visible = true;
        BtnBaja.Enabled = false; BtnCambio.Enabled = false;
        LblMensaje.Text = "Operación: Alta";
        Session["Operación"] = "Alta";
    }

    //Alta de un nuevo usuario:
    //primeramente lo da de alta en la tabla de Usuarios, verificando antes que no exista 
    //el RFC. Después da de alta en las tablas de Clientes o Empleados, según el tipo de
    //usuario de que se trate.
    public void alta() {
        GestorBD = (GestorBD.GestorBD)(Session["GestorBD"]);

        //verifica que la clave no exista.
        cadSql = "select rfc from PCUsuarios where RFC = '" +
             TxtRFC.Text + "'";
        GestorBD.consBD(cadSql, DsGeneral, "Temp");

        if (DsGeneral.Tables["Temp"].Rows.Count == 0) {
            LblMensaje.Text = "inserción correcta";
            //Si la clave no existe, inserta en la tabla de usuarios.
            cadSql = "insert into PCUsuarios values ('" + TxtRFC.Text + "','" + TxtNombre.Text +
                "','" + TxtPassw.Text + "','" + DDLTipo.SelectedValue.ToString() + "')";
            if (GestorBD.altaBD(cadSql) == OK) {

                if (DDLTipo.SelectedValue.ToString() == "Cli") {
                    //Da de alta cliente

                    cadSql = "insert into PCClientes values('" + TxtRFC.Text +
                    "','" + TxtDomicilio.Text + "')";
                    if (GestorBD.altaBD(cadSql) == OK)
                        LblMensaje.Text = "Inserción exitosa en Usuarios y Clientes";
                    else
                        LblMensaje.Text = "Error de inserción en la tabla Clientes";
                }
                else {
                    //Da de alta empleado
                    cadSql = "insert into PCEmpleados values ('" + TxtRFC.Text + "','" + TxtCat.Text + "')";
                }

            }
            else {
                LblMensaje.Text = "Error: No se hizo la inserción";
            }
        }
        else {
            LblMensaje.Text = "inserción fallida, ya existe RFC";
        }
    }

    //Lee los datos de los usuarios y muestra sus RFC en el DDL de usuarios.
    //Esta rutina es usada tanto en baja, como en cambio de datos de usuarios.
    protected void leeUsuarios() {
        GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
        cadSql = "select * from PCUsuarios";
        GestorBD.consBD(cadSql, DsGeneral, "DatosUsuarios");
        comunes.cargaDDL(DDLUsuarios, DsGeneral, "DatosUsuarios", "RFC");
        Session["DsGeneral"] = DsGeneral;
    }

    protected void BtnBaja_Click(object sender, EventArgs e) {
        //Lee los datos de los usuarios y muestra sus RFC en DDLUsuarios.
        leeUsuarios();

        //Oculta/deshabilita controles.
        DDLUsuarios.Visible = true;
        BtnAlta.Enabled = false; BtnCambio.Enabled = false;
        LblMensaje.Text = "Operación: Baja";
        Session["Operación"] = "Baja";
    }

    //=================================================================
    //Baja de un usuario:
    //elimina al usuario elegido en el DDL.
    protected void baja() {
        String RFC, tipo;
        DataRow fila;
        GestorBD = (GestorBD.GestorBD)Session["GestorBD"];


        RFC = DDLUsuarios.SelectedValue.ToString();
        cadSql = "select * from PCUsuarios where RFC = '" + RFC + "'";
        GestorBD.consBD(cadSql, DsGeneral, "RFC");
        fila = DsGeneral.Tables["RFC"].Rows[0];
        tipo = Convert.ToString(fila[3]);
        //LblMensaje.Text = tipo;
        if (tipo == "Cli") {

            cadSql = "delete from PCClientes where RFC = '" + RFC + "'";
            if (GestorBD.bajaBD(cadSql) == OK)
                LblMensaje.Text = "Cliente Eliminado";
            else
                LblMensaje.Text = "Cliente no se eliminó correctamente";

        }
        else {
            cadSql = "delete from PCEmpleados where RFC = '" + RFC + "'";
            if (GestorBD.bajaBD(cadSql) == OK)
                LblMensaje.Text = "Empleado Eliminado";
            else
                LblMensaje.Text = "Empleado no se eliminó correctamente";

        }

        cadSql = "delete from PCUsuarios where RFC = '" + RFC + "'";
        if (GestorBD.bajaBD(cadSql) == OK)
            LblMensaje.Text = "Usario Eliminado";
        else
            LblMensaje.Text = "Usuario Eliminado";


    }

    protected void DDLUsuarios_SelectedIndexChanged(object sender, EventArgs e) {
        BtnEjecuta.Enabled = true;
    }
}