#### [DoveSoft.Common](readme.md 'readme')
### [DoveSoft.Common.Data](DoveSoft_Common_Data.md 'DoveSoft.Common.Data')
## EntityUnitOfWork&lt;TDbContext&gt; Class
Entity Framework Core specific [IUnitOfWork](IUnitOfWork.md 'DoveSoft.Common.Data.IUnitOfWork') implementation.  
```csharp
public class EntityUnitOfWork<TDbContext> : DoveSoft.Common.Disposable,
DoveSoft.Common.Data.IUnitOfWork,
DoveSoft.Common.IDisposing,
System.IDisposable
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
```
#### Type parameters
<a name='DoveSoft_Common_Data_EntityUnitOfWork_TDbContext__TDbContext'></a>
`TDbContext`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Disposable](Disposable.md 'DoveSoft.Common.Disposable') &#129106; EntityUnitOfWork&lt;TDbContext&gt;  

Implements [IUnitOfWork](IUnitOfWork.md 'DoveSoft.Common.Data.IUnitOfWork'), [IDisposing](IDisposing.md 'DoveSoft.Common.IDisposing'), [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  

| Constructors | |
| :--- | :--- |
| [EntityUnitOfWork()](EntityUnitOfWork_TDbContext__EntityUnitOfWork().md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.EntityUnitOfWork()') | Initializes a new instance of the [EntityUnitOfWork&lt;TDbContext&gt;](EntityUnitOfWork_TDbContext_.md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;') class.<br/> |
| [EntityUnitOfWork(TDbContext)](EntityUnitOfWork_TDbContext___ctor_hqYiH_0ar5QmtK_dVkfmSg.md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.EntityUnitOfWork(TDbContext)') | Initializes a new instance of the [EntityUnitOfWork&lt;TDbContext&gt;](EntityUnitOfWork_TDbContext_.md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;') class.<br/> |

| Properties | |
| :--- | :--- |
| [HasEnded](EntityUnitOfWork_TDbContext__HasEnded.md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.HasEnded') | Gets a value indicating whether this instance has ended.<br/> |

| Methods | |
| :--- | :--- |
| [Dispose(bool)](EntityUnitOfWork_TDbContext__Dispose_f5AhucTTJHd5gQhdoceNEg.md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.Dispose(bool)') | Releases unmanaged and - optionally - managed resources.<br/> |
| [GetContext()](EntityUnitOfWork_TDbContext__GetContext().md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.GetContext()') | Returns the current DbContext object.<br/> |
| [GetRepository&lt;TEntity&gt;()](EntityUnitOfWork_TDbContext__GetRepository_TEntity_().md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.GetRepository&lt;TEntity&gt;()') | Gets the [IRepository&lt;TEntity&gt;](IRepository_TEntity_.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;') repository for the type supplied.<br/> |
| [SaveChanges()](EntityUnitOfWork_TDbContext__SaveChanges().md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.SaveChanges()') | Saves the changes.<br/> |
| [SaveChangesAsync(CancellationToken)](EntityUnitOfWork_TDbContext__SaveChangesAsync_E2zcMl1m_k7r__w7c6WT1w.md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.SaveChangesAsync(System.Threading.CancellationToken)') | Saves the changes asynchronous.<br/> |
#### See Also
- [IUnitOfWork](IUnitOfWork.md 'DoveSoft.Common.Data.IUnitOfWork')
