using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Threading.Tasks;
using TelescopeControl.Alpaca.Response;

namespace TelescopeControl.Alpaca
{
    public static class AscomEndpointWrapper
    {

        public static void MapEndpoint<T>(WebApplication app, string method, string url, Func<HttpRequest, T> handler) 
        {


            app.Map(url, (HttpRequest request) =>
            {
                uint? clientTransactionID = 0;

                try
                {                    
                    // clientTransactionID can be passed as query parameter and as form data

                    if (uint.TryParse(request.Query["ClientTransactionID"], out var passedClientId))
                    {
                        clientTransactionID = passedClientId;
                    } else if (request.HasFormContentType && uint.TryParse(request.Form["ClientTransactionID"], out var passedClientId2))
                    {
                        clientTransactionID = passedClientId2;
                    }

                    var value = handler(request);
                    var response = AscomResponseHelper.CreateResponse(clientTransactionID, GenerateServerTransactionID(), value);
                    return Results.Json(response);
                }
                catch (Exception ex)
                {
                    var errorResponse = AscomResponseHelper.CreateResponse<object>(
                        clientTransactionID,
                        GenerateServerTransactionID(),
                        null,
                        exception: ex
                    );
                    return Results.Json(errorResponse);
                }
            }).WithMetadata(new HttpMethodMetadata(new[] { method }));
        }

        private static uint _serverTransactionID = 0;

        private static uint GenerateServerTransactionID()
        {
            return unchecked(++_serverTransactionID);
        }
    }
}
