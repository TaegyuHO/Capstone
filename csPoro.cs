using UnityEngine;
using System.Collections;

public class csPoro : MonoBehaviour {
    private float distance;
	private GameObject Poro;
    private NavMeshAgent nma;
    private GameObject Erica;
    private Coroutine cou;
    private Animator anim;
	// Use this for initialization
	void Start () {
		Poro = GameObject.Find ("Poro");
        Erica = GameObject.Find("Erica");
        nma = Poro.GetComponent<NavMeshAgent>();
        anim = Poro.GetComponent<Animator>();
	//	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        distance = Vector3.Distance(Erica.transform.position, Poro.transform.position);

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

	}

    IEnumerator Porowake()
    {
        anim.SetTrigger("EricaArrived");            
        yield return new WaitForSeconds(1.3f);
        PoroRun();
    }

    void PoroRun()
    {
        if (distance <= 2.0f)
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
}
