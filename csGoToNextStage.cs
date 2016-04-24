using UnityEngine;
using System.Collections;

public class csGoToNextStage : MonoBehaviour {

	public GameObject DoorEffect;
	public csButtonController ButtonController;
	public int StageNum;

	private bool nextStage;
	// Use this for initialization
	void Start () {
		nextStage = false;
		DoorEffect = GameObject.Find ("DoorEffect");
		DoorEffect.SetActive (false);
		ButtonController = GameObject.Find ("ButtonController").GetComponent<csButtonController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (ButtonController.MainButton)
			nextStage = true;
		if (!ButtonController.MainButton)
			nextStage = false;
	}

	void OnTriggerStay(Collider other){
		if (other.name == "Erica") {
			DoorEffect.SetActive (true);
			if(nextStage){
				if(StageNum == 1) GoToForest();
				if(StageNum == 2) GoToLoninHouse();
				if(StageNum == 3) GoToFrameRoom();
				if(StageNum == 4) GoToPoro();
			}
				
		}
		}

	void OnTriggerExit(Collider other){
		if (other.name == "Erica") {
			DoorEffect.SetActive(false);
		}
	}

	void GoToFirstRoom(){
		Application.LoadLevel("FirstRoom");
	}
	void GoToForest(){
		Application.LoadLevel("ForestRoom");
	}
	void GoToLoninHouse(){
		Application.LoadLevel("LoninRoom");
	}
	void GoToFrameRoom(){
		Application.LoadLevel ("FrameRoom");
	}
	void GoToPoro(){
		Application.LoadLevel ("PoroRoom");
	}
}
