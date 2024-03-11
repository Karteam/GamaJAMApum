using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosingDoorTrigger : MonoBehaviour
{
    public GameObject Door;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Door.SetActive(true);
        }
    }
}
