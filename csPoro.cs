﻿using UnityEngine;
using System.Collections;

public class csPoro : MonoBehaviour {

    private float distance;
    private NavMeshAgent nma;
    private GameObject Erica;
    private Coroutine cou;
    private Animator anim;
	private csMonsterStat myStat;
	// Use this for initialization
	void Start () {

        Erica = GameObject.Find("Erica");
        nma = this.GetComponent<NavMeshAgent>();
        anim = this.GetComponent<Animator>();
		myStat = this.GetComponent<csMonsterStat> ();
	//	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        distance = Vector3.Distance(Erica.transform.position, this.transform.position);

//        Debug.Log("distance = " + distance);

        if(distance <= 7.0f)
        {
            cou = StartCoroutine(Porowake());
        }
        else if (distance > 7.0f)
        {
            anim.SetBool("EricaInAggroArea", false);
            nma.Stop();
        }

		if (myStat.HP <= 0) {
			anim.SetBool ("IsDead", true);
			Invoke ("PoroDead",1.0f);
		}
	}

    IEnumerator Porowake()
    {
        anim.SetTrigger("EricaArrived");            
        yield return new WaitForSeconds(1.3f);
        PoroRun();
    }

    void PoroRun()
    {
        if (distance <= 1.5f)
        {
            Debug.Log("distance 1.5!");
            nma.Stop();
            PoroAttack();
            return;
        }
        else
        {
            anim.SetBool("EricaInAttackArea", false);
        }

        anim.SetBool("EricaInAggroArea", true);
        nma.Resume();
        nma.SetDestination(Erica.transform.position);
    }

    void PoroAttack()
    {
        nma.Stop();
        StopCoroutine(cou);
        anim.SetBool("EricaInAttackArea", true);
    }

	void PoroDead(){
		Destroy (this.gameObject);
	}


}
