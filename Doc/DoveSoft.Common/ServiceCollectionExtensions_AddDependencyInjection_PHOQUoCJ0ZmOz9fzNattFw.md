#### [DoveSoft.Common](readme.md 'readme')
### [DoveSoft.Common.Extensions](DoveSoft_Common_Extensions.md 'DoveSoft.Common.Extensions').[ServiceCollectionExtensions](ServiceCollectionExtensions.md 'DoveSoft.Common.Extensions.ServiceCollectionExtensions')
## ServiceCollectionExtensions.AddDependencyInjection(IServiceCollection, Action&lt;Dictionary&lt;Type,Type&gt;&gt;) Method
Adds the dependency injection.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddDependencyInjection(this Microsoft.Extensions.DependencyInjection.IServiceCollection collection, System.Action<System.Collections.Generic.Dictionary<System.Type,System.Type>> mappingCollection);
```
#### Parameters
<a name='DoveSoft_Common_Extensions_ServiceCollectionExtensions_AddDependencyInjection(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_System_Collections_Generic_Dictionary_System_Type_System_Type__)_collection'></a>
`collection` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The collection.
  
<a name='DoveSoft_Common_Extensions_ServiceCollectionExtensions_AddDependencyInjection(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_System_Collections_Generic_Dictionary_System_Type_System_Type__)_mappingCollection'></a>
`mappingCollection` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The mapping collection.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
collection
