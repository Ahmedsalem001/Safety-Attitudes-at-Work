using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent ;
    public string[] lines;
    public float textSpeed;
    private int index;
    [SerializeField] private CanvasGroup option1, option2;
    

    private void Awake() {
        textComponent.text = "";
        StartDialogue();    
    }
    private void Update() {
        if (Input.GetMouseButtonDown(0)){
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }
    void StartDialogue(){
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine(){
        foreach( char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    public void NextLine(){
        
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = "";
            StartCoroutine(TypeLine());
        }
        else
        {
            
            LeanTween.alphaCanvas(option1, 1, .3f).setEase(LeanTweenType.easeInOutQuad);
            LeanTween.alphaCanvas(option2, 1, .3f).setEase(LeanTweenType.easeInOutQuad);
            
        }
    }
}
