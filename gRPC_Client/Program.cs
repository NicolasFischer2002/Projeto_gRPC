
using Grpc.Core;
using Grpc.Net.Client;
using gRPC_Client.Services;
using gRPC_Server.Protos;

try
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Aplicação iniciada.");

    // Obtenha o token JWT do serviço de autenticação
    string token = await AuthenticationService.GetTokenJWT();

    // Crie os headers e adicione o token JWT como cabeçalho de autorização
    var headers = new Metadata();
    headers.Add("Authorization", $"Bearer {token}");

    // Criando um canal de comunicação que será utilizado por ambos os serviços.
    using var channel = GrpcChannel.ForAddress("https://localhost:7096");

    // Cliente que consumirá os métodos do serviço de Cálculo Geométrico Plano.
    var clientCalculoPlano = new CalculoGeometricoPlano.CalculoGeometricoPlanoClient(channel);

    // Consumindo dois métodos do serviço de Cálculo Geométrico Plano.
    var replyAreaTriangulo = await clientCalculoPlano.AreaTrianguloAsync
        (new TrianguloRequest { Base = 10, Altura = 20 }, headers);
    var replyAreaRetangulo = await clientCalculoPlano.AreaRetanguloAsync
        (new RetanguloRequest { Comprimento = 20, Largura = 10 }, headers);

    // Exibição dos resultados dos métodos de cálculos planos.
    Console.WriteLine("\n═══> Serviço de Cálculo Geométrico Plano <═══");
    Console.WriteLine($"Triângulo de base 10 e altura 20 possue uma área de: " +
        $"{replyAreaTriangulo.Area}");
    Console.WriteLine($"Retângulo de comprimento 20 largura 10 possui uma área de: " +
        $"{replyAreaRetangulo.Area}");

    // Criando um client que consumirá os serviços de Cáluclo Geométrico Volumétrico.
    var clientCalculoVolumetrico = new CalculoGeometricoVolumetrico
        .CalculoGeometricoVolumetricoClient(channel);
    
    // Consumindo dois métodos do serviço de Cálculo Geométrico Volumétrico.
    var replyVolumePiramideBaseQuadrada = await clientCalculoVolumetrico
        .VolumePiramideBaseQuadradaAsync(new PiramideBaseQuadradaRequest 
        { AreaBase = 100, Altura = 15}, headers);

    var replyVolumeParalelepipedo = await clientCalculoVolumetrico
        .VolumeParalelepipedoAsync(new ParalelepipedoRequest 
        { AreaBase = 100, Altura = 20}, headers);

    // Exibição dos resultados dos métodos de cálculos volumétricos.
    Console.WriteLine("\n═══> Serviço de Cálculo Geométrico Volumétrico <═══");
    Console.WriteLine($"Pirâmide de base quadrada com área da base 100 e altura " +
        $"15 possue um volume de: " +
        $"{replyVolumePiramideBaseQuadrada.Volume}");
    Console.WriteLine($"Paralelepipedo com área de base de 100 e altura de " +
        $"20 possue um volume de: " +
        $"{replyVolumeParalelepipedo.Volume}");
}
catch (Exception erro)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\nErro inesperado: {erro.Message}");
}
finally
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nAplicação finalizada.");
}