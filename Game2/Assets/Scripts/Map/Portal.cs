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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (CanPort == true)
        {
            if (this.tag == "Portal1")
            {
                other.transform.position = Portal2.transform.position + new Vector3(-0.5f, 0);
                StartCoroutine("PortCool");
            }
            else if (this.tag == "Portal2")
            {
                other.transform.position = Portal1.transform.position + new Vector3(0.5f, 0);
                StartCoroutine("PortCool");
            }
        }
    }
    IEnumerator PortCool()
    {
        CanPort = false;
        yield return new WaitForSeconds(5);
        CanPort = true;
    }
}
