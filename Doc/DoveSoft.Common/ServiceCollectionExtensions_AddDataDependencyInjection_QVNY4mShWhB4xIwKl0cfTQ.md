#### [DoveSoft.Common](readme.md 'readme')
### [DoveSoft.Common.Extensions](DoveSoft_Common_Extensions.md 'DoveSoft.Common.Extensions').[ServiceCollectionExtensions](ServiceCollectionExtensions.md 'DoveSoft.Common.Extensions.ServiceCollectionExtensions')
## ServiceCollectionExtensions.AddDataDependencyInjection&lt;TDbContext&gt;(IServiceCollection) Method
Adds the data dependency injection.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddDataDependencyInjection<TDbContext>(this Microsoft.Extensions.DependencyInjection.IServiceCollection collection)
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext;
```
#### Type parameters
<a name='DoveSoft_Common_Extensions_ServiceCollectionExtensions_AddDataDependencyInjection_TDbContext_(Microsoft_Extensions_DependencyInjection_IServiceCollection)_TDbContext'></a>
`TDbContext`  
The type of the database context.
  
#### Parameters
<a name='DoveSoft_Common_Extensions_ServiceCollectionExtensions_AddDataDependencyInjection_TDbContext_(Microsoft_Extensions_DependencyInjection_IServiceCollection)_collection'></a>
`collection` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The collection.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
