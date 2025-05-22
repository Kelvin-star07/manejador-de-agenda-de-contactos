namespace ManejarAgenda;
using Microsoft.Data.SqlClient;

public class ConexionDB{
            
    string CadenaConexion="Server=localhost;database=AgendaContacto;user id=Usersql;password=root;"
                          +"TrustServerCertificate=True;";
    SqlConnection? conexion;


    public SqlConnection EstablecerConexion(){

      conexion = new SqlConnection(CadenaConexion);

        try{

             conexion.Open();
             System.Console.WriteLine("conexion a DB exitosa");

          }
          catch(Exception e){
            
            System.Console.WriteLine("Error en la conexion"+e.Message);
                                                       

          }
          

         return conexion;


    }



    
        
    





}

