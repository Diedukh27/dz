using Microsoft.EntityFrameworkCore; 
using WebATB.Data.Entities; 

namespace WebATB.Data; 

// Клас контексту бази даних, який наслідується від DbContext
public class MyContextATB : DbContext
{
    // Конструктор приймає параметри конфігурації (рядок підключення тощо)
    public MyContextATB(DbContextOptions<MyContextATB> contextOptions)
         : base(contextOptions) // Передає налаштування в базовий клас DbContext
    {

    }

    // Таблиця Categories у базі даних
    // DbSet представляє колекцію записів таблиці CategoryEntity
    public DbSet<CategoryEntity> Categories { get; set; }
}
