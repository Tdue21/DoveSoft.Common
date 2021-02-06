#### [DoveSoft.Common](./index.md 'index')
### [DoveSoft.Common.Data](./DoveSoft-Common-Data.md 'DoveSoft.Common.Data')
## EntityRepository&lt;TDbContext,TEntity&gt; Class
  
```csharp
public sealed class EntityRepository<TDbContext,TEntity> :
DoveSoft.Common.Data.IRepository<TEntity>
    where TDbContext : Microsoft.EntityFrameworkCore.DbContext
    where TEntity : class
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EntityRepository&lt;TDbContext,TEntity&gt;  

Implements [DoveSoft.Common.Data.IRepository&lt;](./DoveSoft-Common-Data-IRepository-TEntity-.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;')[TEntity](#DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity--TEntity 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.TEntity')[&gt;](./DoveSoft-Common-Data-IRepository-TEntity-.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;')  
#### Type parameters
<a name='DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity--TDbContext'></a>
`TDbContext`  
  

Constraints [Microsoft.EntityFrameworkCore.DbContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContext 'Microsoft.EntityFrameworkCore.DbContext')  
  
<a name='DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity--TEntity'></a>
`TEntity`  
The type of the entity.  
  
### Constructors
- [EntityRepository(DoveSoft.Common.Data.IUnitOfWork)](./DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity--EntityRepository(DoveSoft-Common-Data-IUnitOfWork).md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.EntityRepository(DoveSoft.Common.Data.IUnitOfWork)')
### Properties
- [Context](./DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity--Context.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.Context')
- [Query](./DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity--Query.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.Query')
- [Set](./DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity--Set.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.Set')
### Methods
- [Delete(TEntity)](./DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity--Delete(TEntity).md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.Delete(TEntity)')
- [Find(object[])](./DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity--Find(object--).md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.Find(object[])')
- [FindAsync(object[], System.Threading.CancellationToken)](./DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity--FindAsync(object--_System-Threading-CancellationToken).md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.FindAsync(object[], System.Threading.CancellationToken)')
- [Insert(TEntity)](./DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity--Insert(TEntity).md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.Insert(TEntity)')
- [InsertAsync(TEntity, System.Threading.CancellationToken)](./DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity--InsertAsync(TEntity_System-Threading-CancellationToken).md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.InsertAsync(TEntity, System.Threading.CancellationToken)')
- [Update(TEntity)](./DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity--Update(TEntity).md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;.Update(TEntity)')
