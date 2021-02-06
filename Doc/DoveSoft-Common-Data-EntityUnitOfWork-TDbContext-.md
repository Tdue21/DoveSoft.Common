#### [DoveSoft.Common](./index.md 'index')
### [DoveSoft.Common.Data](./DoveSoft-Common-Data.md 'DoveSoft.Common.Data')
## EntityUnitOfWork&lt;TDbContext&gt; Class
Entity Framework Core specific [IUnitOfWork](./DoveSoft-Common-Data-IUnitOfWork.md 'DoveSoft.Common.Data.IUnitOfWork') implementation.  
```csharp
public class EntityUnitOfWork<TDbContext> :
DoveSoft.Common.Data.IUnitOfWork
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EntityUnitOfWork&lt;TDbContext&gt;  

Implements [IUnitOfWork](./DoveSoft-Common-Data-IUnitOfWork.md 'DoveSoft.Common.Data.IUnitOfWork')  
#### Type parameters
<a name='DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--TDbContext'></a>
`TDbContext`  

Constraints [Microsoft.EntityFrameworkCore.DbContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContext 'Microsoft.EntityFrameworkCore.DbContext')  
  
### Constructors
- [EntityUnitOfWork()](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--EntityUnitOfWork().md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.EntityUnitOfWork()')
- [EntityUnitOfWork(TDbContext)](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--EntityUnitOfWork(TDbContext).md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.EntityUnitOfWork(TDbContext)')
### Methods
- [GetContext()](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--GetContext().md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.GetContext()')
- [GetRepository&lt;TEntity&gt;()](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--GetRepository-TEntity-().md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.GetRepository&lt;TEntity&gt;()')
- [SaveChanges()](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--SaveChanges().md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.SaveChanges()')
- [SaveChangesAsync(System.Threading.CancellationToken)](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--SaveChangesAsync(System-Threading-CancellationToken).md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.SaveChangesAsync(System.Threading.CancellationToken)')
