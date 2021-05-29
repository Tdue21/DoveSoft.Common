#### [DoveSoft.Common](./index.md 'index')
### [DoveSoft.Common.Data](./DoveSoft-Common-Data.md 'DoveSoft.Common.Data')
## EntityUnitOfWork&lt;TDbContext&gt; Class
Entity Framework Core specific [IUnitOfWork](./DoveSoft-Common-Data-IUnitOfWork.md 'DoveSoft.Common.Data.IUnitOfWork') implementation.  
```csharp
public class EntityUnitOfWork<TDbContext> : DoveSoft.Common.Disposable,
DoveSoft.Common.Data.IUnitOfWork,
DoveSoft.Common.IDisposing,
System.IDisposable
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Disposable](./DoveSoft-Common-Disposable.md 'DoveSoft.Common.Disposable') &#129106; EntityUnitOfWork&lt;TDbContext&gt;  

Implements [IUnitOfWork](./DoveSoft-Common-Data-IUnitOfWork.md 'DoveSoft.Common.Data.IUnitOfWork'), [IDisposing](./DoveSoft-Common-IDisposing.md 'DoveSoft.Common.IDisposing'), [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  
#### Type parameters
<a name='DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--TDbContext'></a>
`TDbContext`  

Constraints [Microsoft.EntityFrameworkCore.DbContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContext 'Microsoft.EntityFrameworkCore.DbContext')  
  
### Constructors
- [EntityUnitOfWork()](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--EntityUnitOfWork().md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.EntityUnitOfWork()')
- [EntityUnitOfWork(TDbContext)](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--EntityUnitOfWork(TDbContext).md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.EntityUnitOfWork(TDbContext)')
### Properties
- [HasEnded](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--HasEnded.md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.HasEnded')
### Methods
- [Dispose(bool)](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--Dispose(bool).md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.Dispose(bool)')
- [GetContext()](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--GetContext().md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.GetContext()')
- [GetRepository&lt;TEntity&gt;()](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--GetRepository-TEntity-().md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.GetRepository&lt;TEntity&gt;()')
- [SaveChanges()](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--SaveChanges().md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.SaveChanges()')
- [SaveChangesAsync(System.Threading.CancellationToken)](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--SaveChangesAsync(System-Threading-CancellationToken).md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.SaveChangesAsync(System.Threading.CancellationToken)')
