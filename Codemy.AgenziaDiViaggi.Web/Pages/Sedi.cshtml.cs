using Codemy.AgenziaDiViaggi.Web.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

using Codemy.AgenziaDiViaggi.Web.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace Codemy.AgenziaDiViaggi.Web.Pages
{
    public class SediModel : PageModel
    {
        public List<Sede> ListaSedi { get; set; }
        [BindProperty]
        public string Ricerca { get; set; }
        [BindProperty]
        public string CercaUnaSede { get; set; }

        public SediModel()
        {
            CercaUnaSede = string.Empty;
            Ricerca = string.Empty;
            ListaSedi = new List<Sede>();
        }

        private List<Sede> RicercaPerPropriet‡(List<Sede> ListaSedi, string propriet‡Selezionata, string ricerca)
        {
            return (from sede in ListaSedi
                    let propriet‡ = typeof(Sede).GetProperty(propriet‡Selezionata)
                    let valorePropriet‡ = propriet‡.GetValue(sede) as string
                    where valorePropriet‡.IndexOf(ricerca.Trim(), StringComparison.OrdinalIgnoreCase) != -1
                    select sede).ToList();
    }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        string nomeFile = "./wwwroot/json/ListaSedi.json";
        using (FileStream fs = System.IO.File.OpenRead(nomeFile))
        {
            var DeserializedSedi = JsonSerializer.Deserialize<Sedi>(fs);
            if (String.IsNullOrWhiteSpace(Ricerca) || String.IsNullOrWhiteSpace(CercaUnaSede))
            {
                ListaSedi = DeserializedSedi.ListaSedi;
            }
            else
            {
                ListaSedi = RicercaPerPropriet‡(DeserializedSedi.ListaSedi, CercaUnaSede, Ricerca);
            }
        }
    }
}
}
