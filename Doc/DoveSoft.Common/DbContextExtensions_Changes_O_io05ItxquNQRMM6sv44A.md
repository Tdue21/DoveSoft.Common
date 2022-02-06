#### [DoveSoft.Common](readme.md 'readme')
### [DoveSoft.Common.Extensions](DoveSoft_Common_Extensions.md 'DoveSoft.Common.Extensions').[DbContextExtensions](DbContextExtensions.md 'DoveSoft.Common.Extensions.DbContextExtensions')
## DbContextExtensions.Changes(DbContext, EntityState) Method
Returns an [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') list of objects of the supplied [Microsoft.EntityFrameworkCore.EntityState](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.EntityState 'Microsoft.EntityFrameworkCore.EntityState').  
```csharp
public static System.Collections.Generic.IEnumerable<object> Changes(this Microsoft.EntityFrameworkCore.DbContext context, Microsoft.EntityFrameworkCore.EntityState state);
```
#### Parameters
<a name='DoveSoft_Common_Extensions_DbContextExtensions_Changes(Microsoft_EntityFrameworkCore_DbContext_Microsoft_EntityFrameworkCore_EntityState)_context'></a>
`context` [Microsoft.EntityFrameworkCore.DbContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContext 'Microsoft.EntityFrameworkCore.DbContext')  
The [Microsoft.EntityFrameworkCore.DbContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContext 'Microsoft.EntityFrameworkCore.DbContext') to extract changes from.
  
<a name='DoveSoft_Common_Extensions_DbContextExtensions_Changes(Microsoft_EntityFrameworkCore_DbContext_Microsoft_EntityFrameworkCore_EntityState)_state'></a>
`state` [Microsoft.EntityFrameworkCore.EntityState](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.EntityState 'Microsoft.EntityFrameworkCore.EntityState')  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
