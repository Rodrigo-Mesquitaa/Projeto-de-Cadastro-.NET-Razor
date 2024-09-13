using InscricaoApp.Api.Data;
using InscricaoApp.Api.Repositories;
using InscricaoApp.Api.Services;
using InscricaoApp.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona servi�os ao cont�iner de inje��o de depend�ncia
builder.Services.AddControllers();

// Configura o contexto do banco de dados
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configura o CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

// Adiciona o Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adiciona os reposit�rios e servi�os
builder.Services.AddScoped<IParticipanteRepository, ParticipanteRepository>();
builder.Services.AddScoped<IPacoteRepository, PacoteRepository>();
builder.Services.AddScoped<IAtividadeRepository, AtividadeRepository>();
builder.Services.AddScoped<ParticipanteService>();
builder.Services.AddScoped<PacoteService>();
builder.Services.AddScoped<AtividadeService>();

var app = builder.Build();

// Configura o pipeline de requisi��es HTTP
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// Configura��o do CORS
app.UseCors("AllowAllOrigins");

// Configura��o do Swagger
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "InscricaoApp API V1");
});

app.UseAuthorization();
app.MapControllers();

app.Run();
