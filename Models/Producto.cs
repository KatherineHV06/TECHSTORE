using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechStore.Models
{
    public class Producto
    {
        [Display(Name = "Nombre del producto")]
        [Required]
        public string Nombre { get; set; }

        [Display(Name = "Descripcion del producto")]

        public string Descripcion { get; set; } 
        
        [Display(Name = "Precio del producto")]
        [Required]
        public int Precio { get; set; }


         public double PrecioIgv { get; set; }

        public void calcularIgv(){
            PrecioIgv = Precio*1.18;
        }
    }


}