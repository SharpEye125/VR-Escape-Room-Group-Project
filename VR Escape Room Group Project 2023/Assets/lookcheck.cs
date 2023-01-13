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
    public void OnCollisionEnter(Collision col)
    {
        Debug.Log("Haha you looked");
        
    }
       
}
