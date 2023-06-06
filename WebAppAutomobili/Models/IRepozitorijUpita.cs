namespace WebAppAutomobili.Models
{
    public interface IRepozitorijUpita
    {
        IEnumerable<Automobil> PopisAutomobil();
        void Create(Automobil automobil);
        void Delete(Automobil automobil);
        void Update(Automobil automobil);
        int SljedeciId();
        int KategorijaSljedeciId();
        Automobil DohvatiAutomobilSIdom(int id);

        IEnumerable<Kategorija> PopisKategorija();
        void Create(Kategorija kategorija);
        void Delete(Kategorija kategorija);
        void Update(Kategorija kategorija);
        Kategorija DohvatiKategorijuSIdom(int id);
      
    }
}
