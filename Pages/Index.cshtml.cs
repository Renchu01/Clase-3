using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clase_3_Hprog.Models;
using Clase_3_Hprog.Services;
namespace Clase_3_Hprog.Pages;

public class IndexModel : PageModel
{
   public List<Movie> MovieList { get; set; }
[BindProperty]
public Movie newMovie{ get; set; }
    public IndexModel()
    {
        //Constructor        
    }

    public void OnGet()
    {
        MovieList = MovieService.GetAll();// Traemos todas nuestras peliculas
    }
    public IActionResult OnPost(){// SE UTILIZA PARA DEVOLVER UNA ACCION
        if(!ModelState.IsValid){
            return RedirectToPage("/Error");// me redirecciona a otra pagina
            
            }// Verifica si todo el modelo es valido
        MovieService.Add(newMovie);
        return RedirectToAction("get");// me genera una accion http nueva
    }
}
