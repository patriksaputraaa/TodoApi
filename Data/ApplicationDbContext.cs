using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Data;

public class ApplicationDbContext: DbContext{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options){
        /*Ini adalah konstruktor untuk kelas ApplicationDbContext. 
        Ini menerima objek DbContextOptions<ApplicationDbContext> 
        yang menyediakan konfigurasi untuk koneksi ke database. 
        Konstruktor ini kemudian meneruskan opsi tersebut ke konstruktor kelas dasar (base(options)), 
        yang merupakan konstruktor kelas DbContext.*/
    }
    
    public DbSet<TodoItem> TodoItems{get; set;}
    /*Ini adalah properti yang mewakili kumpulan objek TodoItem yang akan diakses atau dimanipulasi dalam database. 
    Properti ini merupakan bagian dari kelas ApplicationDbContext dan akan digunakan untuk berinteraksi 
    dengan tabel yang sesuai dengan model TodoItem dalam database.*/
}