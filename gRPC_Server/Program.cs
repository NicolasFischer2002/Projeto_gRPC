using gRPC_Server.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Adiciona servi�os ao cont�iner.
builder.Services.AddGrpc();

// Configura a autentica��o JWT
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
            ValidAudience = "youraudience", // Substitua pelo seu p�blico
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("minha_chave_secreta_com_mais_de_32_caracteres")) // Substitua pela sua chave secreta
        };
    });

// Adiciona o servi�o de autoriza��o
builder.Services.AddAuthorization();

var app = builder.Build();

// Configura o pipeline de requisi��es HTTP
app.UseRouting();

// Adiciona o middleware de autentica��o e autoriza��o
app.UseAuthentication();
app.UseAuthorization();

// Mapeamento dos servi�os que o servidor gRPC dever� atender.
app.MapGrpcService<CalculoGeometricoPlanoService>();
app.MapGrpcService<CalculoGeometricoVolumetricoService>();

app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();