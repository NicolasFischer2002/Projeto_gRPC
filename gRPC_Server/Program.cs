using gRPC_Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
// Mapeamento dos serviços que o servidor gRPC deverá atender.
// Ambos os métodos informam ao servidor gRPC que esses dois
// serviços estarão disponíveis para serem chamados pelos clientes.
// Quando uma requisição gRPC é recebida, o servidor determina qual
// serviço deve tratar a requisição com base no tipo de chamada e no serviço registrado.
app.MapGrpcService<CalculoGeometricoPlanoService>();
app.MapGrpcService<CalculoGeometricoVolumetricoService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
