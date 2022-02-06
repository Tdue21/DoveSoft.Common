#### [DoveSoft.Common](readme.md 'readme')
### [DoveSoft.Common.Data](DoveSoft_Common_Data.md 'DoveSoft.Common.Data').[EntityRepository&lt;TDbContext,TEntity&gt;](EntityRepository_TDbContext_TEntity_.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;')
## EntityRepository&lt;TDbContext,TEntity&gt;.EntityRepository(IUnitOfWork) Constructor
Initializes a new instance of the [EntityRepository&lt;TDbContext,TEntity&gt;](EntityRepository_TDbContext_TEntity_.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;') class.  
```csharp
public EntityRepository(DoveSoft.Common.Data.IUnitOfWork unitOfWork);
```
#### Parameters
<a name='DoveSoft_Common_Data_EntityRepository_TDbContext_TEntity__EntityRepository(DoveSoft_Common_Data_IUnitOfWork)_unitOfWork'></a>
`unitOfWork` [IUnitOfWork](IUnitOfWork.md 'DoveSoft.Common.Data.IUnitOfWork')  
The unit of work.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
unitOfWork
