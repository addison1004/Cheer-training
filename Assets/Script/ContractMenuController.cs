using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContractMenuController : MonoBehaviour
{
    public TMP_Text firstStatText;
    public TMP_Text secondStatText;
    public TMP_Text thirdStatText;
    public GameObject winPopup;

    public int firstStatGoal = 100;
    public int secondStatGoal = 75;
    public int thirdStatGoal = 50;
    private PlayerStats playerStats;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = FindAnyObjectByType<PlayerStats>();

    }

    // Update is called once per frame
    void Update()
    {
        firstStatText.text = playerStats.speed.ToString() + "/" + firstStatGoal.ToString();
        secondStatText.text = playerStats.stamina.ToString() + "/" + secondStatGoal.ToString();
        thirdStatText.text = playerStats.social.ToString() + "/" + thirdStatGoal.ToString();

    }

    public void CancelMenu()
    {
        gameObject.SetActive(false);
        FindAnyObjectByType<CharacterMovement>().enabled = true;
    }

    public void SignButton()
    {
        if (playerStats.speed >= firstStatGoal
         && playerStats.stamina >= secondStatGoal
         && playerStats.social >= thirdStatGoal)
        {
            winPopup.SetActive(true);

        }
    }

}
 