namespace AzuredApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddCors(b => b.AddDefaultPolicy(o =>
            {
                o.AllowAnyOrigin();
                o.AllowAnyMethod();
                o.AllowAnyHeader();
            }
           ));


            var app = builder.Build();
            app.UseCors();
                // permet d'associer des routes(endpoints) a une fonction
            app.MapControllers();
            app.Run();
        }
    }
}
