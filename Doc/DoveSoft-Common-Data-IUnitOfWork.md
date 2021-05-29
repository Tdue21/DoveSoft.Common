#### [DoveSoft.Common](./index.md 'index')
### [DoveSoft.Common.Data](./DoveSoft-Common-Data.md 'DoveSoft.Common.Data')
## IUnitOfWork Interface
  
```csharp
public interface IUnitOfWork :
DoveSoft.Common.IDisposing,
System.IDisposable
```
Derived  
&#8627; [EntityUnitOfWork&lt;TDbContext&gt;](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext-.md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;')  

Implements [IDisposing](./DoveSoft-Common-IDisposing.md 'DoveSoft.Common.IDisposing'), [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  
### Methods
- [GetRepository&lt;TEntity&gt;()](./DoveSoft-Common-Data-IUnitOfWork-GetRepository-TEntity-().md 'DoveSoft.Common.Data.IUnitOfWork.GetRepository&lt;TEntity&gt;()')
- [SaveChanges()](./DoveSoft-Common-Data-IUnitOfWork-SaveChanges().md 'DoveSoft.Common.Data.IUnitOfWork.SaveChanges()')
- [SaveChangesAsync(System.Threading.CancellationToken)](./DoveSoft-Common-Data-IUnitOfWork-SaveChangesAsync(System-Threading-CancellationToken).md 'DoveSoft.Common.Data.IUnitOfWork.SaveChangesAsync(System.Threading.CancellationToken)')
