using UnityEngine;
using System.Collections;

public class dialog : MonoBehaviour
{

    [TextArea(3,5)]
    public string labelText;
    public bool hasCollider;

    void OnGUI()
    {
        if (hasCollider == true)
        {
            GUI.Box(new Rect(145, Screen.height - 100, Screen.width - 300, 120), labelText);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        hasCollider = true;
    }
    void OnTriggerExit(Collider other)
    {
       // hasCollider = false;
        Destroy(gameObject);
    }
}