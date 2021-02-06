#### [DoveSoft.Common](./index.md 'index')
### [DoveSoft.Common.Data](./DoveSoft-Common-Data.md 'DoveSoft.Common.Data').[EntityRepository&lt;TDbContext,TEntity&gt;](./DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity-.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;')
## EntityRepository(DoveSoft.Common.Data.IUnitOfWork) Constructor
Initializes a new instance of the [EntityRepository&lt;TDbContext,TEntity&gt;](./DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity-.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;') class.  
```csharp
public EntityRepository(DoveSoft.Common.Data.IUnitOfWork unitOfWork);
```
#### Parameters
<a name='DoveSoft-Common-Data-EntityRepository-TDbContext_TEntity--EntityRepository(DoveSoft-Common-Data-IUnitOfWork)-unitOfWork'></a>
`unitOfWork` [IUnitOfWork](./DoveSoft-Common-Data-IUnitOfWork.md 'DoveSoft.Common.Data.IUnitOfWork')  
The unit of work.  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
unitOfWork  
