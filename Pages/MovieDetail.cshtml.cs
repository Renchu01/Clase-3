using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clase_3_Hprog.Models;
using Clase_3_Hprog.Services;
namespace Clase_3_Hprog.Pages
{
    // LO QUE ESTAMOS HACIENDO ACA ES CREAR UNA PAGINA DE MOVIE DETAIL 
    //PARA VER LOS DETALLES DE UNA PELICULA, LA IDEA ES HACER CLICK Y PODAMOS 
    // VER EN OTRA PAGINA ESA PELICULA CON TODA LA REVIEW MINUTOS ETC.
    public class MovieDetailModel : PageModel
    {
        public Movie MovieDetail { get; set; } = new();
        public void OnGet(string code)
        {
            if(code != null)
            {
                var responseServiceData = MovieService.Get(code);
                if(responseServiceData != null)
                {
                    MovieDetail = responseServiceData;
                }
            }


        }
        public IActionResult OnPostDelete(string code)
        {
            if(code!=null)
            {
                MovieService.Delete(code);
            }
            return RedirectToPage ("Index");
        }
    }
}
