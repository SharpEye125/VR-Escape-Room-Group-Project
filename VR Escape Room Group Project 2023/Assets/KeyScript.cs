using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class KeyScript : MonoBehaviour
{
    [SerializeField] bool inKeySlot = false;
    GameObject keyInTheSlot;
    public GameObject prefabTrophy;
    int currentStage;
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
        if (inKeySlot && prefabTrophy != null)
        {
            Instantiate(prefabTrophy, transform.position + new Vector3(0, 1, 0), prefabTrophy.transform.rotation);
            Destroy(keyInTheSlot);
            Destroy(gameObject);
        }

    }
    public void KeyInsertDynamic()
    {
        //Checks current stage and sets it to easier to type variable
        currentStage = FindObjectOfType<PuzzleManager>().stage;
        //In hopes to use 1 function for all keys, this checks the current stage the game is at and sets it to the next stage
        switch (currentStage)
        {
            case 1:
                FindObjectOfType<PuzzleManager>().stage = 2;
                Destroy(keyInTheSlot);
                Destroy(gameObject);
                break;
            case 5:
                FindObjectOfType<PuzzleManager>().stage = 6;
                Destroy(keyInTheSlot);
                Destroy(gameObject);
                break;
            case 6:
                FindObjectOfType<PuzzleManager>().stage = 7;
                Destroy(keyInTheSlot);
                Destroy(gameObject);
                break;
            case 7:
                FindObjectOfType<PuzzleManager>().stage = 8;
                Destroy(keyInTheSlot);
                Destroy(gameObject);
                break;
        }
    }
}
