using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   
    public class Usuarios
    {
        [Key]

        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public string TipodeAcceso { get; set; }
        public string Contraseña { get; set; }
        

        

        public Usuarios()
        {       
               
            UsuarioId = 0;
            Fecha = DateTime.Now;
            Nombre = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Usuario = string.Empty;
            Email = string.Empty;
            TipodeAcceso = string.Empty;
            Contraseña = string.Empty;
        }
    }
}
