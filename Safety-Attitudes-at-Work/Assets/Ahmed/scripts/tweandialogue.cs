using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tweandialogue : MonoBehaviour
{
   [SerializeField] private CanvasGroup canvasGroup;
   [SerializeField] private GameObject dialogue;
    // Start is called before the first frame update
    public void fadeout()
    {
        dialogue.SetActive(true);
        LeanTween.alphaCanvas(canvasGroup, 1, 1f).setEase(LeanTweenType.easeOutCubic);
    }   
}
