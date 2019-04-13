using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bachi_times : MonoBehaviour {

    public float bachi = 0;
    public Text bachiTimes;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        bachiTimes.text = bachi.ToString();
	}
}
