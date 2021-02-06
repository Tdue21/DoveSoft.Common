#### [DoveSoft.Common](./index.md 'index')
### [DoveSoft.Common.Extensions](./DoveSoft-Common-Extensions.md 'DoveSoft.Common.Extensions').[StringExtensions](./DoveSoft-Common-Extensions-StringExtensions.md 'DoveSoft.Common.Extensions.StringExtensions')
## StringExtensions.AppendDivider(System.Text.StringBuilder, char, int) Method
Appends a divider [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') to a StringBuilder. The divider is default a 50 characters long string of dashes.  
```csharp
public static System.Text.StringBuilder AppendDivider(this System.Text.StringBuilder builder, char divider='-', int length=50);
```
#### Parameters
<a name='DoveSoft-Common-Extensions-StringExtensions-AppendDivider(System-Text-StringBuilder_char_int)-builder'></a>
`builder` [System.Text.StringBuilder](https://docs.microsoft.com/en-us/dotnet/api/System.Text.StringBuilder 'System.Text.StringBuilder')  
The [System.Text.StringBuilder](https://docs.microsoft.com/en-us/dotnet/api/System.Text.StringBuilder 'System.Text.StringBuilder') object.  
  
<a name='DoveSoft-Common-Extensions-StringExtensions-AppendDivider(System-Text-StringBuilder_char_int)-divider'></a>
`divider` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')  
The [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char') value to use as a divider.  
  
<a name='DoveSoft-Common-Extensions-StringExtensions-AppendDivider(System-Text-StringBuilder_char_int)-length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The length of the divider string.  
  
#### Returns
[System.Text.StringBuilder](https://docs.microsoft.com/en-us/dotnet/api/System.Text.StringBuilder 'System.Text.StringBuilder')  
A string consisting of the divider character. Default: 50 dashes.  
