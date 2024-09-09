
using api.src.model;

namespace api.src.abstraction;
public interface IOrden 
{
   void Get();

   List<tbHccOrdenes> GetAll();

   void insertarOrden(tbHccOrdenes orden);

   List<int> obtenerOrdenesPorMesa();

   void agregarProductoOrden(int ordId, tbHccOrdenDetalle nuevaOrden );

   void cambiarEstatusOrden(int ordId, byte nuevoEstatus);

   void eliminarOrden(int ordId);
}