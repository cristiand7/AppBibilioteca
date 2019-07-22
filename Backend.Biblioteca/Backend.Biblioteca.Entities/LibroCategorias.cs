using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Biblioteca.Entities
{
    public class LibroCategorias
    {
        [Key]
        public string Id { get; set; }
        public string LibroId { get; set; }
        public string CategoriaId { get; set; }
    }
}
