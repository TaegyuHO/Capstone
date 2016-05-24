using UnityEngine;
using System.Collections;

public class csCabbit : MonoBehaviour {
    private NavMeshAgent nma;
    private GameObject dest;
    public bool movetrigger;

	// Use this for initialization
	void Start () {
        dest = GameObject.Find("Cabbit_End");
        nma = transform.GetComponent<NavMeshAgent>();	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(movetrigger)
            nma.SetDestination(dest.transform.position);
	}
}
