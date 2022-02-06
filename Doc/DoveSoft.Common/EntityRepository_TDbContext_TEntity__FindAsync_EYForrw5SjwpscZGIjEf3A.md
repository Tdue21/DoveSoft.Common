#### [DoveSoft.Common](readme.md 'readme')
### [DoveSoft.Common.Data](DoveSoft_Common_Data.md 'DoveSoft.Common.Data').[EntityRepository&lt;TDbContext,TEntity&gt;](EntityRepository_TDbContext_TEntity_.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;')
## EntityRepository&lt;TDbContext,TEntity&gt;.FindAsync(object[], CancellationToken) Method
Finds the asynchronous.  
```csharp
public System.Threading.Tasks.Task<TEntity> FindAsync(object[] keys, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters
<a name='DoveSoft_Common_Data_EntityRepository_TDbContext_TEntity__FindAsync(object___System_Threading_CancellationToken)_keys'></a>
`keys` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The keys.
  
<a name='DoveSoft_Common_Data_EntityRepository_TDbContext_TEntity__FindAsync(object___System_Threading_CancellationToken)_cancellationToken'></a>
`cancellationToken` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')  
The cancellation token.
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TEntity](EntityRepository_TDbContext_TEntity_.md#DoveSoft_Common_Data_EntityRepository_TDbContext_TEntity__TEntity 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  

Implements [FindAsync(object[], CancellationToken)](IRepository_TEntity__FindAsync_D161pBIi_E4YfuaLUC5cCQ.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;.FindAsync(object[], System.Threading.CancellationToken)')  
