using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Codemy.AgenziaDiViaggi.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        [Required(ErrorMessage = "ilcamponomeèobbligatorio")]
        [MaxLength(20,ErrorMessage = "ilcamponomeèobbligatorio")]
        public string nome{ get; set; }
        [BindProperty]
        [Required(ErrorMessage = "ilcamponomeèobbligatorio")]
        [MaxLength(20,ErrorMessage = "ilcamponomeèobbligatorio")]
        public string cognome { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "ilcamponomeèobbligatorio")]
        [MaxLength(20,ErrorMessage = "ilcamponomeèobbligatorio")]
        public string password { get; set; }  
        

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnPost()
        {
            

            if (nome == "pippo" && cognome == "topolino" && password == "1234")
            {
                return RedirectToPage("Privacy");
            }
            return Page();
        }
    }
}