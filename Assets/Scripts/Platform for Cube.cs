using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformforCube : MonoBehaviour
{
    public GameObject Door;
    public AudioSource audioSource;
    public AudioSource audioSource1;

    private void Start()
    {
        Door.SetActive(true);
        audioSource.enabled = false;
        audioSource1.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        {
            Door.SetActive(false);
            audioSource.enabled = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Cube")
        {
            Door.SetActive(true);
            audioSource1.enabled = true;
        }
    }

}
