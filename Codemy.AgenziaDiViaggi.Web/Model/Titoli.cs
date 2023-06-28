namespace Codemy.AgenziaDiViaggi.Web.Model
{
    public class Titoli
    {
        public List<Titolo> TitoliDiStudio { get; set; }
        public Titoli() 
        {
        TitoliDiStudio = new List<Titolo>();
        }
    }
}
