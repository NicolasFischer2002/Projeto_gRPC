using Grpc.Core;
using gRPC_TokenProvider.NovaPasta;
using gRPC_TokenProvider.Protos;

namespace gRPC_TokenProvider.Services
{
    public class AuthenticationService : Authentication.AuthenticationBase
    {
        private readonly ILogger<AuthenticationService> _logger;

        public AuthenticationService(ILogger<AuthenticationService> logger)
        {
            _logger = logger;
        }

        public override Task<TokenReply> GetTokenJWT(UserRequest request,
            ServerCallContext context)
        {
            return Task.FromResult(new TokenReply
            {
                Token = JwtToken.GenerateJwtToken("1")
            });
        }
    }
}