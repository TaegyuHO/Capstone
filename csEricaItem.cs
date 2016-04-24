using UnityEngine;
using System.Collections;

public class csEricaItem : MonoBehaviour {

	public bool Key;
	public bool MemoryBook;
	public int CloverCount;

	// Use this for initialization
	void Start () {
		Key = false;
		MemoryBook = false;
		CloverCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AboutKey(){
		Key = !Key;
	}

	public void AboutMemoryBook(){
		MemoryBook = !MemoryBook;
	}


	public void IncreaseCloverCount(){
		CloverCount++;
	}
}
