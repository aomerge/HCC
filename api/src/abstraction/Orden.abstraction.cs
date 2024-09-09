
using api.src.model;

namespace api.src.abstraction;
public interface IOrden 
{
   void Get();

   List<tbHccOrdenes> GetAll();

   void insertarOrden(tbHccOrdenes orden);

   List<int> obtenerOrdenesPorMesa();
}