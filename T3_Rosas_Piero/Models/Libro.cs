using System;
using System.ComponentModel.DataAnnotations;

namespace T3_Rosas_Piero.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese el título del libro.")]
        [StringLength(150, ErrorMessage = "El título es demasiado largo (máximo 150 caracteres).")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El nombre del autor es obligatorio.")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Debe especificar la editorial del libro.")]
        public string Editorial { get; set; }

        [Required(ErrorMessage = "Ingrese el tema o género literario.")]
        public string Tema { get; set; }

        [Required(ErrorMessage = "El año de publicación es requerido.")]
        [Range(1900, 3000, ErrorMessage = "El año de publicación debe estar comprendido entre 1900 y 3000.")]
        public int AnioPublicacion { get; set; }

        [Required(ErrorMessage = "Debe indicar la cantidad de páginas.")]
        [Range(10, 1000, ErrorMessage = "El número de páginas debe estar en el rango de 10 a 1000.")]
        public int Paginas { get; set; }

        [Required(ErrorMessage = "Especifique el material de la tapa o encuadernación.")]
        public string Material { get; set; }

        [Required(ErrorMessage = "El número de copias disponibles es obligatorio.")]
        [Range(1, 20, ErrorMessage = "El inventario de copias permitidas debe ser de 1 a 20.")]
        public int Copias { get; set; }

        [Required(ErrorMessage = "Debe asignar una categoría al libro.")]
        public string Categoria { get; set; }
    }
}