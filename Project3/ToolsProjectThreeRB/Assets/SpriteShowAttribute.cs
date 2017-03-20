using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Sprites;

public class SpriteShowAttribute : PropertyAttribute {

	public SpriteShowAttribute()
    {

    }
}

[CustomPropertyDrawer(typeof(SpriteShowAttribute))]
public class SpriteShowDrawer : PropertyDrawer
{
    SpriteShowAttribute Spr
    {
        get { return ((SpriteShowAttribute)attribute); }
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label) * 5;
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        Sprite mySprite = (Sprite)property.objectReferenceValue;

        Rect myRect = position;
        myRect.height = myRect.height / 5;
        //Texture2D atext = SpriteUtility.GetSpriteTexture(mySprite, false);
        //GUILayout.Label(atext);

        myRect.y += myRect.height * 4;
        EditorGUI.PropertyField(myRect, property, label, true);
        
        
        
 
            

     }
        //base.OnGUI(position, property, label);
}

