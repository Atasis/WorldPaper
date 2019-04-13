using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour {
    public float time_now = 0f;
    public int time_show_s = 0;
    public int time_show_min = 0;

    public Text s;
    public Text min;
    public bool end = false;


  


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!end)
        {
            if (time_show_s >= 60)
            {
                time_now = 0;
                time_show_s = 0;
                time_show_min += 1;
            }
            time_now += Time.deltaTime;
            time_show_s = (int)time_now;
            s.text = time_show_s.ToString();
            min.text = time_show_min.ToString();
        }
        

	}
}
