using gRPC_Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
// Mapeamento dos servi�os que o servidor gRPC dever� atender.
// Ambos os m�todos informam ao servidor gRPC que esses dois
// servi�os estar�o dispon�veis para serem chamados pelos clientes.
// Quando uma requisi��o gRPC � recebida, o servidor determina qual
// servi�o deve tratar a requisi��o com base no tipo de chamada e no servi�o registrado.
app.MapGrpcService<CalculoGeometricoPlanoService>();
app.MapGrpcService<CalculoGeometricoVolumetricoService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
