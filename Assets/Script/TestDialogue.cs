using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestDialogue : MonoBehaviour
{

    [SerializeField]
    public Dialogue dialogue;

    private DialogueManager theDM;

    private FadeManager fadeManager;

    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        theDM = FindObjectOfType<DialogueManager>();
        fadeManager = FindObjectOfType<FadeManager>(); // Fade 관리 Manager 객체 생성

        fadeManager.FadeOut(image); // FadeOut 호출
        Invoke("ShowDialogue", 1); // 함수 지연 호출
    }

    void ShowDialogue()
    {
        theDM.ShowDialogue(dialogue);
    }
    
}
