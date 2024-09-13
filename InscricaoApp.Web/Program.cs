var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao contêiner de injeção de dependência
builder.Services.AddRazorPages();

// Configuração dos serviços HTTP
builder.Services.AddHttpClient("ParticipanteService", client =>
{
    client.BaseAddress = new Uri("https://localhost:7015/"); // URL do Micro Serviço Participante
});
builder.Services.AddHttpClient("PacoteAtividadeService", client =>
{
    client.BaseAddress = new Uri("https://localhost:7015/"); // URL do Micro Serviço PacoteAtividade
});

var app = builder.Build();

// Configura o pipeline de requisições HTTP
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();
app.MapRazorPages();

app.Run();
