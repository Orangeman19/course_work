using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemy : MonoBehaviour {

    public GameObject player;
    public float dist;
    NavMeshAgent Nav;
    public float Radius=15;
   

    void Start()
    {
        Nav = GetComponent<NavMeshAgent>();
   
    }
	void Update () {

        dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist>Radius)
        {
            Nav.enabled = false;
            gameObject.GetComponent<Animator>().SetTrigger("Idle");
        }
        if (dist<Radius)
        {
            Nav.enabled = true;
            Nav.SetDestination(player.transform.position);
            gameObject.GetComponent<Animator>().SetTrigger("Run");
            Radius = 40;
                    }
      
        if (dist < 3)
        {
            Nav.enabled = false;

            gameObject.GetComponent<Animator>().SetTrigger("Attack");
        }
      
	}
}
