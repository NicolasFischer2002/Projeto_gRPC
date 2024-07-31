using gRPC_Server.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao contêiner.
builder.Services.AddGrpc();

// Configura a autenticação JWT
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = "yourissuer", // Substitua pelo seu emissor
            ValidAudience = "youraudience", // Substitua pelo seu público
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("minha_chave_secreta_com_mais_de_32_caracteres")) // Substitua pela sua chave secreta
        };
    });

// Adiciona o serviço de autorização
builder.Services.AddAuthorization();

var app = builder.Build();

// Configura o pipeline de requisições HTTP
app.UseRouting();

// Adiciona o middleware de autenticação e autorização
app.UseAuthentication();
app.UseAuthorization();

// Mapeamento dos serviços que o servidor gRPC deverá atender.
app.MapGrpcService<CalculoGeometricoPlanoService>();
app.MapGrpcService<CalculoGeometricoVolumetricoService>();

app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();