
using System.Collections.Concurrent;

namespace ManejarAgenda.code
{           

    public class Program
    {
                 
        public static void Main(string[] args)
        {
              
            ManagerContacto manejadorAgendas = new ManagerContacto(new ConexionDB());
            Boolean continuar = true;
                                                                                        
                                           
            while(continuar)
            {
                Console.Clear();
                System.Console.WriteLine("¿Qué operación deseas realizar?(1,2,3,4 o 5)");
                System.Console.WriteLine(" 1.Agregar contacto");
                System.Console.WriteLine(" 2.Mostrar contactos");
                System.Console.WriteLine(" 3.Modificar contacto");
                System.Console.WriteLine(" 4.Eliminar contacto");
                System.Console.WriteLine(" 5.salir");
                System.Console.WriteLine("Seleciona una opcion:");
                int opcion = int.Parse(Console.ReadLine());



                switch (opcion)
                {
                    // caso para guardar contacto
                    case 1:

                        System.Console.WriteLine("Agregando contacto");
                        Agenda contacto = new Agenda();

                        System.Console.WriteLine("Introduce el nombre:");
                        contacto.setNombre(Console.ReadLine());

                        System.Console.WriteLine("introduce los apellidos:");
                        contacto.setApellidos(Console.ReadLine());

                        System.Console.WriteLine("Introduce la empresa:");
                        contacto.setEmpresa(Console.ReadLine());

                        System.Console.WriteLine("Introduce el Telefono,formato(829-XXX-XX):");
                        contacto.setTelefono(Console.ReadLine());

                        System.Console.WriteLine("Introduce el correo:");
                        contacto.setCorreo(Console.ReadLine());

                        

                        manejadorAgendas.Guardar(contacto);
                        System.Console.WriteLine("contacto agregado");


                        break;

                   
                    // caso para mostrar  contactos
                    case 2:
                                  
                        try
                        {
                            System.Console.WriteLine("consultando contactos");
                            List<Agenda> contactos = manejadorAgendas.ConsultarAgenda();

                            if(contactos.Count() == 0)
                            {

                                System.Console.WriteLine("no hay contactos en la agenda");

                            }
                            else
                            {
                                System.Console.WriteLine("Lista de contactos");   
                                foreach (var Contacto in contactos)
                                {
                                    System.Console.WriteLine("ID:" + Contacto.getId());
                                    System.Console.WriteLine("Nombre:" + Contacto.getNombre());
                                    System.Console.WriteLine("Apellidos:" + Contacto.getApellidos());
                                    System.Console.WriteLine("Empresa:" + Contacto.getEmpresa());
                                    System.Console.WriteLine("Telefono:" + Contacto.getTelefono());
                                    System.Console.WriteLine("Correo:" + Contacto.getCorreo());
                                    System.Console.WriteLine("--------------------------------");
                                }

                            }

                        }
                        catch (Exception e)
                        {

                            System.Console.WriteLine("error al consutar contactos"+e.Message);

                        }

                        break;

                    //caso para actualizar contacto
                    case 3:
                       
                        System.Console.WriteLine("Actualizando contacto");
                        Agenda nuevo = new Agenda();

                        System.Console.WriteLine("introduce el nuevo nombre:");
                        nuevo.setNombre(Console.ReadLine());

                        System.Console.WriteLine("Introduce el nuevo apellido:");
                        nuevo.setApellidos(Console.ReadLine());

                        System.Console.WriteLine("Introduce el nombre de la empresa:");
                        nuevo.setEmpresa(Console.ReadLine());

                        System.Console.WriteLine("Introduce el numero de telefono:");
                        nuevo.setTelefono(Console.ReadLine());

                        System.Console.WriteLine("Introduce el nuevo correo:");
                        nuevo.setCorreo(Console.ReadLine());

                        System.Console.WriteLine("Introduce el id del contacto a actualizar:");
                        int idActualizar = int.Parse(Console.ReadLine());


                        try
                        {

                            manejadorAgendas.Actualizar(nuevo, idActualizar);
                            System.Console.WriteLine("contacto actualizado");

                        }
                        catch (Exception e)
                        {
                              
                            System.Console.WriteLine("Error al actualizar contacto" + e.Message);

                        }

                        break;

                      //caso para eliminar  contacto
                    case 4:

                        System.Console.WriteLine("Eliminando contacto");
                        System.Console.WriteLine("Introduce el id del contacto a eliminar:");
                        int idEliminar = int.Parse(Console.ReadLine());


                        try
                        {

                            manejadorAgendas.Eliminar(idEliminar);
                            System.Console.WriteLine("contacto eliminado");
                        }
                        catch (Exception e)
                        {

                            System.Console.WriteLine("Error al eliminar contacto" + e.Message);
                        }

                        break;

                    case 5:
                        continuar = false;
                        System.Console.WriteLine("saliendo del programa..");
                        System.Console.WriteLine("hasta pronto");

                        break;

                    default:

                        System.Console.WriteLine("opcion no valida");

                        break;



                };


                if (continuar)
                {
                    System.Console.WriteLine("\nPresione cualquier tecla para continuar");
                    Console.ReadKey();
                   

                }

                 Console.Clear();


            }




        }



    }
}






