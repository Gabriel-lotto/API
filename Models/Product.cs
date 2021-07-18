using System.ComponentModel.DataAnnotations;

namespace shop.Models
{
    public class Product
    {
        public int Id {get; set;}

        [Required(ErrorMessage ="Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage ="Este campo deve conter de 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage ="Este campo deve conter de 3 e 60 caracteres")]

        public string Title{get;set;}

        [MaxLength(1024, ErrorMessage ="Este campo deve conter no máximo 1024 caracteres")]

        public string Description {get; set;}

        [Required(ErrorMessage ="Este campo é obrigatório")]
        [Range(1,int.MaxValue, ErrorMessage="O valor deve ser maior que zero")]

        public decimal Price {get; set;}

        [Required(ErrorMessage ="Esse campo é obrigatório")]
        [Range(1,int.MaxValue, ErrorMessage ="Categoria inválida")]

        public int CategoryId {get; set;}

        public Category Category {get; set;}
    }
}