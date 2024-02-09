using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertRT : MonoBehaviour {

    public static void ConvertToAbsolutePixels(Transform toConvert) {

        RectTransform rt = toConvert.GetComponent<RectTransform>();
        RectTransform parentRt = toConvert.parent.GetComponent<RectTransform>();
        Vector2 anchorMin = rt.anchorMin;
        Vector2 anchorMax = rt.anchorMax;
        Vector2 offsetMin = rt.offsetMin;
        Vector2 offsetMax = rt.offsetMax;
        Rect rect = parentRt.rect;

        // Left
        offsetMin.x += (anchorMin.x * rect.width);
        anchorMin.x = 0.0f;

        // Right
        offsetMax.x += (anchorMax.x * rect.width);
        anchorMax.x = 0.0f;

        // Top
        offsetMax.y += (anchorMax.y * rect.height);
        anchorMax.y = 0.0f;

        // Bottom
        offsetMin.y += (anchorMin.y * rect.height);
        anchorMin.y = 0.0f;

        // Set the values.
        rt.anchorMin = anchorMin;
        rt.anchorMax = anchorMax;
        rt.offsetMin = offsetMin;
        rt.offsetMax = offsetMax;

    }

}
