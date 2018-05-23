using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class e_scrarecrow : MonoBehaviour
{

    public GameObject player;
    public float dist;
    NavMeshAgent Nav;
    public float Radius;

    // Use this for initialization
    void Start()
    {
        Nav = GetComponent<NavMeshAgent>();

    }
    void Update()
    {

        dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist > Radius)
        {
            Nav.enabled = false;
            gameObject.GetComponent<Animator>().SetTrigger("Idle");
        }
        if (dist < Radius)
        {
            Nav.enabled = true;
            Nav.SetDestination(player.transform.position);
            gameObject.GetComponent<Animator>().SetTrigger("walk");
            Radius = 40;

        }

    }
}