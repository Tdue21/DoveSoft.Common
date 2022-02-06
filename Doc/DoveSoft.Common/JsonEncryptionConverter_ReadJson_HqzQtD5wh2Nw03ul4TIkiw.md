#### [DoveSoft.Common](readme.md 'readme')
### [DoveSoft.Common](DoveSoft_Common.md 'DoveSoft.Common').[JsonEncryptionConverter](JsonEncryptionConverter.md 'DoveSoft.Common.JsonEncryptionConverter')
## JsonEncryptionConverter.ReadJson(JsonReader, Type, object, JsonSerializer) Method
Reads the JSON representation of the object.  
```csharp
public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
```
#### Parameters
<a name='DoveSoft_Common_JsonEncryptionConverter_ReadJson(Newtonsoft_Json_JsonReader_System_Type_object_Newtonsoft_Json_JsonSerializer)_reader'></a>
`reader` [Newtonsoft.Json.JsonReader](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonReader 'Newtonsoft.Json.JsonReader')  
The [Newtonsoft.Json.JsonReader](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonReader 'Newtonsoft.Json.JsonReader') to read from.
  
<a name='DoveSoft_Common_JsonEncryptionConverter_ReadJson(Newtonsoft_Json_JsonReader_System_Type_object_Newtonsoft_Json_JsonSerializer)_objectType'></a>
`objectType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
Type of the object.
  
<a name='DoveSoft_Common_JsonEncryptionConverter_ReadJson(Newtonsoft_Json_JsonReader_System_Type_object_Newtonsoft_Json_JsonSerializer)_existingValue'></a>
`existingValue` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The existing value of object being read.
  
<a name='DoveSoft_Common_JsonEncryptionConverter_ReadJson(Newtonsoft_Json_JsonReader_System_Type_object_Newtonsoft_Json_JsonSerializer)_serializer'></a>
`serializer` [Newtonsoft.Json.JsonSerializer](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializer 'Newtonsoft.Json.JsonSerializer')  
The calling serializer.
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object value.
