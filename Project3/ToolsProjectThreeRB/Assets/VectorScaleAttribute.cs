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
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label)*4;
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        Rect myRect = position;
        myRect.height = myRect.height / 4;

        int _x = 1;
        int _y = 1;
        int _z = 1;

        Vector3 myVector = new Vector3(_x, _y, _z);

        EditorGUI.LabelField(myRect, myVector.ToString());

        myRect.y += myRect.height;
        _x = EditorGUI.IntSlider(myRect, "X value", _x, 0, 100);
        myRect.y += myRect.height;
        _y = EditorGUI.IntSlider(myRect, "Y value", _y, 0, 100);
        myRect.y += myRect.height;
        _z = EditorGUI.IntSlider(myRect, "Z value", _z, 0, 100);
       
        //base.OnGUI(position, property, label);
    }
}
