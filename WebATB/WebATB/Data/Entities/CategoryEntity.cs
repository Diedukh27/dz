using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebATB.Data.Entities;

[Table("tblCategories")]
public class CategoryEntity
{
    [Key] // Вказує назву таблиці в базі даних
    public int Id { get; set; } // Обов’язкове поле, максимум 250 символів
    [Required, StringLength(250)] 
    public string Name { get; set; } = null!;   // Обов’язкове поле, максимум 250 символів
    [Required, StringLength(250)]
    public string Slug { get; set; } = null!;  
    [StringLength(100)]       // Необов’язкове поле, максимум 100 символів
    public string? Image { get; set; }
}
