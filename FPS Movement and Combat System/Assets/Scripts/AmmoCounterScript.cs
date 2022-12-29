using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCounterScript : MonoBehaviour
{
    public Text currAmmo;
    public Text maxAmmo;

    public AmmoManagerScript ammoManager;

    public void SetAmmo(WeaponManagerScript.Weapons weapon)
    {
        switch(weapon)
        {
            case (WeaponManagerScript.Weapons.HANDGUN):
            {
                    currAmmo.text = ammoManager.currHandgunAmmo.ToString();
                    maxAmmo.text = ammoManager.maxHandgunAmmo.ToString();
                    break;
            }
            case (WeaponManagerScript.Weapons.SHOTGUN):
            {
                    currAmmo.text = ammoManager.currShotgunAmmo.ToString();
                    maxAmmo.text = ammoManager.maxShotgunAmmo.ToString();
                    break;
            }
            case (WeaponManagerScript.Weapons.RIFLE):
            {
                    currAmmo.text = ammoManager.currRifleAmmo.ToString();
                    maxAmmo.text = ammoManager.maxRifleAmmo.ToString();
                    break;
            }
            case (WeaponManagerScript.Weapons.RPG):
            {
                    currAmmo.text = ammoManager.currRPGAmmo.ToString();
                    maxAmmo.text = ammoManager.maxRPGAmmo.ToString();
                    break;
            }
        }
    }
}
