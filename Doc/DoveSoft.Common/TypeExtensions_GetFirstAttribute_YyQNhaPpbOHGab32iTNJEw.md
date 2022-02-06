#### [DoveSoft.Common](readme.md 'readme')
### [DoveSoft.Common.Extensions](DoveSoft_Common_Extensions.md 'DoveSoft.Common.Extensions').[TypeExtensions](TypeExtensions.md 'DoveSoft.Common.Extensions.TypeExtensions')
## TypeExtensions.GetFirstAttribute&lt;TEnum,TAttribute&gt;(TEnum) Method
Gets the first attribute.  
```csharp
public static TAttribute GetFirstAttribute<TEnum,TAttribute>(this TEnum enumValue)
    where TEnum : struct;
```
#### Type parameters
<a name='DoveSoft_Common_Extensions_TypeExtensions_GetFirstAttribute_TEnum_TAttribute_(TEnum)_TEnum'></a>
`TEnum`  
The type of the enum.
  
<a name='DoveSoft_Common_Extensions_TypeExtensions_GetFirstAttribute_TEnum_TAttribute_(TEnum)_TAttribute'></a>
`TAttribute`  
The type of the attribute.
  
#### Parameters
<a name='DoveSoft_Common_Extensions_TypeExtensions_GetFirstAttribute_TEnum_TAttribute_(TEnum)_enumValue'></a>
`enumValue` [TEnum](TypeExtensions_GetFirstAttribute_YyQNhaPpbOHGab32iTNJEw.md#DoveSoft_Common_Extensions_TypeExtensions_GetFirstAttribute_TEnum_TAttribute_(TEnum)_TEnum 'DoveSoft.Common.Extensions.TypeExtensions.GetFirstAttribute&lt;TEnum,TAttribute&gt;(TEnum).TEnum')  
The enum value.
  
#### Returns
[TAttribute](TypeExtensions_GetFirstAttribute_YyQNhaPpbOHGab32iTNJEw.md#DoveSoft_Common_Extensions_TypeExtensions_GetFirstAttribute_TEnum_TAttribute_(TEnum)_TAttribute 'DoveSoft.Common.Extensions.TypeExtensions.GetFirstAttribute&lt;TEnum,TAttribute&gt;(TEnum).TAttribute')  
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
