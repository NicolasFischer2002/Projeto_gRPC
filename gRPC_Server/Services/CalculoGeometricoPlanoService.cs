using gRPC_Server.Protos;
using Grpc.Core;
using Microsoft.AspNetCore.Authorization;

namespace gRPC_Server.Services
{
    // Implementa o serviço definido no arquivo .proto, especificamente a base gerada
    // para 'CalculoGeometricoPlano'.
    public class CalculoGeometricoPlanoService : CalculoGeometricoPlano.CalculoGeometricoPlanoBase
    {
        // Logger para registrar informações, avisos e erros.
        private readonly ILogger<CalculoGeometricoPlanoService> _logger;

        // Construtor que injeta o logger.
        public CalculoGeometricoPlanoService(ILogger<CalculoGeometricoPlanoService> logger)
        {
            _logger = logger;
        }

        // Método que implementa o cálculo da área de um triângulo.
        // Recebe uma mensagem 'Triangulo' e retorna uma mensagem 'Area'.
        [Authorize]
        public override Task<AreaReply> AreaTriangulo(TrianguloRequest request, ServerCallContext context)
        {
            // Calcula a área do triângulo usando a fórmula: 0.5 * base * altura.
            double areaTriangulo = 0.5 * request.Altura * request.Base;

            // Retorna o resultado dentro de uma mensagem 'Area'.
            return Task.FromResult(new AreaReply
            {
                Area = areaTriangulo
            });
        }

        // Método que implementa o cálculo da área de um retângulo.
        // Recebe uma mensagem 'Retangulo' e retorna uma mensagem 'Area'.
        [Authorize]
        public override Task<AreaReply> AreaRetangulo(RetanguloRequest request, ServerCallContext context)
        {
            // Calcula a área do retângulo usando a fórmula: comprimento * largura.
            double areaRetangulo = request.Comprimento * request.Largura;

            // Retorna o resultado dentro de uma mensagem 'Area'.
            return Task.FromResult(new AreaReply
            {
                Area = areaRetangulo
            });
        }
    }
}