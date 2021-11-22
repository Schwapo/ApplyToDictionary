#if UNITY_EDITOR
using System;
using System.Reflection;
using System.Collections.Generic;
using Sirenix.OdinInspector.Editor;

[ResolverPriority(-100000)]
public class ApplyToDictionaryAttributeProcessor<T1, T2> : OdinAttributeProcessor<EditableKeyValuePair<T1, T2>>
{
    public override void ProcessChildMemberAttributes(InspectorProperty parentProperty, MemberInfo member, List<Attribute> attributes)
    {
        foreach (var parentAttribute in parentProperty.Attributes)
        {
            var type = parentAttribute.GetType();

            if ((member.Name == "Key" && type.IsDefined(typeof(ApplyToDictionaryKeysAttribute), false)) || 
                (member.Name == "Value" && type.IsDefined(typeof(ApplyToDictionaryValuesAttribute), false)))
            {
                foreach (var attribute in type.GetCustomAttributes(false))
                {
                    if (attribute is AttributeUsageAttribute) continue;

                    attributes.Add(attribute as Attribute);
                }
            }
        }
    }
}
#endif