using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class TodoContext : DbContext
/*Ini adalah deklarasi kelas TodoContext yang merupakan turunan dari kelas DbContext. 
DbContext adalah kelas utama yang digunakan untuk berinteraksi dengan database menggunakan Entity Framework Core. 
Kelas TodoContext akan bertanggung jawab untuk mengatur koneksi dan konfigurasi database, 
serta menyediakan akses ke entitas tertentu melalui properti DbSet.*/
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
        /* Ini adalah konstruktor untuk kelas TodoContext. 
        Konstruktor ini menerima objek DbContextOptions<TodoContext> yang menyediakan konfigurasi untuk koneksi ke database. 
        Konstruktor ini kemudian meneruskan opsi tersebut ke konstruktor kelas dasar (base(options)), 
        yang merupakan konstruktor kelas DbContext.*/
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
    /* Ini adalah properti yang mewakili kumpulan objek TodoItem yang akan diakses atau dimanipulasi dalam database. 
    Properti ini merupakan bagian dari kelas TodoContext dan akan digunakan untuk berinteraksi dengan tabel yang 
    sesuai dengan model TodoItem dalam database. Properti ini menggunakan inisialisasi properti C# 6.0, 
    yaitu = null!, yang menetapkan nilai awal properti TodoItems menjadi null. 
    Hal ini berguna jika tidak ada data yang ingin diinisialisasi saat pembuatan objek TodoContext.*/
}