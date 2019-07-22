using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Backend.Biblioteca.Entities
{
    public class Libro
    {
        [Key]
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string AutorId { get; set; }
        public string ISBN { get; set; }

        [NotMapped]
        public string Autor { get; set; }
        [NotMapped]
        public List<Categoria> ListaCategorias { get; set; }

    }
}
