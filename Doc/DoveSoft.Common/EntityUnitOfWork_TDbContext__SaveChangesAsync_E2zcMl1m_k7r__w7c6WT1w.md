#### [DoveSoft.Common](readme.md 'readme')
### [DoveSoft.Common.Data](DoveSoft_Common_Data.md 'DoveSoft.Common.Data').[EntityUnitOfWork&lt;TDbContext&gt;](EntityUnitOfWork_TDbContext_.md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;')
## EntityUnitOfWork&lt;TDbContext&gt;.SaveChangesAsync(CancellationToken) Method
Saves the changes asynchronous.  
```csharp
public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
```
#### Parameters
<a name='DoveSoft_Common_Data_EntityUnitOfWork_TDbContext__SaveChangesAsync(System_Threading_CancellationToken)_cancellationToken'></a>
`cancellationToken` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')  
The cancellation token.
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
#### Exceptions
[System.ObjectDisposedException](https://docs.microsoft.com/en-us/dotnet/api/System.ObjectDisposedException 'System.ObjectDisposedException')  
Unit of Work has been disposed.

Implements [SaveChangesAsync(CancellationToken)](IUnitOfWork_SaveChangesAsync_O+CwPB6V49z228jW7mlG7Q.md 'DoveSoft.Common.Data.IUnitOfWork.SaveChangesAsync(System.Threading.CancellationToken)')  
