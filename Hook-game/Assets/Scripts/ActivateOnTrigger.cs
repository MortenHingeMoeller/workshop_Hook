using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnTrigger : MonoBehaviour
{
    //public List<GameObject> objToActivate = new List<GameObject>();

    public GameObject objectToActivate;

    public GameObject objectToDeActivate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ActivateObject();
            DeactivateObject();

            DeactivateThisTrigger();
        }
    }

    private void ActivateObject() 
    { 
        if (objectToActivate != null) 
        { 
            objectToActivate.gameObject.SetActive(true);
        }
    }

    private void DeactivateObject()
    {
        if (objectToDeActivate != null)
        {
            objectToDeActivate.gameObject.SetActive(false);
        }
    }

    private void DeactivateThisTrigger()
    {
        this.gameObject.SetActive(false);
    }
}
