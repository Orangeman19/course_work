using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_Player : MonoBehaviour {
    public Image UIHP;
    public float HP = 1f;    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        UIHP.fillAmount = HP;
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ruk")
        {
            HP = HP - 0.1f;
        }

        if (other.tag == "Ved")
        {
            HP = HP - 0.2f;
        }

       

    }
}
