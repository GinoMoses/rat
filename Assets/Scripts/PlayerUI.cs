using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI strLevelText;
    public void UpdatePlayerUI(int strLevel, int dexLevel, int intLevel)
    {
        strLevelText.text = strLevel.ToString();
    }
}
