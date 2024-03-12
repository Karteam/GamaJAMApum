using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPortal : MonoBehaviour
{
    public Transform destinationPortal;

    public PortalManager pm;

    public Datamosh dm;

    public Transform plr;

    public GameObject audio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = destinationPortal.position;
            pm.IsStart = true;
            Instantiate(audio, plr.position, plr.rotation);
            dm.Glitch();

        }
    }
}
