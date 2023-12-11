using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tween : MonoBehaviour
{
    [SerializeField] GameObject logo , mainmenu , selectMenu, options;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveLocal(logo, new Vector3(356.6f,-1.3989f,0f), .7f).setDelay(.7f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(mainmenu, new Vector3(-641f, 0f, 0f), .7f).setDelay(.7f).setEase(LeanTweenType.easeOutCubic);

    }
    public void showSelectMenu()
    {
        LeanTween.moveLocal(selectMenu, new Vector3(0f, 0f, 0f), .7f).setEase(LeanTweenType.easeOutCubic);
    }
    public void hideSelectMenu()
    {
        LeanTween.moveLocal(selectMenu, new Vector3(0f, -2000f, 0f), .7f).setEase(LeanTweenType.easeOutCubic);
    }
    public void showOptions()
    {
        LeanTween.moveLocal(options, new Vector3(0f, 0f, 0f), .7f).setEase(LeanTweenType.easeOutCubic);
    }
    public void hideOptions()
    {
        LeanTween.moveLocal(options, new Vector3(-2000f, 0f, 0f), .7f).setEase(LeanTweenType.easeOutCubic);
    }
  
}
