using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    [SerializeField]
    float openDoor;
    [SerializeField]
    float closeDoor;
    [SerializeField]
    float speed = 1;

    public bool isOpen;
	// Use this for initialization
	void Start () {
		
	}
	// Проверка открыта ли дверь.
	void Update () {
        if (isOpen)
        {
            OpenDoor();
        }
        else
        {
            CloseDoor();
        }
	}

    void OpenDoor() 
    {                                                                                               // угол поворота openDoor          // скорость поворота 
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x, openDoor, transform.rotation.z), speed * Time.deltaTime);	
     }
     
    void CloseDoor()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x, closeDoor, transform.rotation.z), speed * Time.deltaTime);


    }

}
