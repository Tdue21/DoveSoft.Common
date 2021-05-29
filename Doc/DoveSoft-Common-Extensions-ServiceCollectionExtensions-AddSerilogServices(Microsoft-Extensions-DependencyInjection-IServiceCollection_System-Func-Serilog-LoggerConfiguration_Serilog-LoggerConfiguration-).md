#### [DoveSoft.Common](./index.md 'index')
### [DoveSoft.Common.Extensions](./DoveSoft-Common-Extensions.md 'DoveSoft.Common.Extensions').[ServiceCollectionExtensions](./DoveSoft-Common-Extensions-ServiceCollectionExtensions.md 'DoveSoft.Common.Extensions.ServiceCollectionExtensions')
## ServiceCollectionExtensions.AddSerilogServices(Microsoft.Extensions.DependencyInjection.IServiceCollection, System.Func&lt;Serilog.LoggerConfiguration,Serilog.LoggerConfiguration&gt;) Method
Adds the serilog services.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddSerilogServices(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Func<Serilog.LoggerConfiguration,Serilog.LoggerConfiguration> configuration);
```
#### Parameters
<a name='DoveSoft-Common-Extensions-ServiceCollectionExtensions-AddSerilogServices(Microsoft-Extensions-DependencyInjection-IServiceCollection_System-Func-Serilog-LoggerConfiguration_Serilog-LoggerConfiguration-)-services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The services.  
  
<a name='DoveSoft-Common-Extensions-ServiceCollectionExtensions-AddSerilogServices(Microsoft-Extensions-DependencyInjection-IServiceCollection_System-Func-Serilog-LoggerConfiguration_Serilog-LoggerConfiguration-)-configuration'></a>
`configuration` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[Serilog.LoggerConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Serilog.LoggerConfiguration 'Serilog.LoggerConfiguration')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[Serilog.LoggerConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Serilog.LoggerConfiguration 'Serilog.LoggerConfiguration')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The configuration.  
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
  
