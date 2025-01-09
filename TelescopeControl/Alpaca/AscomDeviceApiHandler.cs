using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using TelescopeControl.Alpaca;

public abstract class AscomDeviceApiHandler
{
    public string DeviceType;
    public int DeviceNumber;

    public AscomDeviceApiHandler(string deviceType, int deviceNumber)
    {
        DeviceType = deviceType;
        DeviceNumber = deviceNumber;
    }

    public abstract void RegisterRoutes(WebApplication app);
    

    public void RegisterCommonRoutes(WebApplication app)
    {

    }

    private string BuildPath(string path)
    {
        return $"/api/v1/{DeviceType}/{DeviceNumber}/{path}";
    }

    public void RegisterRoute<T>(WebApplication app, string method, string path, Func<HttpRequest, T> handler)
    {
        AscomEndpointWrapper.MapEndpoint(app, method, BuildPath(path), handler);
    }

}
