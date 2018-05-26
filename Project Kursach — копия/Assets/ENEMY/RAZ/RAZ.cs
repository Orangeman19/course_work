using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RAZ : MonoBehaviour
{

    public GameObject player;
    public float dist;
    NavMeshAgent Nav;
    public float Radius = 15;
    public float HP = 120; // жизни врага
    public GameObject Ragdoll;//смерть


    void Start()
    {
        Nav = GetComponent<NavMeshAgent>();

    }
    void Update()
    {
        if (HP < 0)
        {
            Instantiate(Ragdoll, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist > Radius)
        {
            Nav.enabled = false;
            gameObject.GetComponent<Animator>().SetTrigger("idle");
        }
        if (dist > 12)
        {
            Nav.enabled = true;
            Nav.SetDestination(player.transform.position);
            gameObject.GetComponent<Animator>().SetTrigger("see");
            Radius = 40;
        }

       // if (dist < 3)
      //  {
        //    Nav.enabled = false;

       //     gameObject.GetComponent<Animator>().SetTrigger("Attack");
       // }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RukP")
        {
            HP = HP - 15;
        }
    }
}
