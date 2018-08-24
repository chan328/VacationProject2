using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {
    public GameObject Portal1;
    public GameObject Portal2;
    private bool CanPort;

    private void Start()
    {
        CanPort = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (CanPort == true)
        {
                other.transform.position = Portal2.transform.position;
                StartCoroutine("PortCool");
        }
    }


    IEnumerator PortCool()
    {
        CanPort = false;
        yield return new WaitForSeconds(5);
        CanPort = true;
    }
}
