using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace TelescopeControl.Alpaca
{
    public class AlpacaServer
    {
        private readonly WebApplication _app;

        public AlpacaServer(AscomDeviceApiHandler[] handlers)
        {
            var builder = WebApplication.CreateBuilder();
            builder.WebHost.UseUrls("http://localhost:8080");

            _app = builder.Build();

            foreach (var handler in handlers)
            {
                handler.RegisterRoutes(_app);
            }

        }

        public void Start(CancellationToken cancellationToken)
        {
            _app.RunAsync(cancellationToken);
        }

        public void Stop()
        {
            _app.StopAsync().Wait();
        }
    }
}
