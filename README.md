# Repository Pattern

## Implementación de una de las muchas variantes del patrón repositorio.


1. Creamos una entidad base con las propiedades comunes a todas nuestras entidades, en este caso, la clave única en base de datos Id. Todas nuestras entidades heredaran esta clase. 
2. Creamos nuestra interfaz repositorio genérico en la capa de dominio y su implementación en la capa infraestructura, ahora cuando queramos utilizar un repositorio solamente debemos indicar la entidad con la que trabajará.

Pero, todavía podemos ir un paso más allá y crear un repositorio específico aprovechando nuestro trabajo, para ello, creamos una interfaz que defina los métodos necesarios, es decir, los específicos no incluidos en nuestro repositorio genérico y heredar esta clase del repositorio genérico con la entidad a utilizar, en nuestro ejemplo será :

      public interface IOrderRepository: IRepository<Order> 
      { 
            IEnumerable<Order> MetodoEspecífico(tipo parametros); 
      }

y después implementar en una nueva clase la interfaz que acabamos de crear para el nuevo método y que herede del repositorio genérico con nuestra entidad:

      public class OrderRepository: Repositorio<Order>, IOrderRepository
      { 
            IEnumerable<Order> MetodoEspecífico(tipo parametros){
                .....
                to do
                .....
            }
      }
      
 
 Eso es todo, ahora tenemos la posibilidad de utilizar en nuestros controladores de la capa presentación estas clases....
