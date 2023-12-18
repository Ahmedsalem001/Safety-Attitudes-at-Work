using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent ;
    public string[] lines;
    public AudioClip[] audioClipArray;
    public AudioSource Source;
    public float textSpeed;
    private int index;
    [SerializeField] private CanvasGroup option1, option2;
    

    private void Awake() {
        Source = GetComponent<AudioSource>();
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
                Source.Stop();
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }
    void StartDialogue(){
        index = 0;
        StartCoroutine(TypeLine());
        playSound();
    }
    IEnumerator TypeLine(){
        foreach( char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    void playSound(){
        Source.clip = audioClipArray[index];
        Source.PlayOneShot(Source.clip);
    }
    public void NextLine(){
        
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = "";
            StartCoroutine(TypeLine());
            playSound();

        }
        else
        {
            
            LeanTween.alphaCanvas(option1, 1, .3f).setEase(LeanTweenType.easeInOutQuad);
            LeanTween.alphaCanvas(option2, 1, .3f).setEase(LeanTweenType.easeInOutQuad);
            
        }
    }
    

}
