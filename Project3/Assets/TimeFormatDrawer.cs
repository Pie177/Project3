using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(TimeFormatAttribute))]
public class TimeFormatDrawer : PropertyDrawer {

    const int row = 17;

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label) * 2;
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if(property.propertyType == SerializedPropertyType.Integer)
        {
            EditorGUIUtility.labelWidth = 7 * label.text.Length;
            Rect drawingRect = position;
            drawingRect.height = drawingRect.height / 2;
            property.intValue = EditorGUI.IntField(drawingRect, label, Mathf.Max(0, property.intValue));

            drawingRect.y += drawingRect.height;
            EditorGUI.LabelField(drawingRect, " ", ConvertTime(property.intValue));
        }
        else
        {
            EditorGUI.HelpBox(position, "To use the Time Attribute " + label.text + " must be an int!", MessageType.Error);
        }

        //base.OnGUI(position, property, label);
    }

    private string ConvertTime(int totalSeconds)
    {
        TimeFormatAttribute timeAtt = attribute as TimeFormatAttribute;

        if(timeAtt.showHour == true)
        {
            int hours = totalSeconds / (60 * 60);
            int minutes = ((totalSeconds % (60 * 60)) / 60);
            int seconds = (totalSeconds % 60);
            return string.Format("{0}:{1}:{2} (h:m:s)", hours, minutes.ToString().PadLeft(2,'0'), seconds.ToString().PadLeft(2, '0'));
        }
        else
        {
            int minutes = ((totalSeconds % (60 * 60)) / 60);
            int seconds = (totalSeconds % 60);
            return string.Format("{0}:{1} (m:s)", minutes.ToString().PadLeft(2, '0'), seconds.ToString().PadLeft(2, '0'));
        }
    }


}
