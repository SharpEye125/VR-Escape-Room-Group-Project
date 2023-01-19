using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelButton : MonoBehaviour
{
    public bool pressed;
    public GameObject VFX;
    public int dur;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Hand")
        {
            pressed = true;
            GameObject explosion = Instantiate(VFX, transform.position, transform.rotation);
            Destroy(explosion, dur);

        }
    } 
    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Hand")
        {
            pressed = false;

        }


    }
}
