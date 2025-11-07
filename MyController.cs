using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace AzuredApi
{
    public class MyController(IConfiguration configuration) : ControllerBase
    {


        [HttpGet("api/hello")]
        public string Hello()
        {
            return "Hello wokld";
        }


        [HttpGet("/api/pokemon")]
        public List<Pokemon> GetPokemons()
        {
          
            try
            {

                using SqlConnection connection = new(configuration.GetConnectionString("Main"));
                List<Pokemon> pokemons = connection.Query<Pokemon>("SELECT * FROM Pokemons").ToList();
                return pokemons;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
  }


