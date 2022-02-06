#### [DoveSoft.Common](readme.md 'readme')
### [DoveSoft.Common.Data](DoveSoft_Common_Data.md 'DoveSoft.Common.Data').[EntityUnitOfWork&lt;TDbContext&gt;](EntityUnitOfWork_TDbContext_.md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;')
## EntityUnitOfWork&lt;TDbContext&gt;.GetContext() Method
Returns the current DbContext object.  
```csharp
public TDbContext GetContext();
```
#### Returns
[TDbContext](EntityUnitOfWork_TDbContext_.md#DoveSoft_Common_Data_EntityUnitOfWork_TDbContext__TDbContext 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.TDbContext')  
#### Exceptions
[System.ObjectDisposedException](https://docs.microsoft.com/en-us/dotnet/api/System.ObjectDisposedException 'System.ObjectDisposedException')  
Unit of Work has been disposed.
