var builder = WebApplication.CreateBuilder(args);

// Adiciona servi�os ao cont�iner de inje��o de depend�ncia
builder.Services.AddRazorPages();

// Configura��o dos servi�os HTTP
builder.Services.AddHttpClient("ParticipanteService", client =>
{
    client.BaseAddress = new Uri("https://localhost:7015/"); // URL do Micro Servi�o Participante
});
builder.Services.AddHttpClient("PacoteAtividadeService", client =>
{
    client.BaseAddress = new Uri("https://localhost:7015/"); // URL do Micro Servi�o PacoteAtividade
});

var app = builder.Build();

// Configura o pipeline de requisi��es HTTP
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();
app.MapRazorPages();

app.Run();
