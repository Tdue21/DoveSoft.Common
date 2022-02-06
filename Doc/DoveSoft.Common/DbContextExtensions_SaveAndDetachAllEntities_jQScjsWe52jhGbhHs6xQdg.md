#### [DoveSoft.Common](readme.md 'readme')
### [DoveSoft.Common.Extensions](DoveSoft_Common_Extensions.md 'DoveSoft.Common.Extensions').[DbContextExtensions](DbContextExtensions.md 'DoveSoft.Common.Extensions.DbContextExtensions')
## DbContextExtensions.SaveAndDetachAllEntities(DbContext) Method
Saves and then detaches all entities from the [Microsoft.EntityFrameworkCore.DbContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContext 'Microsoft.EntityFrameworkCore.DbContext').  
```csharp
public static System.Threading.Tasks.Task SaveAndDetachAllEntities(this Microsoft.EntityFrameworkCore.DbContext context);
```
#### Parameters
<a name='DoveSoft_Common_Extensions_DbContextExtensions_SaveAndDetachAllEntities(Microsoft_EntityFrameworkCore_DbContext)_context'></a>
`context` [Microsoft.EntityFrameworkCore.DbContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContext 'Microsoft.EntityFrameworkCore.DbContext')  
The context.
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
context
