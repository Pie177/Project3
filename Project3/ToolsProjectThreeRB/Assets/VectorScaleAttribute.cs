using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class VectorScaleAttribute : PropertyAttribute {

	public VectorScaleAttribute()
    {

    }
}

[CustomPropertyDrawer(typeof(VectorScaleAttribute))]
public class VectorScaleDrawer: PropertyDrawer
{

    public float _x;
    public float _y;
    public float _z;

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label)*4;
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        
        
        //base.OnGUI(position, property, label);
    }
}
