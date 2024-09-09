
using api.src.model;

namespace api.src.abstraction;
public interface IOrden 
{
   void Get();

   List<tbHccOrdenes> GetAll();

   void Add(tbHccOrdenes orden);
}