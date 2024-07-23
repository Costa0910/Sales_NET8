using System.ComponentModel.DataAnnotations;

namespace Sales_NET8.Web.Data.Entities;

public class Country
{
    public int Id { get; set; }

    [Display(Name = "Pais"), MaxLength(50, ErrorMessage = "O campo {0} deve ter no maximo {1} caracteres."), Required(ErrorMessage = "O campo {0} e obrigatorio")]
    public string? Name { get; set; }
}