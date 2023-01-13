using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class VRDistanceForceLetGo : MonoBehaviour
{
    public XRDirectInteractor myHandInteractor;
    public XRRayInteractor myRayInteractor;
    //GameObject grabbedObject;

    // Start is called before the first frame update
    void Start()
    {
        myHandInteractor = GetComponent<XRDirectInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            myHandInteractor.allowSelect = true;
            //myRayInteractor.allowSelect = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 7 && other.gameObject == other.gameObject)
        {
            myHandInteractor.allowSelect = false;
            //myRayInteractor.allowSelect = false;
        }
    }
}
