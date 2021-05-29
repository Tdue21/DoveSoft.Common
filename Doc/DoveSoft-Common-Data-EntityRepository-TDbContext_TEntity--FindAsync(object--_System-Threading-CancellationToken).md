#### [DoveSoft.Common](./index.md 'index')
### [DoveSoft.Common.Data](./DoveSoft-Common-Data.md 'DoveSoft.Common.Data').[EntityRepository&lt;TDbContext,TEntity&gt;](./DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity-.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;')
## EntityRepository&lt;TDbContext,TEntity&gt;.FindAsync(object[], System.Threading.CancellationToken) Method
Finds the asynchronous.  
```csharp
public System.Threading.Tasks.Task<TEntity> FindAsync(object[] keys, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters
<a name='DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity--FindAsync(object--_System-Threading-CancellationToken)-keys'></a>
`keys` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The keys.  
  
<a name='DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity--FindAsync(object--_System-Threading-CancellationToken)-cancellationToken'></a>
`cancellationToken` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')  
The cancellation token.  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TEntity](./DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity-.md#DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity--TEntity 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
  
