using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPArmorPickupScript : MonoBehaviour
{
    public enum PickupType
    {
        ARMOR,
        HEALTH
    }

    public GameObject gObject;
    public PlayerStatusScript status;
    public PickupType pickup;

    public int armorAdd;
    public int HPAdd;

    private void Start()
    {
        status.GetComponent<PlayerStatusScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            HealPlayer(pickup);
        }
    }

    void HealPlayer(PickupType pickup)
    {
        switch(pickup)
        {
            case PickupType.ARMOR:
                if(status.currArmor == status.maxArmor)
                {
                    break;
                }
                else
                {
                    if(status.currArmor + armorAdd > status.maxArmor)
                    {
                        status.currArmor = status.maxArmor;
                    }
                    else
                    {
                        status.currArmor += armorAdd;
                    }
                    Destroy(gObject);
                    break;
                }

            case PickupType.HEALTH:
                if (status.currHP == status.maxHP)
                {
                    break;
                }
                else
                {
                    if (status.currHP + HPAdd > status.maxHP)
                    {
                        status.currHP = status.maxHP;
                    }
                    else
                    {
                        status.currHP += HPAdd;
                    }
                    Destroy(gObject);
                    break;
                }
        }
    }
}
