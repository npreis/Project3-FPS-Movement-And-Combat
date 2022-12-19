using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public WeaponManagerScript.Weapons weapon;
    public AmmoManagerScript ammo;

    // Start is called before the first frame update
    void Start()
    {
        weapon = gameObject.GetComponent<WeaponManagerScript.Weapons>();
    }

    // Update is called once per frame
    void Update()
    {
        WeaponSwitch();
        FireWeapon();
    }

    void WeaponSwitch()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            weapon = WeaponManagerScript.Weapons.HANDGUN;
            Debug.Log("Handgun Equipped");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weapon = WeaponManagerScript.Weapons.SHOTGUN;
            Debug.Log("Shotgun Equipped");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            weapon = WeaponManagerScript.Weapons.RIFLE;
            Debug.Log("Rifle Equipped");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            weapon = WeaponManagerScript.Weapons.RPG;
            Debug.Log("RPG Equipped");
        }
    }

    void FireWeapon()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(weapon == WeaponManagerScript.Weapons.HANDGUN && ammo.currHandgunAmmo > 0)
            {
                ammo.currHandgunAmmo--;
            }
            if (weapon == WeaponManagerScript.Weapons.SHOTGUN && ammo.currShotgunAmmo > 0)
            {
                ammo.currShotgunAmmo--;
            }
            if (weapon == WeaponManagerScript.Weapons.RIFLE && ammo.currRifleAmmo > 0)
            {
                ammo.currRifleAmmo--;
            }
            if (weapon == WeaponManagerScript.Weapons.RPG && ammo.currRPGAmmo > 0)
            {
                ammo.currRPGAmmo--;
            }
        }
    }
}
