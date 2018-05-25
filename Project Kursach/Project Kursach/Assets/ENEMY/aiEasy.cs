using UnityEngine;
using System.Collections;

public class aiEasy : MonoBehaviour {

	public float fpsTargetDistance; // игрок
	public float enemyLookDistance = 40; // дистанйия обзора врага
	public float attackDistance;   // дистанция атаки
	public int enemyMovementSpeed; // скорость врага
	public float damping;
	public Transform fpsTarget;
	Rigidbody theRigidbody;
	Renderer myRender;

    public AnimationClip RunMec;
    public float RunMecSpeed = 1;

    
    // Use this for initialization
    void Start () {
		myRender = GetComponent<Renderer>();
		theRigidbody = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		fpsTargetDistance = Vector3.Distance(fpsTarget.position,transform.position);
		if (fpsTargetDistance<enemyLookDistance){
			
			lookAtPlayer ();
	
		}
		if (fpsTargetDistance < attackDistance) {
		

			attackPlease ();
           // animation[RunMec.name].speed = RunMecSpeed;
        } 
	}
	
	void lookAtPlayer(){
		Quaternion rotation = Quaternion.LookRotation(fpsTarget.position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime*damping);
		
	}

	void attackPlease(){
		theRigidbody.AddForce(transform.forward*enemyMovementSpeed);
	}

}
