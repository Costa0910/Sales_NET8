using System.ComponentModel.DataAnnotations;

namespace Sales_NET8.Web.Data.Entities;

public class Category
{
    public int Id { get; set; }

    [Display(Name = "Category"), MaxLength(20, ErrorMessage = "O campo {0} deve ter no maximo {1} caracteres."),
     Required(ErrorMessage = "O campo {0} e obrigatorio")]
    public string? Name { get; set; }
}