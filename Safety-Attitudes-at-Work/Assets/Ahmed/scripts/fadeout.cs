using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeout : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private CanvasGroup canvasGroup;

    public void fadeout1()
    {
        LeanTween.alphaCanvas(canvasGroup, 1, .3f).setEase(LeanTweenType.easeInOutQuad);
    }
}
