﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
    //Variables de clase
    GestorBD.GestorBD GestorBD;
    string cadSql;
    DataSet DsGeneral = new DataSet();

    //Acciones Iniciales
    protected void Page_Load(object sender, EventArgs e) {
        LblFecha.Text = DateTime.Now.ToString();

        //IsPostBack da la primera vez que se se entra a la página,
        //da true las veces subsecuentes.
        if (!IsPostBack) {
            //conexión a la base de datos
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd12", "lircar", "oracle");
            Session["GestorBD"] = GestorBD;
        }

    }

    private bool valida() {
        cadSql = "select * from pcusuarios where rfc = '"
            + Login2.UserName + "' and passw = '" + Login2.Password + "'";

        GestorBD = (GestorBD.GestorBD) Session["GestorBD"];
        GestorBD.consBD(cadSql, DsGeneral, "temp");
        if (DsGeneral.Tables["temp"].Rows.Count != 0) 
            return true;

        return false;
    }

    //Valida al usario y la contraseña
    protected void Login2_Authenticate(object sender, AuthenticateEventArgs e) {

        if ( valida() ) {
            //Recupera objetos de Session
            Session["rfc"] = Login2.UserName;
            Server.Transfer("EjecuciónSP.aspx");
        }
    }
}