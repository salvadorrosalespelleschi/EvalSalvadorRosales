using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EvalSalvadorRosales.Models
{
    public enum CurrType { 
        code,
        name,
        symbol
    }
    public class Country
    {
        [Key]
        [Required(ErrorMessage = "Nombre de pais obligatorio")]
        [StringLength(50,ErrorMessage="Largo Maximo 50 caracteres")]
        public string name { get; set; }

        [Required(ErrorMessage = "Nombre de capital obligatorio")]
        [StringLength(50, ErrorMessage = "Largo Maximo 50 caracteres")]
        public string capital { get; set; }
        
        [Required(ErrorMessage = "Cantidad de Poblacion obligatoria")]
        
        public int population { get; set; }
        
        [Required]
        public float latlng { get; set; }
        
        [Required(ErrorMessage = "Zona Horaria obligatoria")]
        [RegularExpression("UTC-",ErrorMessage ="Expresion no valida")]
        public string timezones { get; set; }
        
        [Required(ErrorMessage = "Moneda obligatoria")]
        [StringLength(30, ErrorMessage = "Largo Maximo 30 caracteres")]
        public CurrType currencies { get; set; }
       
        [Required(ErrorMessage = "Bandera obligatoria")]
        [StringLength(50, ErrorMessage = "Largo Maximo 50 caracteres")]
        public string Flag { get; set; }

    }
}