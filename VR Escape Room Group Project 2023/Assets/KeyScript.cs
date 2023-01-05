using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class KeyScript : MonoBehaviour
{
    [SerializeField] bool inKeySlot = false;
    GameObject keyInTheSlot;
    public GameObject prefabTrophy;
    // Start is called before the first frame update
    void Start()
    {
        //XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        //grabbable.activated.AddListener(KeyActivate);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            inKeySlot = true;
            keyInTheSlot = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Key"))
        {
            inKeySlot = false;
        }
    }
    public void SpawnTrophy()
    {
        if (inKeySlot)
        {
            Instantiate(prefabTrophy, transform.position + new Vector3(0, 1, 0), prefabTrophy.transform.rotation);
            Destroy(keyInTheSlot);
            Destroy(gameObject);
        }

    }
}
