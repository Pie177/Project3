using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ColorLineAttribute : PropertyAttribute {

    public Color myColor;
    Vector4 vec;
	public ColorLineAttribute(float firstNum, float secondNum, float thirdNum)
    {
        vec = new Vector4(firstNum, secondNum, thirdNum, 1f);
        myColor = vec;
    }
}

[CustomPropertyDrawer(typeof(ColorLineAttribute))]
public class ColorLineDrawer: DecoratorDrawer
{
    public override float GetHeight()
    {
        return base.GetHeight()* 2;
    }

    public override void OnGUI(Rect position)
    {
        ColorLineAttribute colorAtt = attribute as ColorLineAttribute;
        GUIStyle myStyle = GUI.skin.GetStyle("Label");
        myStyle.alignment = TextAnchor.UpperRight;
        myStyle.normal.textColor = colorAtt.myColor;
        EditorGUI.LabelField(position, "_______________________________________________________", myStyle);
        base.OnGUI(position);
    }
}