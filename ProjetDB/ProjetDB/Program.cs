using Microsoft.EntityFrameworkCore;
using People.BL;
using People.DAL;
using People.Model;

namespace ProjetDB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddScoped<IpeopleRepository, PeopleRepository>();
            builder.Services.AddScoped<IPeopleService, PeopleService>();
            builder.Services.AddDbContext<PeopleContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("PeopleConnectionString"));
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}