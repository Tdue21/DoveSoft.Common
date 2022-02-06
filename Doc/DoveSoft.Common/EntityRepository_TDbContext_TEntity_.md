#### [DoveSoft.Common](readme.md 'readme')
### [DoveSoft.Common.Data](DoveSoft_Common_Data.md 'DoveSoft.Common.Data')
## EntityRepository&lt;TDbContext,TEntity&gt; Class
```csharp
public sealed class EntityRepository<TDbContext,TEntity> :
DoveSoft.Common.Data.IRepository<TEntity>
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    where TEntity : class
```
#### Type parameters
<a name='DoveSoft_Common_Data_EntityRepository_TDbContext_TEntity__TDbContext'></a>
`TDbContext`  
  
<a name='DoveSoft_Common_Data_EntityRepository_TDbContext_TEntity__TEntity'></a>
`TEntity`  
The type of the entity.
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EntityRepository&lt;TDbContext,TEntity&gt;  

Implements [DoveSoft.Common.Data.IRepository&lt;](IRepository_TEntity_.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;')[TEntity](EntityRepository_TDbContext_TEntity_.md#DoveSoft_Common_Data_EntityRepository_TDbContext_TEntity__TEntity 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.TEntity')[&gt;](IRepository_TEntity_.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;')  

| Constructors | |
| :--- | :--- |
| [EntityRepository(IUnitOfWork)](EntityRepository_TDbContext_TEntity___ctor_D161kaDeAsO9sNCjfgzG5w.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.EntityRepository(DoveSoft.Common.Data.IUnitOfWork)') | Initializes a new instance of the [EntityRepository&lt;TDbContext,TEntity&gt;](EntityRepository_TDbContext_TEntity_.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;') class.<br/> |

| Properties | |
| :--- | :--- |
| [Context](EntityRepository_TDbContext_TEntity__Context.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.Context') | Gets the context.<br/> |
| [Query](EntityRepository_TDbContext_TEntity__Query.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.Query') | Gets the query.<br/> |
| [Set](EntityRepository_TDbContext_TEntity__Set.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.Set') | Gets the set.<br/> |

| Methods | |
| :--- | :--- |
| [Delete(TEntity)](EntityRepository_TDbContext_TEntity__Delete_EEy++BIxxq8XOZHOjx8_0Q.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.Delete(TEntity)') | Deletes the specified entity.<br/> |
| [Find(object[])](EntityRepository_TDbContext_TEntity__Find_xiL2Iv3i5d3nANBMQdAyWQ.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.Find(object[])') | Finds the specified keys.<br/> |
| [FindAsync(object[], CancellationToken)](EntityRepository_TDbContext_TEntity__FindAsync_EYForrw5SjwpscZGIjEf3A.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.FindAsync(object[], System.Threading.CancellationToken)') | Finds the asynchronous.<br/> |
| [Insert(TEntity)](EntityRepository_TDbContext_TEntity__Insert_ZiXyD4YY_erUFNUDe6rd3Q.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.Insert(TEntity)') | Inserts the specified entity.<br/> |
| [InsertAsync(TEntity, CancellationToken)](EntityRepository_TDbContext_TEntity__InsertAsync_8MZPyFXYjKLkvhwvdadB1g.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.InsertAsync(TEntity, System.Threading.CancellationToken)') | Inserts the asynchronous.<br/> |
| [Update(TEntity)](EntityRepository_TDbContext_TEntity__Update_cUSsx+GbDv8RSfRipl5n9A.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.Update(TEntity)') | Updates the specified entity.<br/> |
#### See Also
- [IRepository&lt;TEntity&gt;](IRepository_TEntity_.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;')
