using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollButton : MonoBehaviour
{
    [SerializeField] Scrollbar scrollBar;
    [SerializeField] float delta;
    
    public void MoveScrollBar()
    {
        scrollBar.value = Mathf.Clamp(scrollBar.value + delta, 0, 1);
    }
}
