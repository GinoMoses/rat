using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlItemPickup : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            // somehow recognize one of three types of lvl items, then adjust player stats accordingly
            // for now, just increase level and strLevel and destroy the item
            PlayerCombat player = GameObject.Find("Player").GetComponent<PlayerCombat>();
            player.level++;
            player.strLevel++;
            Destroy(gameObject);
            PlayerUI playerUI = GameObject.Find("PlayerUI").GetComponent<PlayerUI>();
            playerUI.UpdatePlayerUI(player.strLevel, player.dexLevel, player.intLevel);
        }
    }
}
