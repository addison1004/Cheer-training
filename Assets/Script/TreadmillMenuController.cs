using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TreadmillMenuController : MonoBehaviour
{
    public TMP_Text speedText;
    private PlayerStats playerStats;
    // Start is called before the first frame update
    void Start()
    {
        playerStats = FindAnyObjectByType<PlayerStats>();
        
    }

    // Update is called once per frame
    void Update()
    {
        speedText.text = playerStats.speed.ToString();
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
        FindAnyObjectByType<PlayerStats>().speed += 10;
        //Decrease time by 1 hour
        FindAnyObjectByType<PlayerStats>().timeLeft--;
        //update speed text
        speedText.text = playerStats.speed.ToString();
    }
}