

using System.Security.Cryptography;
using Microsoft.Data.SqlClient;

namespace ManejarAgenda;
   // clase para manejar la logica de negocio para el CRUD
public class ManagerContacto
{                 
                                                                                                              
    private ConexionDB DB;
    private AgendaValidator validador = new AgendaValidator();
 

    public ManagerContacto(ConexionDB db)
    {

        this.DB = db;

    }

                           
    // metodo guardar para guardar registro en la base de datos
    public void Guardar(Agenda agenda)
    {
             
       
        SqlCommand? Cmd = null;
        validador.Validar(agenda);

        try
        {

            string query = "Insert into Agendas(Nombre,Apellidos,Empresa,Telefono,Correo)"
                          + "values(@p1,@p2,@p3,@p4,@p5)";

            Cmd = new SqlCommand(query, DB.EstablecerConexion());

            Cmd.Parameters.AddWithValue("@p1", agenda.getNombre());
            Cmd.Parameters.AddWithValue("@p2", agenda.getApellidos());
            Cmd.Parameters.AddWithValue("@p3", agenda.getEmpresa());
            Cmd.Parameters.AddWithValue("@p4", agenda.getTelefono());
            Cmd.Parameters.AddWithValue("@p5", agenda.getCorreo());

            Cmd.ExecuteNonQuery();
            System.Console.WriteLine("contacto agregado exitosamente");



        }
        catch (Exception e)
        {
            System.Console.WriteLine("Error al agregar contacto" + e.Message);
            throw;

        }
        finally
        {      
            //cerrando y liberando recursos de la conexion a db
            if (Cmd != null)
            {
                      
                Cmd.Dispose();
                Cmd.Connection.Dispose();
                Cmd.Connection.Close();
               

            }

        }


    }

          
    // metodo consultar para obtener registro en la base de datos
    public List<Agenda> ConsultarAgenda()
    {
                
        var agendas = new List<Agenda>();
        SqlDataReader?  lector = null;
        SqlCommand? Cmd = null;


        try
        {

            string query = "select * from Agendas";
            Cmd = new SqlCommand(query, DB.EstablecerConexion());
            lector = Cmd.ExecuteReader();
            
            while (lector.Read())
            {

                Agenda agenda = new Agenda(

                      lector.GetInt32(0),
                      lector.GetString(1),
                      lector.GetString(2),
                      lector.GetString(3),
                      lector.GetString(4),
                      lector.GetString(5)

                );

                agendas.Add(agenda);

            }

            System.Console.WriteLine("consulta exitosa");

        }
        catch (Exception e)
        {

            System.Console.WriteLine("Error en la consulta" + e.Message);
            throw;

        }
        finally
        {
             
            // cerrando y liberando recursos del lector
            if (lector != null)
            {
                lector.Close();
                lector.Dispose();

            }

            //  cerrando y liberando recursos de conexion a db
            if (Cmd != null)
            {
                Cmd.Dispose();
                Cmd.Connection.Dispose();
                Cmd.Connection.Close();
               
            }

        }

        return agendas;


    }



                           
    // metodo Actualizar para actualizar registro en la base de datos
    public void Actualizar(Agenda agenda, int id)
    {    
        if(id <= 0)
         throw new ArgumentException("El id debe de ser positivo");   

        SqlCommand? Cmd = null;
        validador.Validar(agenda);
      

        try
        {
            string query = "update Agendas set Nombre=@p1,Apellidos=@p2,Empresa=@p3,Telefono=@p4,Correo=@p5 where id=@p6";

            Cmd = new SqlCommand(query, DB.EstablecerConexion());


            Cmd.Parameters.AddWithValue("@p1", agenda.getNombre());
            Cmd.Parameters.AddWithValue("@p2", agenda.getApellidos());
            Cmd.Parameters.AddWithValue("@p3", agenda.getEmpresa());
            Cmd.Parameters.AddWithValue("@p4", agenda.getTelefono());
            Cmd.Parameters.AddWithValue("@p5", agenda.getCorreo());
            Cmd.Parameters.AddWithValue("@p6",  id);

            int filasAfectada = Cmd.ExecuteNonQuery();
            if (filasAfectada == 0)
            {

                System.Console.WriteLine("no se actualizo ningun contacto");

            }
            else
            {


                System.Console.WriteLine("Contacto actualizado correctamente");

            }


        }
        catch (Exception e)
        {

            System.Console.WriteLine("error al actualizar el contacto" + e.Message);
            throw;
        }
        finally
        {
            
            //liberar y cerrar recursos de la conexion a db
            if (Cmd != null)
            {

                Cmd.Dispose();
                Cmd.Connection.Close();
                Cmd.Connection.Dispose();
                   
            }

        }

    }

                      
    // metodo eliminar para eliminar registro en la base de datos
    public void Eliminar(int id)
    {        
        if(id <= 0 )
         throw new ArgumentException("el id debe ser mayor que 0");

        SqlCommand? Cmd = null;
        
        try
        {
            string query = "Delete from Agendas where id=@p1";


            Cmd = new SqlCommand(query, DB.EstablecerConexion());
            Cmd.Parameters.AddWithValue("@p1", id);

            int filasAfectada = Cmd.ExecuteNonQuery();
            if (filasAfectada == 0)
            {
                    
                System.Console.WriteLine("No se hallo un registro con ese id");

            }
            else
            {

                System.Console.WriteLine("contacto eliminado exitosamente");

            }


        }
        catch (Exception e)
        {

            System.Console.WriteLine("Error al eliminar contacto" + e.Message);
            throw;

        }
        finally
        {

            //liberar y cerrar recursos de la conexion a db
            if (Cmd != null)
            {

                Cmd.Dispose();
                Cmd.Connection.Dispose();
                Cmd.Connection.Close();
               

            }


        }





    }


}