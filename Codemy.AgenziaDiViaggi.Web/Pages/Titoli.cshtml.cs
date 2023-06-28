using Codemy.AgenziaDiViaggi.Web.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Text.Json;

namespace Codemy.AgenziaDiViaggi.Web.Pages
{
    public class TitoliModel : PageModel
    {
        public List<Titolo> Titoli { get; set; }

        public TitoliModel()
        {
            string nomeFile = "./wwwroot/json/TitoliDiStudio.json";

            using (FileStream fs = System.IO.File.OpenRead(nomeFile))
            { 
            var obj= JsonSerializer.Deserialize<Titoli>(fs);
                Titoli= obj.TitoliDiStudio ;
            }
        }


        public void OnGet()
        {
        }
    }
}
