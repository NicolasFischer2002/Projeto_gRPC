using Grpc.Net.Client;
using gRPC_TokenProvider.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPC_Client.Services
{
    public class AuthenticationService
    {
        public static async Task<string> GetTokenJWT()
        {
            string URL = "https://localhost:7067";

            using var channel = GrpcChannel.ForAddress(URL);

            var authenticationService = new Authentication.AuthenticationClient(channel);

            var authenticationReply = await authenticationService.GetTokenJWTAsync
                (new UserRequest { Name = "Nicolas Fischer", Password = "12345"});

            return authenticationReply.Token;
        }
    }
}