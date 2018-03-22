using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Tarea5.Procedimientos
{
    public partial class Subprogramas : Form
    {

        OleDbConnection cnOracle;
        public Subprogramas()
        {
            InitializeComponent();
        }

        //Ejecuta una función almacenado
        //Dado un campus y su institución regresa la cantidad de servicios que ofrece.
        private void btnEjecutaFuncion_Click(object sender, EventArgs e)
        {
            String nomInst, nomCamp;
            OleDbCommand func;

            //1- Abrir la conexión a la BD.
            cnOracle = new OleDbConnection("Provider=MSDAORA; Data Source=oracle;" +
              "User ID=bd12;Password=lircar");
            cnOracle.Open();
            func = new OleDbCommand();
            func.Connection = cnOracle;

            //2- Especificar el llamado al procedimiento  (en general: al subprograma).
            func.CommandText = "cantidadServicios";
            func.CommandType = CommandType.StoredProcedure;
            OleDbParameter par;

            //3- Especificar los parámetros:
            //a) primero todos los de retorno:
            par = new OleDbParameter("RETURN_VALUE", OleDbType.Integer,
              4, ParameterDirection.ReturnValue, false, 4, 0, "cantServicios", DataRowVersion.Current, 0);
            func.Parameters.Add(par);

            //b) luego todos los de entrada:
            nomInst = "ITAM";
            par = new OleDbParameter("nombreInst", nomInst);
            func.Parameters.Add(par);

            nomCamp = "ITAM Rio Hondo";
            par = new OleDbParameter("nombreCampus", nomCamp);
            func.Parameters.Add(par);

            //4- Ejecutar el procedimiento (en general: el subprograma).
            try
            {
                func.ExecuteNonQuery();

                //5- Recuperar el (los) valor(es) regresado(s) por medio del (de los)
                //   parámetro(s) de salida.
                int cant = Convert.ToInt16(func.Parameters["RETURN_VALUE"].Value);
                MessageBox.Show("Cant. de servicios de ITAM Rio Hondo: " + cant);
            }
            catch (OleDbException err)
            {
                MessageBox.Show(err.Message);
            }

            //6- Cerrar la conexión a la BD.
            cnOracle.Close();
        }

        //Ejecuta un procedimiento Almacenado
        //Dados dos campus de la misma institución y un grado de estudios
        //el procedimiento calcula cual de esos campus tiene más profesores de un grado dado
        //NOTA: el procedimiento no está funcionando correctamente 
        private void btnEjecutaProcedimiento_Click(object sender, EventArgs e)
        {
            String nom, c1, c2, grado;
            String res;
            OleDbCommand proc;
            OleDbParameter par;

            //1- Abrir la conexión a la BD.
            cnOracle = new OleDbConnection("Provider=MSDAORA; Data Source=oracle;" +
              "User ID=bd12;Password=lircar");
            cnOracle.Open();
            proc = new OleDbCommand();
            proc.Connection = cnOracle;

            //2- Especificar el llamado al procedimiento  (en general: al subprograma).
            proc.CommandText = "masProfesores";
            proc.CommandType = CommandType.StoredProcedure;

            //3- Especificar los parámetros:
            //a) primero todos los de entrada:
            nom = "ITAM";
            par = new OleDbParameter("nom", nom);
            proc.Parameters.Add(par);

            c1 = "ITAM Rio Hondo";
            par = new OleDbParameter("nom", c1);
            proc.Parameters.Add(par);

            c2 = "ITAM Santa Teresa";
            par = new OleDbParameter("nom", c2);
            proc.Parameters.Add(par);

            grado = "DOC";
            par = new OleDbParameter("nom", grado);
            proc.Parameters.Add(par);

            //b) luego todos los de salida (uno en este caso):
            par = new OleDbParameter("cant", OleDbType.Integer,
              4, ParameterDirection.Output, false, 4, 0, "cant", DataRowVersion.Current, 0);
            proc.Parameters.Add(par);



            //4- Ejecutar el procedimiento (en general: el subprograma).
            try
            {
                proc.ExecuteNonQuery();

                //5- Recuperar el (los) valor(es) regresado(s) por medio del (de los)
                //   parámetro(s) de salida.
                int cant = Convert.ToInt16(proc.Parameters["cant"].Value);
                MessageBox.Show("Resultado: " + cant);
            }
            catch (OleDbException err)
            {
                MessageBox.Show(err.Message);
            }

            //6- Cerrar la conexión a la BD.
            cnOracle.Close();
        }
    }
}
