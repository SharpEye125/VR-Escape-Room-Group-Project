using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookcheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay(Collider col)
    {
        if(col.gameObject.GetComponent<Look>() != null)
            {
            Debug.Log("Appppppple");
            if(FindObjectOfType<PuzzleManager>().stage == 3)
            {
                Debug.Log("You Looked!");
                FindObjectOfType<PuzzleManager>().stage = 4;
            }
        }
        
        
    }
       
}
