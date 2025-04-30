using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject prompt;
    public GameObject menu;

    private bool inRange = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    
        {
            if (inRange && Input.GetKeyDown(KeyCode.E))
            {
            menu.SetActive(true);
            FindAnyObjectByType<CharacterMovement>().enabled = false;
            }
        }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            prompt.SetActive(true);
            inRange = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            prompt.SetActive(false);
            inRange = false;
        }
    }

   
}
