

using Grpc.Net.Client;
using gRPC_Server.Protos;

try
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Aplicação iniciada.");

    // Criando um canal de comunicação que será utilizado por ambos os serviços.
    using var channel = GrpcChannel.ForAddress("https://localhost:7096");

    // Cliente que consumirá os métodos do serviço de Cálculo Geométrico Plano.
    var clientCalculoPlano = new CalculoGeometricoPlano.CalculoGeometricoPlanoClient(channel);

    // Consumindo dois métodos do serviço de Cálculo Geométrico Plano.
    var replyAreaTriangulo = await clientCalculoPlano.AreaTrianguloAsync(new Triangulo { Base = 10, Altura = 20 });
    var replyAreaRetangulo = await clientCalculoPlano.AreaRetanguloAsync(new Retangulo { Comprimento = 20, Largura = 10 });

    // Exibição dos resultados dos métodos de cálculos planos.
    Console.WriteLine("\n═══> Serviço de Cálculo Geométrico Plano <═══");
    Console.WriteLine($"Triângulo de base 10 e altura 20 possue uma área de: {replyAreaTriangulo.Area_}");
    Console.WriteLine($"Retângulo de comprimento 20 largura 10 possui uma área de: {replyAreaRetangulo.Area_}");

    // Criando um client que consumirá os serviços de Cáluclo Geométrico Volumétrico.
    var clientCalculoVolumetrico = new CalculoGeometricoVolumetrico.CalculoGeometricoVolumetricoClient(channel);
    
    // Consumindo dois métodos do serviço de Cálculo Geométrico Volumétrico.
    var replyVolumePiramideBaseQuadrada = await clientCalculoVolumetrico.VolumePiramideBaseQuadradaAsync
        (new PiramideBaseQuadrada { AreaBase = 100, Altura = 15});
    var replyVolumeParalelepipedo = await clientCalculoVolumetrico.VolumeParalelepipedoAsync
        (new Paralelepipedo { AreaBase = 100, Altura = 20});

    // Exibição dos resultados dos métodos de cálculos volumétricos.
    Console.WriteLine("\n═══> Serviço de Cálculo Geométrico Volumétrico <═══");
    Console.WriteLine($"Pirâmide de base quadrada com área da base 100 e altura 15 possue um volume de: " +
        $"{replyVolumePiramideBaseQuadrada.Volume_}");
    Console.WriteLine($"Paralelepipedo com área de base de 100 e altura de 20 possue um volume de: " +
        $"{replyVolumeParalelepipedo.Volume_}");
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