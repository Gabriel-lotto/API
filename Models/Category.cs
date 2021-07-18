using System.ComponentModel.DataAnnotations;

namespace shop.Models
{
    public class Category 
    {
        public int Id {get; set;}

        [Required(ErrorMessage ="Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage ="Este campo deve conter de 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage ="Este campo deve conter de 3 e 60 caracteres")]
        public string Title {get; set;}
    }
}