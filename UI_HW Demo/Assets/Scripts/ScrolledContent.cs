using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrolledContent : MonoBehaviour
{
    [SerializeField] Scrollbar scrollBar;
    [SerializeField] float scrollSpeed;
    float originalY;

    void Start()
    {
        scrollBar.onValueChanged.AddListener((float value) => ScrollContent(value));
        originalY = transform.position.y;
    }

    public void ScrollContent(float value)
    {
        transform.position = new Vector3(
            transform.position.x,
            originalY + value * scrollSpeed,
            transform.position.z);
    }
}
