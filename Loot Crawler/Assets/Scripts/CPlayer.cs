using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayer : MonoBehaviour
{
    int xp = 0;
    public CCombatStats combatStats;
    int gold = 9999;

    public CEquipment helmet;
    public CEquipment weapon;
    public CEquipment shield;
    public CEquipment pants;
    public CEquipment boots;
    public CEquipment cape;
    public CEquipment ring;
    public CEquipment amulet;


    //list of magic
    // Start is called before the first frame update
    void Start()
    {
        combatStats = new CCombatStats(10, 10, 10, 10, 10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeEquipment(ref CEquipment item)
    {
        switch (item.type)
        {
            case EEquipmentType.helmet:
                {
                    changeEquipmentStats(ref helmet, ref item);
                    helmet = item;
                    break;
                }
            case EEquipmentType.weapon:
                {
                    changeEquipmentStats(ref weapon, ref item);
                    weapon = item;
                    break;
                }
            case EEquipmentType.shield:
                {
                    changeEquipmentStats(ref shield, ref item);
                    shield = item;
                    break;
                }
            case EEquipmentType.pants:
                {
                    changeEquipmentStats(ref pants, ref item);
                    pants = item;
                    break;
                }
            case EEquipmentType.boots:
                {
                    changeEquipmentStats(ref boots, ref item);
                    boots = item;
                    break;
                }
            case EEquipmentType.cape:
                {
                    changeEquipmentStats(ref cape, ref item);
                    cape = item;
                    break;
                }
            case EEquipmentType.ring:
                {
                    changeEquipmentStats(ref ring, ref item);
                    ring = item;
                    break;
                }
            case EEquipmentType.amulet:
                {
                    changeEquipmentStats(ref amulet, ref item);
                    amulet = item;
                    break;
                }
            default:
                break;
            

        }
    }

    void changeEquipmentStats(ref CEquipment a, ref CEquipment b)
    {
        combatStats -= a.stats;
        combatStats += b.stats;
    }
}
