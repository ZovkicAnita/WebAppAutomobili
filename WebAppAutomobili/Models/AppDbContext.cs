using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAppAutomobili.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Automobil> Automobil { get; set; }
        public DbSet<Kategorija> Kategorija { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Automobil>().Property(f => f.Cijena).HasPrecision(10, 2);
            builder.Entity<Kategorija>().HasData(
                new Kategorija() { Id = 1, Naziv = "Range Rover" },
                new Kategorija() { Id = 2, Naziv = "Mercedes Benz" },
                new Kategorija() { Id = 3, Naziv = "Audi" },
                new Kategorija() { Id = 4, Naziv = "Kia" },
                new Kategorija() { Id = 5, Naziv = "BMW" }
                );

            builder.Entity<Automobil>().HasData(
                new Automobil() { Id = 1, Naziv = "Range Rover Autobiography Vogue", Cijena = 800000, GodinaProizvodnje = 2018, SlikaUrl = "https://arbiterz.com/wp-content/uploads/2019/09/Range-1.jpg", KategorijaId = 1 },
                new Automobil() { Id = 2, Naziv = "Mercedes-Benz CLS klasa", Cijena = 210000, GodinaProizvodnje = 2015 ,SlikaUrl = "https://www.mercedes-benz.hr/passengercars/mercedes-benz-cars/models/cls/coupe-c257-fl/_jcr_content/image.MQ6.2.2x.20211208084839.png", KategorijaId = 2 },
                new Automobil() { Id = 3, Naziv = "Audi Q7", Cijena = 338000, GodinaProizvodnje = 2017, SlikaUrl = "https://cf-cdn-v5.audi.at/media/GalleryThumbnails_Slider_Image_Component/58595-567425-slider-347018/dh-1169-a9ad28/78b2a014/1675153614/1920x1080-aq7-191002-1-oe.jpg", KategorijaId = 3 },
                new Automobil() { Id = 4, Naziv = "Kia Sportage", Cijena = 230000, GodinaProizvodnje = 2022, SlikaUrl = "https://static.jutarnji.hr/images/slike/2021/07/07/11693257.jpg", KategorijaId = 4 },
                new Automobil() { Id = 5, Naziv = "BMW X4", Cijena = 297000, GodinaProizvodnje = 2016, SlikaUrl = "https://www.motortrend.com/uploads/2022/10/2023-BMW-X4-M40i-exterior-8.jpg", KategorijaId = 5 }
                );
        }
    }
}
