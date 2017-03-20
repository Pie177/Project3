using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFormatAttribute : PropertyAttribute {
    public bool showHour;
	public TimeFormatAttribute(bool showHour)
    {
        this.showHour = showHour;
    }
}
