using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoManagerScript : MonoBehaviour
{
    public int maxHandgunAmmo;
    public int maxShotgunAmmo;
    public int maxRifleAmmo;
    public int maxRPGAmmo;

    public int currHandgunAmmo;
    public int currShotgunAmmo;
    public int currRifleAmmo;
    public int currRPGAmmo;

    public int handgunAmmoGain;
    public int shotgunAmmoGain;
    public int rifleAmmoGain;
    public int RPGAmmoGain;

    public float handgunCooldown;
    public float shotgunCooldown;
    public float rifleCooldown;
    public float RPGCooldown;
}
