using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGameManager : MonoBehaviour
{
    EEncounterTypes currentEncounterType;
    EEncounterDifficulty currentEncounterDifficulty;

    CPlayer player;
    

    bool bisWaitingInput = false;
    bool bisEncounterFinished = false;

    ushort currentCoordX;
    ushort currentCoordY;
    // Start is called before the first frame update
    void Start()
    {
        player = new CPlayer();
        CCombatStats combatStats = new CCombatStats(10, 8, 9, 10, 7, 5);
        player.combatStats = combatStats;
        Debug.Log(player.combatStats.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
