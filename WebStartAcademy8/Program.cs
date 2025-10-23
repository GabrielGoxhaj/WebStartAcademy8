
using DbHandler;
using WebStartAcademy8.Models;

namespace WebStartAcademy8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            DbParams dbParams = new();
            dbParams.SqlConnectionString = builder.Configuration.GetConnectionString("DbAcademyOtto");
            builder.Services.AddSingleton(dbParams);

            SqlDbHandler sqlDbHandler = new(builder.Configuration.GetConnectionString("DbAcademyOtto"));
            builder.Services.AddSingleton(sqlDbHandler);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
