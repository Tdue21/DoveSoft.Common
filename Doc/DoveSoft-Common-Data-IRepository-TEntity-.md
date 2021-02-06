#### [DoveSoft.Common](./index.md 'index')
### [DoveSoft.Common.Data](./DoveSoft-Common-Data.md 'DoveSoft.Common.Data')
## IRepository&lt;TEntity&gt; Interface
  
```csharp
public interface IRepository<TEntity>
    where TEntity : class
```
Derived  
&#8627; [EntityRepository&lt;TDbContext,TEntity&gt;](./DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity-.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;')  
#### Type parameters
<a name='DoveSoft-Common-Data-IRepository-TEntity--TEntity'></a>
`TEntity`  
The type of the entity.  
  
### Properties
- [Query](./DoveSoft-Common-Data-IRepository-TEntity--Query.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;.Query')
### Methods
- [Delete(TEntity)](./DoveSoft-Common-Data-IRepository-TEntity--Delete(TEntity).md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;.Delete(TEntity)')
- [Find(object[])](./DoveSoft-Common-Data-IRepository-TEntity--Find(object--).md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;.Find(object[])')
- [FindAsync(object[], System.Threading.CancellationToken)](./DoveSoft-Common-Data-IRepository-TEntity--FindAsync(object--_System-Threading-CancellationToken).md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;.FindAsync(object[], System.Threading.CancellationToken)')
- [Insert(TEntity)](./DoveSoft-Common-Data-IRepository-TEntity--Insert(TEntity).md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;.Insert(TEntity)')
- [InsertAsync(TEntity, System.Threading.CancellationToken)](./DoveSoft-Common-Data-IRepository-TEntity--InsertAsync(TEntity_System-Threading-CancellationToken).md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;.InsertAsync(TEntity, System.Threading.CancellationToken)')
- [Update(TEntity)](./DoveSoft-Common-Data-IRepository-TEntity--Update(TEntity).md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;.Update(TEntity)')
