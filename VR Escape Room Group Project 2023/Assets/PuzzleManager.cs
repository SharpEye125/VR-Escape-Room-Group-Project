using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public int stage;

    public GameObject b;
    public Vector3 bAL;
    public Vector3 bIL;

    public GameObject d;
    public Vector3 dAL;
    public Vector3 dIL;

    public GameObject kH1;
    public Vector3 kH1AL;
    public Vector3 kH1IL;

    public GameObject p3x3;
    public Vector3 p3x3AL;
    public Vector3 p3x3IL;

    public GameObject bP;
    public Vector3 bPlAL;
    public Vector3 bPlIL;

    public GameObject p2x2;
    public Vector3 p2x2AL;
    public Vector3 p2x2IL;

    public GameObject kH2;
    public Vector3 kH2AL;
    public Vector3 kHr2IL;

    public GameObject kH3;
    public Vector3 kH3AL;
    public Vector3 kH3IL;

    public GameObject kH4;
    public Vector3 kH4AL;
    public Vector3 kH4IL;

    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
    public GameObject key4;

    /*
     This is a list of the stages and what part of the puzzle it refers to.

        -Stage 0: There is nothing complete, you are in the room with the button on the wall and the key in the chest                                                     0     Press button
        -Stage 1: The button has been pressed so the keyholder appears and awaits the key                                                                                   1     Key slot appears
        -Stage 2: The key has been inserted so the button,chest and key/keyholder all receed. 3x3 panel moves down for the button panel to enter                               2     Key is entered so button panel appears
        -Stage 3: The player interacts with the button panel so it proceeds to light up in the order it needs to be done in                                                      3     Button panel Puzzle
        -Stage 4: The button panel receeds and the 3x3 block covers the exit, then the voice says that it says gullible on the ceiling.                                             4    It says gullible
        -Stage 5: The player looks up, gets mocked and then all the keys fall from the roof as the 2x2 block moves, the second key slot appears                                         5    Keys fall
        -Stage 6: Key slot 2 is complete, so key slot 3 appears                                                                                                                            6    Key 2 done
        -Stage 7: Key slot 3 is complete so key slot 4 appears                                                                                                                                7    Key 3 done
        -Stage 8: Key slot 4 is complete so all keys and key slots receed and some victory stuff happens.                                                                                       8    Key 4 done, all is done
    */

    void Start()
    { 
      
    }
      
    

    // Update is called once per frame
    void Update()
    {
        if(stage ==0)
        {

        }
        else
        {

        }
        if (stage == 1)
        {

        }
        else
        {

        }
        if (stage == 2)
        {

        }
        else
        {

        }
        if (stage == 3)
        {

        }
        else
        {

        }
        if (stage == 0)
        {

        }
        else
        {

        }
    }
}
