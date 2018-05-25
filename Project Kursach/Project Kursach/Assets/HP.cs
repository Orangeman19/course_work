using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour {
    public int maxhp;
    public int hp;
    public Slider slide;

	// Use this for initialization
	void Start () {
        maxhp = 100;
        hp = maxhp;

	}
	
	// Update is called once per frame
	void Update () {
        slide.value = hp;
        if (Input.GetKeyDown(KeyCode.F))
        {
            hp -= 25;
        }
        if (hp > maxhp)
        {
            hp = maxhp;

        }
        if (hp < 0)
        {
            hp = 0;
        }
	}
}
