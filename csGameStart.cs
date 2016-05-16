using UnityEngine;
using System.Collections;

public class csGameStart : MonoBehaviour {

		private csButtonController ButtonController;
		public int StageNum;
		
		private bool nextStage;
		// Use this for initialization
		void Start () {
			nextStage = false;
			ButtonController = GameObject.Find ("ButtonController").GetComponent<csButtonController> ();
		}
		
		// Update is called once per frame
		void Update () {

		if (ButtonController.MainButton)
			nextStage = true;
		if (!ButtonController.MainButton)
			nextStage = false;
		if (nextStage) {
			if (StageNum == 0)
				GoToMenu ();
			if (StageNum == 1)
				GoToFirstRoom ();
		}
	}
		void GoToMenu(){
			Application.LoadLevel("Menu");
		}
			
		void GoToFirstRoom(){
			Application.LoadLevel("FirstRoom");
		}


}
