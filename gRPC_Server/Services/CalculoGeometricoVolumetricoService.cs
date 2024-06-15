using gRPC_Server.Protos;
using Grpc.Core;

namespace gRPC_Server.Services
{
    // Implementa o serviço definido no arquivo .proto, especificamente a base gerada para 'CalculoGeometricoVolumetrico'.
    public class CalculoGeometricoVolumetricoService : CalculoGeometricoVolumetrico.CalculoGeometricoVolumetricoBase
    {
        // Logger para registrar informações, avisos e erros.
        private readonly ILogger<CalculoGeometricoVolumetricoService> _logger;

        // Construtor que injeta o logger.
        public CalculoGeometricoVolumetricoService(ILogger<CalculoGeometricoVolumetricoService> logger)
        {
            _logger = logger;
        }

        // Método que implementa o cálculo do volume de uma pirâmide de base quadrada.
        // Recebe uma mensagem 'PiramideBaseQuadrada' e retorna uma mensagem 'Volume'.
        public override Task<Volume> VolumePiramideBaseQuadrada(PiramideBaseQuadrada request, ServerCallContext context)
        {
            // Calcula o volume da pirâmide usando a fórmula: (1/3) * (área da base * altura).
            double volume = (1.0 / 3.0) * (request.AreaBase * request.Altura);

            // Retorna o resultado dentro de uma mensagem 'Volume'.
            return Task.FromResult(new Volume
            {
                Volume_ = volume
            });
        }

        // Método que implementa o cálculo do volume de um paralelepípedo.
        // Recebe uma mensagem 'Paralelepipedo' e retorna uma mensagem 'Volume'.
        public override Task<Volume> VolumeParalelepipedo(Paralelepipedo request, ServerCallContext context)
        {
            // Calcula o volume do paralelepípedo usando a fórmula: área da base * altura.
            double volume = request.AreaBase * request.Altura;

            // Retorna o resultado dentro de uma mensagem 'Volume'.
            return Task.FromResult(new Volume
            {
                Volume_ = volume
            });
        }
    }
}
