using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickupScript : MonoBehaviour
{
    public WeaponManagerScript.Weapons weaponType;
    public AmmoManagerScript ammoType;

    public GameObject pickup;

    // Start is called before the first frame update
    void Start()
    {
        weaponType = gameObject.GetComponent<WeaponManagerScript.Weapons>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            CollectAmmo(weaponType);
        }
    }

    void CollectAmmo(WeaponManagerScript.Weapons weapon)
    {
        switch(weapon)
        {
            case WeaponManagerScript.Weapons.HANDGUN:
                if(ammoType.currHandgunAmmo == ammoType.maxHandgunAmmo)
                {
                    break;
                }
                else
                {
                    if(ammoType.currHandgunAmmo + ammoType.handgunAmmoGain > ammoType.maxHandgunAmmo)
                    {
                        ammoType.currHandgunAmmo = ammoType.maxHandgunAmmo;
                    }
                    else
                    {
                        ammoType.currHandgunAmmo += ammoType.handgunAmmoGain;
                    }

                    Destroy(pickup);
                    break;
                }
                

            case WeaponManagerScript.Weapons.SHOTGUN:
                if (ammoType.currShotgunAmmo == ammoType.maxShotgunAmmo)
                {
                    break;
                }
                else
                {
                    if (ammoType.currShotgunAmmo + ammoType.shotgunAmmoGain > ammoType.maxShotgunAmmo)
                    {
                        ammoType.currShotgunAmmo = ammoType.maxShotgunAmmo;
                    }
                    else
                    {
                        ammoType.currShotgunAmmo += ammoType.shotgunAmmoGain;
                    }

                    Destroy(pickup);
                    break;
                }

            case WeaponManagerScript.Weapons.RIFLE:
                if (ammoType.currRifleAmmo == ammoType.maxRifleAmmo)
                {
                    break;
                }
                else
                {
                    if (ammoType.currRifleAmmo + ammoType.rifleAmmoGain > ammoType.maxRifleAmmo)
                    {
                        ammoType.currRifleAmmo = ammoType.maxRifleAmmo;
                    }
                    else
                    {
                        ammoType.currRifleAmmo += ammoType.rifleAmmoGain;
                    }

                    Destroy(pickup);
                    break;
                }

            case WeaponManagerScript.Weapons.RPG:
                if (ammoType.currRPGAmmo == ammoType.maxRPGAmmo)
                {
                    break;
                }
                else
                {
                    if (ammoType.currRPGAmmo + ammoType.RPGAmmoGain > ammoType.maxRPGAmmo)
                    {
                        ammoType.currRPGAmmo = ammoType.maxRPGAmmo;
                    }
                    else
                    {
                        ammoType.currRPGAmmo += ammoType.RPGAmmoGain;
                    }

                    Destroy(pickup);
                    break;
                }
        }
    }
}
