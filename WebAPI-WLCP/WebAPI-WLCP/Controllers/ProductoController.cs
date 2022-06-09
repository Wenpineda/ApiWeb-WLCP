using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Net.Http;


namespace WebAPI_WLCP.Controllers 
{
    public class ProductoController : ApiController
    {
        [System.Web.Http.HttpPost]
        // GET: Producto
        public IHttpActionResult Add()
        {
            using (Models.BarDbEntities db = new Models.BarDbEntities())
            {

                var oProducto = new Models.Producto();
                oProducto.nomProd = "Jugo Valle"; 
                oProducto.descripcion = "Sabor Limon"; 
                oProducto.precio =Convert.ToDecimal(0.50); 
                oProducto.cantidad = 5; 
                oProducto.estado = 2;
                db.Producto.Add(oProducto);    
                db.SaveChanges();
            }
            return Ok("Hecho");
        }
    }
}
