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
    public float HP = 200; // жизни врага
    public GameObject Ragdoll;//смерть

    // Use this for initialization
    void Start()
    {
        Nav = GetComponent<NavMeshAgent>();

    }
    void Update()
    {
        if (HP <= 0)
        {
            Instantiate(Ragdoll, transform.position, transform.rotation);
            Destroy(gameObject);
        }

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
            Radius = 80;

        }
        if (dist < 10)
        {
            Nav.enabled = true;
            Nav.SetDestination(player.transform.position);
            gameObject.GetComponent<Animator>().SetTrigger("run");
            

        }
        if (dist < 3)
        {
            Nav.enabled = false;
            gameObject.GetComponent<Animator>().SetTrigger("attack");
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RukP")
        {
            HP = HP - 50;
        }
    }
}