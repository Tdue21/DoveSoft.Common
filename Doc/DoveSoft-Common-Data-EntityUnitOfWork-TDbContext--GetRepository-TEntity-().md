#### [DoveSoft.Common](./index.md 'index')
### [DoveSoft.Common.Data](./DoveSoft-Common-Data.md 'DoveSoft.Common.Data').[EntityUnitOfWork&lt;TDbContext&gt;](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext-.md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;')
## EntityUnitOfWork&lt;TDbContext&gt;.GetRepository&lt;TEntity&gt;() Method
Gets the [IRepository&lt;TEntity&gt;](./DoveSoft-Common-Data-IRepository-TEntity-.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;') repository for the type supplied.  
```csharp
public DoveSoft.Common.Data.IRepository<TEntity> GetRepository<TEntity>()
    where TEntity : class;
```
#### Type parameters
<a name='DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--GetRepository-TEntity-()-TEntity'></a>
`TEntity`  
The type of the entity.  
  
#### Returns
[DoveSoft.Common.Data.IRepository&lt;](./DoveSoft-Common-Data-IRepository-TEntity-.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;')[TEntity](#DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--GetRepository-TEntity-()-TEntity 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.GetRepository&lt;TEntity&gt;().TEntity')[&gt;](./DoveSoft-Common-Data-IRepository-TEntity-.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;')  
  
