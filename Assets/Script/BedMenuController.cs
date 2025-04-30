using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BedMenuController : MonoBehaviour
{
    public TMP_Text timeLeftText;
    private PlayerStats playerStats;
    // Start is called before the first frame update
    void Start()
    {
        playerStats = FindAnyObjectByType<PlayerStats>();
   

    }

    // Update is called once per frame
    void Update()
    {
        timeLeftText.text = playerStats.timeLeft.ToString();
    }

    public void CancelMenu()
    {
        gameObject.SetActive(false);
        FindAnyObjectByType<CharacterMovement>().enabled = true;
    }

    public void TrainButton()
    {

        //Decrease time by 1 hour
        FindAnyObjectByType<PlayerStats>().timeLeft = 24;
        //update speed text
        timeLeftText.text = playerStats.timeLeft.ToString();
    }
}