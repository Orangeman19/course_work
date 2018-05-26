using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadNotes: MonoBehaviour {

    public float distance;

    [SerializeField]
    private GameObject Note;
    [SerializeField]
    private GameObject textNote;

	// Use this for initialization
	void Start () {
        Note.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		

        if(Input.GetKeyDown(KeyCode.E))
        {
            ReadNote();
         }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Note.SetActive(false);
            textNote.GetComponent<Text>().text = "";
        }
	}
    void ReadNote() {

        Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        RaycastHit hit; // объект пересечения лучач
        if (Physics.Raycast(ray, out hit, distance))
        {
            if (hit.collider.GetComponent<Note>())
            {
                Note.SetActive(true);
                textNote.GetComponent<Text>().text = hit.collider.GetComponent<Note>().textNote;
            }

        }

    }
}
