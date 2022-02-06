#### [DoveSoft.Common](readme.md 'readme')
### [DoveSoft.Common.Extensions](DoveSoft_Common_Extensions.md 'DoveSoft.Common.Extensions').[ServiceCollectionExtensions](ServiceCollectionExtensions.md 'DoveSoft.Common.Extensions.ServiceCollectionExtensions')
## ServiceCollectionExtensions.AddSerilogServices(IServiceCollection, Func&lt;LoggerConfiguration,LoggerConfiguration&gt;) Method
Adds the serilog services.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddSerilogServices(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Func<Serilog.LoggerConfiguration,Serilog.LoggerConfiguration> configuration);
```
#### Parameters
<a name='DoveSoft_Common_Extensions_ServiceCollectionExtensions_AddSerilogServices(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Func_Serilog_LoggerConfiguration_Serilog_LoggerConfiguration_)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The services.
  
<a name='DoveSoft_Common_Extensions_ServiceCollectionExtensions_AddSerilogServices(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Func_Serilog_LoggerConfiguration_Serilog_LoggerConfiguration_)_configuration'></a>
`configuration` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[Serilog.LoggerConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Serilog.LoggerConfiguration 'Serilog.LoggerConfiguration')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[Serilog.LoggerConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Serilog.LoggerConfiguration 'Serilog.LoggerConfiguration')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The configuration.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
