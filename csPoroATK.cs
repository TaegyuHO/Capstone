using UnityEngine;
using System.Collections;

public class csPoroATK : MonoBehaviour {

	private int PoroAtkStat;
	private GameObject Erica;

	// Use this for initialization
	void Start () {
		PoroAtkStat = this.GetComponentInParent<csMonsterStat> ().ATK;
		Erica = GameObject.Find ("Erica");
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerStay(Collider other){
		if (other.name == "Erica") {
			InvokeRepeating("GiveDamage",1f,1f);
		}
	}

	void OnTriggerExit(Collider other){
		CancelInvoke ("GiveDamage");
	}

	void GiveDamage(){
	
		Erica.GetComponent<csEricaStatus>().Health -= PoroAtkStat;
	}
}
