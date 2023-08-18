using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveLoad : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("LaunchAmount"))
        {
            int launchAmount = PlayerPrefs.GetInt("LaunchAmount");
            launchAmount++;
            text.text = $"Times Launched: {launchAmount}";
            PlayerPrefs.SetInt("LaunchAmount", launchAmount);
        }

        else
        {
            text.text = $"Times Launched: {1}";
            PlayerPrefs.SetInt("LaunchAmount", 1);
        }
    }
}
