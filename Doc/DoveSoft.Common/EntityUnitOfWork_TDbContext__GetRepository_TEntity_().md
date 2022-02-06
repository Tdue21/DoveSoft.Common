#### [DoveSoft.Common](readme.md 'readme')
### [DoveSoft.Common.Data](DoveSoft_Common_Data.md 'DoveSoft.Common.Data').[EntityUnitOfWork&lt;TDbContext&gt;](EntityUnitOfWork_TDbContext_.md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;')
## EntityUnitOfWork&lt;TDbContext&gt;.GetRepository&lt;TEntity&gt;() Method
Gets the [IRepository&lt;TEntity&gt;](IRepository_TEntity_.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;') repository for the type supplied.  
```csharp
public DoveSoft.Common.Data.IRepository<TEntity> GetRepository<TEntity>()
    where TEntity : class;
```
#### Type parameters
<a name='DoveSoft_Common_Data_EntityUnitOfWork_TDbContext__GetRepository_TEntity_()_TEntity'></a>
`TEntity`  
The type of the entity.
  
#### Returns
[DoveSoft.Common.Data.IRepository&lt;](IRepository_TEntity_.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;')[TEntity](EntityUnitOfWork_TDbContext__GetRepository_TEntity_().md#DoveSoft_Common_Data_EntityUnitOfWork_TDbContext__GetRepository_TEntity_()_TEntity 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.GetRepository&lt;TEntity&gt;().TEntity')[&gt;](IRepository_TEntity_.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;')  

Implements [GetRepository<TEntity>()](IUnitOfWork_GetRepository_TEntity_().md 'DoveSoft.Common.Data.IUnitOfWork.GetRepository&lt;TEntity&gt;()')  
