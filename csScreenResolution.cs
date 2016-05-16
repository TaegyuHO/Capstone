using UnityEngine;
using System.Collections;

public class csScreenResolution : MonoBehaviour {

    void Awake()
    {
        Screen.SetResolution(1024, 600, true);
    }
}
