# Apply To Dictionary

#### Requires [Odin Inspector]

Add the `ApplyToDictionaryKeys` / `ApplyToDictionaryValues` attributes to an attribute definition, let's call that one `X`. Every attribute that is put on the attribute definition `X` will now be applied to dictionary keys / values if `X` is applied to a dictionary.

### Examples
```csharp
// If DictionaryPreviewFieldAttribute is added to a dictionary, add the PreviewField attribute to its keys.
[ApplyToDictionaryKeys]
[PreviewField]
public class DictionaryPreviewFieldAttribute : Attribute { }

// If DictionaryValueDropdownAttribute is added to a dictionary, add the ValueDropdown attribute to its values.
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

### Installation
Simply put the downloaded ApplyToDictionaryAttribute folder in your project
and start using the attribute as shown in the examples.
You can move the files, but make sure that `ApplyToDictionaryKeys.cs` and `ApplyToDictionaryValues.cs`
are not in an editor folder or they will be removed during build, causing errors.

[Odin Inspector]: https://odininspector.com/
