using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zomby : MonoBehaviour
{

    public GameObject player;
    public float dist;
    NavMeshAgent Nav;
    public float Radius;

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
    }
}
