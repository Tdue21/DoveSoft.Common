#### [DoveSoft.Common](readme.md 'readme')
### [DoveSoft.Common.Data](DoveSoft_Common_Data.md 'DoveSoft.Common.Data')
## IUnitOfWork Interface
```csharp
public interface IUnitOfWork :
DoveSoft.Common.IDisposing,
System.IDisposable
```

Derived  
&#8627; [EntityUnitOfWork&lt;TDbContext&gt;](EntityUnitOfWork_TDbContext_.md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;')  

Implements [IDisposing](IDisposing.md 'DoveSoft.Common.IDisposing'), [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  

| Methods | |
| :--- | :--- |
| [GetRepository&lt;TEntity&gt;()](IUnitOfWork_GetRepository_TEntity_().md 'DoveSoft.Common.Data.IUnitOfWork.GetRepository&lt;TEntity&gt;()') | Gets the repository.<br/> |
| [SaveChanges()](IUnitOfWork_SaveChanges().md 'DoveSoft.Common.Data.IUnitOfWork.SaveChanges()') | Saves the changes.<br/> |
| [SaveChangesAsync(CancellationToken)](IUnitOfWork_SaveChangesAsync_O+CwPB6V49z228jW7mlG7Q.md 'DoveSoft.Common.Data.IUnitOfWork.SaveChangesAsync(System.Threading.CancellationToken)') | Saves the changes asynchronous.<br/> |
#### See Also
- [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')
