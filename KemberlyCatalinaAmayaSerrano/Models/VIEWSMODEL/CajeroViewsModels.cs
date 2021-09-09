using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KemberlyCatalinaAmayaSerrano.Models.VIEWSMODEL
{
    public class CajeroViewsModels
    {
        [Display(Name = "Monto")]
        [Required(ErrorMessage = "Este campo es requerido")]   
        public String Monto { get; set; }
    }
}