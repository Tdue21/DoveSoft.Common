#### [DoveSoft.Common](readme.md 'readme')
### [DoveSoft.Common.Data](DoveSoft_Common_Data.md 'DoveSoft.Common.Data')
## IRepository&lt;TEntity&gt; Interface
```csharp
public interface IRepository<TEntity>
    where TEntity : class
```
#### Type parameters
<a name='DoveSoft_Common_Data_IRepository_TEntity__TEntity'></a>
`TEntity`  
The type of the entity.
  

Derived  
&#8627; [EntityRepository&lt;TDbContext,TEntity&gt;](EntityRepository_TDbContext_TEntity_.md 'DoveSoft.Common.Data.EntityRepository&lt;TDbContext,TEntity&gt;')  
### Remarks
Based upon blog post by Brian Bu: https://brianbu.com/2019/09/25/the-repository-pattern-isnt-an-anti-pattern-youre-just-doing-it-wrong/  

| Properties | |
| :--- | :--- |
| [Query](IRepository_TEntity__Query.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;.Query') | Gets the query.<br/> |

| Methods | |
| :--- | :--- |
| [Delete(TEntity)](IRepository_TEntity__Delete_gfVt+P3RUlXjYWg_cd7Rww.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;.Delete(TEntity)') | Deletes the specified entity.<br/> |
| [Find(object[])](IRepository_TEntity__Find_Grj1kFWqc2YqSBs+AMltdQ.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;.Find(object[])') | Finds the specified keys.<br/> |
| [FindAsync(object[], CancellationToken)](IRepository_TEntity__FindAsync_D161pBIi_E4YfuaLUC5cCQ.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;.FindAsync(object[], System.Threading.CancellationToken)') | Finds the asynchronous.<br/> |
| [Insert(TEntity)](IRepository_TEntity__Insert_YHlf8OoX9oAxwpB_njLNMw.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;.Insert(TEntity)') | Inserts the specified entity.<br/> |
| [InsertAsync(TEntity, CancellationToken)](IRepository_TEntity__InsertAsync_QAUyPgGasGNFPmQPj1mK2g.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;.InsertAsync(TEntity, System.Threading.CancellationToken)') | Inserts the asynchronous.<br/> |
| [Update(TEntity)](IRepository_TEntity__Update_K7RzRa8V0byGBfAcu1BUDw.md 'DoveSoft.Common.Data.IRepository&lt;TEntity&gt;.Update(TEntity)') | Updates the specified entity.<br/> |
