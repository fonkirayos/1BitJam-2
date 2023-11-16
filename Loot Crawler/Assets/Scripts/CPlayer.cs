using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayer : MonoBehaviour
{
    ushort xp = 0;
    CCombatStats combatStats;
    ushort gold = 9999;

    public CEquipment helmet;
    public CEquipment leftHand;
    public CEquipment rightHand;
    public CEquipment pants;
    public CEquipment boots;
    public CEquipment cape;
    public CEquipment ring;
    public CEquipment amulet;


    //list of magic
    // Start is called before the first frame update
    void Start()
    {
        
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
                    helmet = item;
                    break;
                }
            case EEquipmentType.weapon:
                {
                    leftHand = item;
                    break;
                }
            case EEquipmentType.shield:
                {
                    rightHand = item;
                    break;
                }
            case EEquipmentType.pants:
                {
                    pants = item;
                    break;
                }
            case EEquipmentType.boots:
                {
                    boots = item;
                    break;
                }
            case EEquipmentType.cape:
                {
                    cape = item;
                    break;
                }
            case EEquipmentType.ring:
                {
                    ring = item;
                    break;
                }
            case EEquipmentType.amulet:
                {
                    amulet = item;
                    break;
                }
            default:
                break;
            

        }
    }

    void changeEquipmentStats()
    {

    }
}
