using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Biblioteca.Entities
{
    public class Categoria
    {
        [Key]
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
