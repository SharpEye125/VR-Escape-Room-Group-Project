using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thebutton : MonoBehaviour
{
    public Transform buttontop;
    public Transform buttonlowlimit;
    public Transform buttonuplimit;
    public float threshhold;
    public float force;
    private float uplowdiff;
    public bool pressed;
    public AudioSource press;
    public AudioSource release;
    public bool clicky;
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(GetComponent<Collider>(), buttontop.GetComponent<Collider>());
        if (transform.eulerAngles != Vector3.zero)
        {
            Vector3 savedangle = transform.eulerAngles;
            transform.eulerAngles = Vector3.zero;
            uplowdiff = buttonuplimit.position.y - buttonlowlimit.position.y;
            transform.eulerAngles = savedangle;
        }
        else
        {
            uplowdiff = buttonuplimit.position.y - buttonlowlimit.position.y;
        }
    }

    // Update is called once per frame
    void Update()
    {
        buttontop.transform.localPosition = new Vector3(0, buttontop.transform.localPosition.y, 0);
        buttontop.transform.localEulerAngles = new Vector3(0, 0, 0);
        if(buttontop.transform.localPosition.y >= 0)
        {
            buttontop.transform.position = new Vector3(buttonuplimit.position.x, buttonuplimit.position.y, buttonuplimit.position.z);
        }
        else
        {
            buttontop.GetComponent<Rigidbody>().AddForce(buttontop.transform.up * force * Time.fixedDeltaTime);
        }
        if(buttontop.localPosition.y <= buttonlowlimit.localPosition.y)
        {
            buttontop.transform.position = new Vector3(buttonlowlimit.position.x, buttonlowlimit.position.y, buttonlowlimit.position.z);
        }
        if(Vector3.Distance(buttontop.position, buttonlowlimit.position)< uplowdiff*threshhold)
        {
            pressed = true;
            GetComponent<MeshRenderer>().material.color = Color.blue;
            if (pressed == true && clicky == true)
            {
                clicky = false;
                press.pitch = 1 * Random.Range(.8f, 1.2f);
                press.Play();
                //Changes Current Puzzle Stage:
                //FindObjectOfType<PuzzleManager>().stage = 1;
            }
        }
        else
        {
            pressed = false;
            GetComponent<MeshRenderer>().material.color = Color.red;
            if (pressed== false && clicky == false)
            {
                clicky = true;
                press.pitch = 1 * Random.Range(.8f, 1.2f);
                press.Play();
            }
        }
    }
}
