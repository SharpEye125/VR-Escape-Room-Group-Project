using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public int stage;

    public GameObject b;
    public GameObject bAL;
    public GameObject bIL;
    public bool bA;

    public GameObject d;
    public GameObject dAL;
    public GameObject dIL;
    public bool dA;

    public GameObject kH1;
    public GameObject kH1AL;
    public GameObject kH1IL;
    public bool kH1A;

    public GameObject p3x3;
    public GameObject p3x3AL;
    public GameObject p3x3IL;
    public bool p3x3A;

    public GameObject bP1;
    public GameObject bP1AL;
    public GameObject bP1IL;
    public bool bP1A;

    public GameObject p2x2;
    public GameObject p2x2AL;
    public GameObject p2x2IL;
    public bool p2x2A;

    public GameObject kH2;
    public GameObject kH2AL;
    public GameObject kH2IL;
    public bool kH2A;

    public GameObject kH3;
    public GameObject kH3AL;
    public GameObject kH3IL;
    public bool kH3A;

    public GameObject kH4;
    public GameObject kH4AL;
    public GameObject kH4IL;
    public bool kH4A;

    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
    public GameObject key4;

    /*
     This is a list of the stages and what part of the puzzle it refers to.

        //-Stage 0: There is nothing complete, you are in the room with the button on the wall and the key in the chest                                                     0     Press button
        //-Stage 1: The button has been pressed so the keyholder appears and awaits the key                                                                                   1     Key slot appears
        //-Stage 2: The key has been inserted so the button,chest and key/keyholder all receed. 3x3 panel moves down for the button panel to enter                               2     Key is entered so button panel appears
        //-Stage 3: The player interacts with the button panel so it proceeds to light up in the order it needs to be done in                                                      3     Button panel Puzzle
        //-Stage 4: The button panel receeds and the 3x3 block covers the exit, then the voice says that it says gullible on the ceiling.                                             4    It says gullible
       // -Stage 5: The player looks up, gets mocked and then all the keys fall from the roof as the 2x2 block moves, the second key slot appears                                         5    Keys fall
        //-Stage 6: Key slot 2 is complete, so key slot 3 appears                                                                                                                            6    Key 2 done
        //-Stage 7: Key slot 3 is complete so key slot 4 appears                                                                                                                                7    Key 3 done
        //-Stage 8: Key slot 4 is complete so all keys and key slots receed and some victory stuff happens.                                                                                       8    Key 4 done, all is done
    */

    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        PositionManager();
        if (stage == 0)
        {
            bA = true;
            dA = true;

            if (b.GetComponentInChildren<Thebutton>().pressed == true)
            {
                stage = 1;
            }
        }
        if (stage == 1)
        {
            bA = false;
            kH1A = true;

            // if(KEY 1 INSERTED)
            // {
            //    stage = 2;
            //  }
        }
        if (stage == 2)
        {
            kH1A = false;
            dA = false;
            p3x3A = true;
            bP1A = true;

            /*if(bP1.complete == true)
            {
               stage = 3;
            }*/
        }
        if (stage == 3)
        {
            p3x3A = false;
            bP1A = false;
            //It says gullible on the ceiling


        }
        if (stage == 4)
        {
            p2x2A = true;
            kH2A = true;
        }
        if (stage == 5)
        {
            kH2A = false;
            kH3A = true;
        }
        if (stage == 6)
        {
            kH3A = false;
            kH4A = true;
        }
        if (stage == 7)
        {
            kH4A = false;
        }
    }

    private void PositionManager()
    {
        //BUTTON
        if (bA == true)
        {
            b.transform.position += (bAL.transform.position - b.transform.position).normalized * Time.deltaTime;
        }
        else
        {
            b.transform.position += (bIL.transform.position - b.transform.position).normalized * Time.deltaTime;
        }

        //DRAWER
        if (dA == true)
        {
            d.transform.position += (dAL.transform.position - d.transform.position).normalized * Time.deltaTime;
        }
        else
        {
            d.transform.position += (dIL.transform.position - d.transform.position).normalized * Time.deltaTime;
        }

        //KEY HOLE 1    kH1
        if (kH1A == true)
        {
            kH1.transform.position += (kH1AL.transform.position - kH1.transform.position).normalized * Time.deltaTime;
        }
        else
        {
            kH1.transform.position += (kH1IL.transform.position - kH1.transform.position).normalized * Time.deltaTime;
        }

        //PANEL 3x3 p3x3
        if (p3x3A == true)
        {
            p3x3.transform.position += (p3x3AL.transform.position - p3x3.transform.position).normalized * Time.deltaTime;
        }
        else
        {
            p3x3.transform.position += (p3x3IL.transform.position - p3x3.transform.position).normalized * Time.deltaTime;
        }

        //BUTTON PANEL 1 bP1
        if (bP1A == true)
        {
            bP1.transform.position += (bP1AL.transform.position - bP1.transform.position).normalized * Time.deltaTime;
        }
        else
        {
            bP1.transform.position += (bP1IL.transform.position - bP1.transform.position).normalized * Time.deltaTime;
        }

        //PANEL 2x2     p2x2
        if (p2x2A == true)
        {
            p2x2.transform.position += (p2x2AL.transform.position - p2x2.transform.position).normalized * Time.deltaTime;
        }
        else
        {
            p2x2.transform.position += (p2x2IL.transform.position - p2x2.transform.position).normalized * Time.deltaTime;
        }

        //KEY HOLE 2              kH2
        if (kH2A == true)
        {
            kH2.transform.position += (kH2AL.transform.position - kH2.transform.position).normalized * Time.deltaTime;
        }
        else
        {
            kH2.transform.position += (kH2IL.transform.position - kH2.transform.position).normalized * Time.deltaTime;
        }

        //KEY HOLE 3 kH3
        if (kH3A == true)
        {
            kH3.transform.position += (kH3AL.transform.position - kH3.transform.position).normalized * Time.deltaTime;
        }
        else
        {
            kH3.transform.position += (kH3IL.transform.position - kH3.transform.position).normalized * Time.deltaTime;
        }

        // KEY HOLE 4     kH4
        if (kH4A == true)
        {
            kH4.transform.position += (kH4AL.transform.position - kH4.transform.position).normalized * Time.deltaTime;
        }
        else
        {
            kH4.transform.position += (kH4IL.transform.position - kH4.transform.position).normalized * Time.deltaTime;
        }
    }
}

       