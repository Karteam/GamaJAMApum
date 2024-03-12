using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class Theend : MonoBehaviour
{
    public GameObject chel;

    public AudioSource audio;


    public Datamosh dm;

    private void Start()
    {
        chel.SetActive(false);
        audio.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            chel.SetActive(false);
            dm.Glitch();
            audio.enabled = true;
            StartCoroutine(Exitt());
        }
    }

    IEnumerator Exitt()
    {
        yield return new WaitForSeconds(2f);

        Application.Quit();
    }

}
