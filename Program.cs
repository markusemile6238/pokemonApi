namespace AzuredApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
           

            var app = builder.Build();

            // permet d'associer des routes(endpoints) a une fonction
            app.MapControllers();
            app.Run();
        }
    }
}
