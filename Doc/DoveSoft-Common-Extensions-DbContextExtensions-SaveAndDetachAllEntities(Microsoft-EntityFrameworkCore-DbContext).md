#### [DoveSoft.Common](./index.md 'index')
### [DoveSoft.Common.Extensions](./DoveSoft-Common-Extensions.md 'DoveSoft.Common.Extensions').[DbContextExtensions](./DoveSoft-Common-Extensions-DbContextExtensions.md 'DoveSoft.Common.Extensions.DbContextExtensions')
## DbContextExtensions.SaveAndDetachAllEntities(Microsoft.EntityFrameworkCore.DbContext) Method
Saves and then detaches all entities from the [Microsoft.EntityFrameworkCore.DbContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContext 'Microsoft.EntityFrameworkCore.DbContext').  
```csharp
public static System.Threading.Tasks.Task SaveAndDetachAllEntities(this Microsoft.EntityFrameworkCore.DbContext context);
```
#### Parameters
<a name='DoveSoft-Common-Extensions-DbContextExtensions-SaveAndDetachAllEntities(Microsoft-EntityFrameworkCore-DbContext)-context'></a>
`context` [Microsoft.EntityFrameworkCore.DbContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContext 'Microsoft.EntityFrameworkCore.DbContext')  
The context.  
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
context  
