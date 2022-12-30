using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCounterScript : MonoBehaviour
{
    public Text currAmmo;
    public Text maxAmmo;
    public Text weaponName;

    public AmmoManagerScript ammoManager;

    public void SetAmmo(WeaponManagerScript.Weapons weapon)
    {
        switch(weapon)
        {
            case (WeaponManagerScript.Weapons.HANDGUN):
            {
                    weaponName.text = "Handgun";
                    currAmmo.text = ammoManager.currHandgunAmmo.ToString();
                    maxAmmo.text = ammoManager.maxHandgunAmmo.ToString();
                    break;
            }
            case (WeaponManagerScript.Weapons.SHOTGUN):
            {
                    weaponName.text = "Shotgun";
                    currAmmo.text = ammoManager.currShotgunAmmo.ToString();
                    maxAmmo.text = ammoManager.maxShotgunAmmo.ToString();
                    break;
            }
            case (WeaponManagerScript.Weapons.RIFLE):
            {
                    weaponName.text = "Rifle";
                    currAmmo.text = ammoManager.currRifleAmmo.ToString();
                    maxAmmo.text = ammoManager.maxRifleAmmo.ToString();
                    break;
            }
            case (WeaponManagerScript.Weapons.RPG):
            {
                    weaponName.text = "RPG";
                    currAmmo.text = ammoManager.currRPGAmmo.ToString();
                    maxAmmo.text = ammoManager.maxRPGAmmo.ToString();
                    break;
            }
        }
    }
}
