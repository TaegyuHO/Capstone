using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class csDialogueFirstRoom : MonoBehaviour
{
    public Text dialog_text;
	private GameObject dialog;
	public GameObject joystick;
	public GameObject search_button;
	public GameObject dialogBG;

    public int dial_num;
    private string[] dialogue_string = {
		"",
        "열쇠가 있다.",
        "잠겨있다.",
        "열쇠가 딱 맞는다.",
        "푹신해 보이는 쇼파지만, 지금은 앉고 싶지 않다.",
        "분명 커튼인데, 지나갈 수가 없다.",
        "책은 많은데 다 재미 없어보인다. 동화책은 없나?",
        "안에 아무것도 없어",
        "아무것도 보이지 않아"
    };
    
    void Start()
    {
	    dial_num = 0;
		dialog = GameObject.Find ("Dialog");
		dialog.SetActive (false);
		dialogBG.SetActive (false);
    }

    void Update()
    {
        Debug.Log(dial_num);
		if (dial_num != 0) {
			dialogBG.SetActive(true);
			dialog.SetActive(true);
			dialog_text.text = dialogue_string [dial_num];
			Invoke("SetZero", 2f);
		}
		if (dial_num == 0) {
			dialog.SetActive(false);			
			dialogBG.SetActive(false);
		}


	}

	void SetZero(){
		dial_num = 0;
	}


}
