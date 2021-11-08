using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellphoneManager : MonoBehaviour
{
    [SerializeField]
    public Dialogue dialogue;

    private CellphoneAniManager theDM;

    private FadeManager fadeManager;

    public Image image;
    private int fadeCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        theDM = FindObjectOfType<CellphoneAniManager>();
        fadeManager = FindObjectOfType<FadeManager>(); // Fade 관리 Manager 객체 생성
        Invoke("ShowDialogue", 1); // 함수 지연 호출
    }

    void Update()
    {
        if(theDM.Count == 2 && fadeCount == 0)
        {
            fadeCount++;
            fadeManager.FadeOut(image); // FadeOut 호출
        }    
    }

    void ShowDialogue()
    {
        theDM.ShowDialogue(dialogue);
    }
}
