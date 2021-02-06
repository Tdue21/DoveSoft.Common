#### [DoveSoft.Common](./index.md 'index')
### [DoveSoft.Common.Extensions](./DoveSoft-Common-Extensions.md 'DoveSoft.Common.Extensions').[ServiceCollectionExtensions](./DoveSoft-Common-Extensions-ServiceCollectionExtensions.md 'DoveSoft.Common.Extensions.ServiceCollectionExtensions')
## ServiceCollectionExtensions.AddDataDependencyInjection&lt;TDbContext&gt;(Microsoft.Extensions.DependencyInjection.IServiceCollection) Method
Adds the data dependency injection.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddDataDependencyInjection<TDbContext>(this Microsoft.Extensions.DependencyInjection.IServiceCollection collection)
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext;
```
#### Type parameters
<a name='DoveSoft-Common-Extensions-ServiceCollectionExtensions-AddDataDependencyInjection-TDbContext-(Microsoft-Extensions-DependencyInjection-IServiceCollection)-TDbContext'></a>
`TDbContext`  
The type of the database context.  

Constraints [Microsoft.EntityFrameworkCore.DbContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContext 'Microsoft.EntityFrameworkCore.DbContext')  
  
#### Parameters
<a name='DoveSoft-Common-Extensions-ServiceCollectionExtensions-AddDataDependencyInjection-TDbContext-(Microsoft-Extensions-DependencyInjection-IServiceCollection)-collection'></a>
`collection` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The collection.  
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
  
