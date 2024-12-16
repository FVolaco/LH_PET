using LH_Pets;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Projeto Web - LH Pets versao 1");

Banco banco = new Banco();

app.MapGet("/listaclientes", (HttpContext context) => {
    context.Response.WriteAsync(banco.GetListaString());
});

app.UseStaticFiles();

app.Run();
