using Clase_3_Hprog.Models;

namespace Clase_3_Hprog.Services;



public static class MovieService{
    static List<Movie> Movies { get; set; }

    static MovieService(){
        Movies = new List<Movie>
        {
            new Movie { Name = "Back to the Future", Code = "BTS", Category = "Ciencia Ficcion", Minutes = 110},
            new Movie { Name = "Avatar", Code = "AVT", Category = "Ciencia Ficcion", Minutes = 500},
            new Movie { Name = "Hannibal", Code = "HNL", Category = "Terror", Minutes = 180}
        };
    }

    public static List<Movie> GetAll() => Movies;//vamos a necesitar un metodo para traer todos los datos y todas las peliculas para listarlas
    //ADD
    //DELETE
    //Update
    public static void Add(Movie obj){
        if(obj == null){
            return;
        }
        Movies.Add(obj);
    }
public static void Delete(string code)
{
    var movieToDelete= Get(code);
    if(movieToDelete !=null)
    {
        Movies.Remove(movieToDelete);
    }
}
public static Movie? Get(string code) => Movies.FirstOrDefault(x => x.Code.ToLower() == code.ToLower());// Me trae el primer elemento que me encuentra bajo la condicion que nosotros le pasamos

}