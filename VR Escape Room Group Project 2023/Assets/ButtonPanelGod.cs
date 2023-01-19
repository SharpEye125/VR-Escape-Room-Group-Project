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

    public int tracker;

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
                else
                {
                    wait = true;
                    tracker = 1;
                }
            }
            else
            {
                bool use1 = button1.GetComponent<PanelButton>().pressed;
                bool use2 = button2.GetComponent<PanelButton>().pressed;
                bool use3 = button3.GetComponent<PanelButton>().pressed;

                if (tracker <= difcount)
                {
                    if (tracker == 1)
                    {
                        if (use1 == true && pos1 == 1 || use2 == true && pos1 == 2 || use3 == true && pos1 == 3)
                        {
                            //good job
                            tracker = 2;
                        }
                        else if (use1 || use2 || use3)
                        {
                            YouMessedUp();
                        }

                    }
                    if (tracker == 2)
                    {
                        if (use1 == true && pos2 == 1 || use2 == true && pos2 == 2 || use3 == true && pos2 == 3)
                        {
                            //good job
                            tracker = 3;
                        }
                        else if (use1 || use2 || use3)
                        {
                            YouMessedUp();
                        }
                    }
                    if (tracker == 3)
                    {
                        if (use1 == true && pos3 == 1 || use2 == true && pos3 == 2 || use3 == true && pos3 == 3)
                        {
                            //good job
                            tracker = 4;
                        }
                        else if (use1 || use2 || use3)
                        {
                            YouMessedUp();
                        }
                    }
                }
                else
                {
                    //you win?
                }
            }
            
        }
    }

    private void YouMessedUp()
    {
        //you messed up
        tracker = 1;
        wait = false;
        count = 0;
        difcount = 3;
    }
}
