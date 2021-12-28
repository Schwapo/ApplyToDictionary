# Apply To Dictionary

#### When this attribute is added to another attribute, then attributes from that attribute will also be added to the keys or values of the dictionary.

#### Requires [Odin Inspector]

### Installation
Simply put the downloaded ApplyToDictionaryAttribute folder in your project
and start using the attribute as shown in the examples.
You can move the files, but make sure that `ApplyToDictionaryKeys.cs` and `ApplyToDictionaryValues.cs`
are not in an editor folder or they will be removed during build, causing errors.

### Examples
```csharp
// DictionaryPreviewFieldAttribute.cs
[ApplyToDictionaryKeys]
[PreviewField]
public class DictionaryPreviewFieldAttribute : Attribute { }

// DictionaryValueDropdownAttribute.cs
[ApplyToDictionaryValues]
[ValueDropdown("@SomeMonoBehaviour.GetDropdownValues()")]
public class DictionaryValueDropdownAttribute : Attribute { }

// SomeMonoBehaviour.cs
public class SomeMonoBehaviour : SerializedMonoBehaviour
{
    [DictionaryPreviewField]
    [DictionaryValueDropdown]
    public Dictionary<Sprite, string> SomeDictionary = new Dictionary<Sprite, string>();
    
    public static List<string> GetDropdownValues() => new List<string>
    {
        "Value 1",
        "Value 2",
        "Value 3",
    };
}
```

[Odin Inspector]: https://odininspector.com/
