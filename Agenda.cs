
namespace ManejarAgenda;
// clase  agenda se manejada como POJO
public class Agenda
{                                                              
    private int Id;
    private string Nombre = String.Empty;
    private string Apellidos = string.Empty;
    private string Empresa = string.Empty;
    private string Telefono = string.Empty;
    private string Correo = string.Empty;


  //constructor bacio o por defecto
    public Agenda()
    {



    }

    //constructor con parametros
    public Agenda(int id, string nombre, string apellidos, string empresa, string telefono, string correo)
    {

        this.Id = id;
        this.Nombre = nombre;
        this.Apellidos = apellidos;
        this.Empresa = empresa;
        this.Telefono = telefono;
        this.Correo = correo;

    }

    //getters y setters
    public void setId(int id)
    {     
             
            this.Id = id;
    }


    public int getId()
    {

        return Id;
    }


    public void setNombre(string nombre)
    {

            this.Nombre = nombre;
    }


    public string getNombre()
    {

        return Nombre;
    }


    public void setApellidos(string apellidos)
    {
            this.Apellidos = apellidos;
        
    }


    public string getApellidos()
    {

        return Apellidos;
    }



    public void setEmpresa(string empresa)
    {
       this.Empresa = empresa;
        
    }


    public String getEmpresa()
    {
        return Empresa;
    }



    public void setTelefono(string telefono)
    {
            this.Telefono = telefono;  

    }


    public string getTelefono()
    {

        return Telefono;
    }



    public void setCorreo(string correo)
    {
     
            this.Correo = correo;
    }
    
    


    public string getCorreo()
    {


        return Correo;
    }

}
