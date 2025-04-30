using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControllerMenuController : MonoBehaviour
{
    public TMP_Text socialText;
    private PlayerStats playerStats;
    // Start is called before the first frame update
    void Start()
    {
        playerStats = FindAnyObjectByType<PlayerStats>();
      
    }

    // Update is called once per frame
    void Update()
    {
        socialText.text = playerStats.social.ToString();
    }

    public void CancelMenu()
    {
        gameObject.SetActive(false);
        FindAnyObjectByType<CharacterMovement>().enabled = true;
    }
    public void TrainButton()
    {

        if (playerStats.timeLeft <= 0)
        {
            return;
        }

        //Increase player speed
        FindAnyObjectByType<PlayerStats>().social += 10;
        //Decrease time by 1 hour
        FindAnyObjectByType<PlayerStats>().timeLeft--;
        //update speed text
        socialText.text = playerStats.social.ToString();
    }
}