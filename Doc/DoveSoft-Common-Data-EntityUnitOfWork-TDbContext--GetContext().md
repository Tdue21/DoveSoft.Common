#### [DoveSoft.Common](./index.md 'index')
### [DoveSoft.Common.Data](./DoveSoft-Common-Data.md 'DoveSoft.Common.Data').[EntityUnitOfWork&lt;TDbContext&gt;](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext-.md 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;')
## EntityUnitOfWork&lt;TDbContext&gt;.GetContext() Method
Returns the current DbContext object.  
```csharp
public TDbContext GetContext();
```
#### Returns
[TDbContext](./DoveSoft-Common-Data-EntityUnitOfWork-TDbContext-.md#DoveSoft-Common-Data-EntityUnitOfWork-TDbContext--TDbContext 'DoveSoft.Common.Data.EntityUnitOfWork&lt;TDbContext&gt;.TDbContext')  
  
#### Exceptions
[System.ObjectDisposedException](https://docs.microsoft.com/en-us/dotnet/api/System.ObjectDisposedException 'System.ObjectDisposedException')  
Unit of Work has been disposed.  
