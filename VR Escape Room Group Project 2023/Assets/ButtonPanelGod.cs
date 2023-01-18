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

    public int ran;

    public float timer;

    public float delay;

    public int difcount;
    public int count;

    public int pos1;

    public int pos2;

    public int pos3;

    public int pos4;

    public int pos5;



    // Start is called before the first frame update
    void Start()
    {
        difcount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (active == true)
        {
            if (wait == false)
            {
                if (count <= difcount)
                {
                    timer += Time.deltaTime;
                    if (timer >= delay)
                    {

                        ran = Random.Range(1, 4);
                        if (ran == 1)
                        {

                        }
                        if (ran == 2)
                        {

                        }
                        if (ran == 3)
                        {

                        }
                        if(count == 1)
                        {
                            pos1 = ran;
                        }
                        if (count == 2)
                        {
                            pos2 = ran;
                        }
                        if (count == 3)
                        {
                            pos3 = ran;
                        }
                        if (count == 4)
                        {
                            pos4 = ran;
                        }
                        if (count == 5)
                        {
                            pos5 = ran;
                        }

                        count += 1;
                        timer = 0;
                    }
                }
            }
            
        }
    }
}
