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
  DataSet DsGeneral= new DataSet(); DataRow fila;
  GestorBD.GestorBD GestorBD;         //Para manejar la BD.
  Comunes comunes= new Comunes();     //Para manejar las rutinas de uso común.
  String cadSql;

  //Acciones iniciales.
  protected void Page_Load(object sender, EventArgs e) {

  }


    protected void BtnEjecuta_Click(object sender, EventArgs e) {
        String oper;

        oper = Session["Operación"].ToString();
        switch (oper) {
            case "Alta":
                alta();
                break;
            case "Baja":
                //baja();
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
        }
        else {
            LblMensaje.Text = "inserción fallida, ya existe RFC";
        }
    }
}