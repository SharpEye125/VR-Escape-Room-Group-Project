using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPanelGod : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    public bool active;

    public bool wait;

    public bool ran;

    public float timer;

    public float delay;

    public int difcount;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        difcount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(active == true)
        {
            if(count=<difcount)
            timer += Time.deltaTime;
            if(timer>=delay)
            {

            }
        }
    }
}
