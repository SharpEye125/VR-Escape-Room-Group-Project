using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class KeyScript : MonoBehaviour
{
    [SerializeField] bool inKeySlot = false;

    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(KeyActivate);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Key Slot"))
        {
            inKeySlot = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Key Slot"))
        {
            inKeySlot = false;
        }
    }
    public void KeyActivate(ActivateEventArgs arg)
    {
        if (inKeySlot == true)
        {
            Instantiate(prefab, transform.position + new Vector3(0, 5, 0), transform.rotation.normalized);
        }
    }
}
