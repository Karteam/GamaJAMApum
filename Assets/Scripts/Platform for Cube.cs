using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformforCube : MonoBehaviour
{
    public GameObject Door;
 

    public GameObject audio1;
    public GameObject audio2;



    private void Start()
    {
        Door.SetActive(true);
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        {
            Door.SetActive(false);
          Instantiate(audio1, transform.position, transform.rotation);
     
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Cube")
        {
            Door.SetActive(true);
            Instantiate(audio2, transform.position, transform.rotation);
        }
    }

}
