

namespace ManejarAgenda;

public class AgendaValidator{
      
             
      public void Validar(Agenda agenda){

       if(string.IsNullOrWhiteSpace(agenda.getNombre()))
        throw new ArgumentException("el nombre no puede estar vacio");
   
       if (string.IsNullOrWhiteSpace(agenda.getApellidos()))
         throw new ArgumentException("el  apellido no puede estar vacio");

       if(string.IsNullOrWhiteSpace(agenda.getEmpresa()))  
         throw new ArgumentException("el nombre de la empresa no puede esta vacio");

       if(agenda.getTelefono().Length != 12)
         throw new ArgumentException("el numero de telefono debe de tener 12 digito");

        if(!agenda.getCorreo().Contains("@") && string.IsNullOrWhiteSpace(agenda.getCorreo()))
           throw new ArgumentException("el correo debe tener formato valido y no estar vacio");    
       

      }
        

}