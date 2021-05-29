#### [DoveSoft.Common](./index.md 'index')
### [DoveSoft.Common.Extensions](./DoveSoft-Common-Extensions.md 'DoveSoft.Common.Extensions').[ServiceCollectionExtensions](./DoveSoft-Common-Extensions-ServiceCollectionExtensions.md 'DoveSoft.Common.Extensions.ServiceCollectionExtensions')
## ServiceCollectionExtensions.AddDependencyInjection(Microsoft.Extensions.DependencyInjection.IServiceCollection, System.Action&lt;System.Collections.Generic.Dictionary&lt;System.Type,System.Type&gt;&gt;) Method
Adds the dependency injection.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddDependencyInjection(this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, System.Action<System.Collections.Generic.Dictionary<System.Type,System.Type>> mappingCollection);
```
#### Parameters
<a name='DoveSoft-Common-Extensions-ServiceCollectionExtensions-AddDependencyInjection(Microsoft-Extensions-DependencyInjection-IServiceCollection_System-Action-System-Collections-Generic-Dictionary-System-Type_System-Type--)-collection'></a>
`collection` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The collection.  
  
<a name='DoveSoft-Common-Extensions-ServiceCollectionExtensions-AddDependencyInjection(Microsoft-Extensions-DependencyInjection-IServiceCollection_System-Action-System-Collections-Generic-Dictionary-System-Type_System-Type--)-mappingCollection'></a>
`mappingCollection` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The mapping collection.  
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
collection  
