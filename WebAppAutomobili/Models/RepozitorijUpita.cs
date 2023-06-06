using Microsoft.EntityFrameworkCore;

namespace WebAppAutomobili.Models
{
    public class RepozitorijUpita : IRepozitorijUpita
    {
        private readonly AppDbContext _appDbContext;
        public RepozitorijUpita(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

       
        public void Create(Automobil automobil)
        {
            _appDbContext.Add(automobil);
            _appDbContext.SaveChanges();
        }

        public void Create(Kategorija kategorija)
        {
            _appDbContext.Add(kategorija);
            _appDbContext.SaveChanges();
        }

        public void Delete(Automobil automobil)
        {
            _appDbContext.Remove(automobil);
            _appDbContext.SaveChanges();
        }

        public void Delete(Kategorija kategorija)
        {
            _appDbContext.Remove(kategorija);
            _appDbContext.SaveChanges();
        }

        public Automobil DohvatiAutomobilSIdom(int id)
        {
            return _appDbContext.Automobil.Include(k => k.Kategorija).FirstOrDefault(f => f.Id == id);

        }

        public Kategorija DohvatiKategorijuSIdom(int id)
        {
            return _appDbContext.Kategorija.Find(id);
        }

        public int KategorijaSljedeciId()
        {
            int zadnjiId = _appDbContext.Kategorija.Count();
            int sljedeciId = zadnjiId + 1;
            return sljedeciId;
        }

        public IEnumerable<Automobil> PopisAutomobil()
        {
            return _appDbContext.Automobil.Include(k => k.Kategorija);
        }

        public IEnumerable<Kategorija> PopisKategorija()
        {
            return _appDbContext.Kategorija;
        }

        public int SljedeciId()
        {
            int zadnjiId = _appDbContext.Automobil.Include(k => k.Kategorija).Max(x => x.Id);
            int SljedeciId = zadnjiId + 1;
            return zadnjiId; 
        }

        public void Update(Automobil automobil)
        {
            _appDbContext.Update(automobil);
            _appDbContext.SaveChanges();
        }

        public void Update(Kategorija kategorija)
        {
            _appDbContext.Update(kategorija);
            _appDbContext.SaveChanges();
        }
    }
}
