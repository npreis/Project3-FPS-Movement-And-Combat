using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public WeaponManagerScript.Weapons weapon;
    public AmmoManagerScript ammo;
    public AmmoCounterScript counter;

    public float cooldown;
    public Camera camera;
    public GameObject enemy;

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

        if(cooldown > 0.0f)
        {
            cooldown -= Time.deltaTime;
            if(cooldown <= 0.0f)
            {
                cooldown = 0.0f;
            }
        }

        counter.SetAmmo(weapon);
    }

    void WeaponSwitch()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) && weapon != WeaponManagerScript.Weapons.HANDGUN)
        {
            weapon = WeaponManagerScript.Weapons.HANDGUN;
            cooldown = 0.0f;
            Debug.Log("Handgun Equipped");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && weapon != WeaponManagerScript.Weapons.SHOTGUN)
        {
            weapon = WeaponManagerScript.Weapons.SHOTGUN;
            cooldown = 0.0f;
            Debug.Log("Shotgun Equipped");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && weapon != WeaponManagerScript.Weapons.RIFLE)
        {
            weapon = WeaponManagerScript.Weapons.RIFLE;
            cooldown = 0.0f;
            Debug.Log("Rifle Equipped");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) && weapon != WeaponManagerScript.Weapons.RPG)
        {
            weapon = WeaponManagerScript.Weapons.RPG;
            cooldown = 0.0f;
            Debug.Log("RPG Equipped");
        }
    }

    void FireWeapon()
    {
        if(Input.GetKey(KeyCode.Mouse0) && cooldown == 0.0f && Time.timeScale > 0)
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            int layerMask = 11;

            if (weapon == WeaponManagerScript.Weapons.HANDGUN && ammo.currHandgunAmmo > 0)
            {
                ammo.currHandgunAmmo--;
                cooldown = ammo.handgunCooldown;

                if(Physics.Raycast(ray, out hit, 50, layerMask))
                {
                    Debug.Log("Hit object");
                    enemy = hit.transform.gameObject;
                    enemy.GetComponent<EnemyHealthScript>().DecreaseHealth(ammo.handgunDamage);
                }
            }
            if (weapon == WeaponManagerScript.Weapons.SHOTGUN && ammo.currShotgunAmmo > 0)
            {
                ammo.currShotgunAmmo--;
                cooldown = ammo.shotgunCooldown;

                if (Physics.Raycast(ray, out hit, 25, layerMask))
                {
                    Debug.Log("Hit object");
                    enemy = hit.transform.gameObject;
                    enemy.GetComponent<EnemyHealthScript>().DecreaseHealth(ammo.shotgunDamage);
                }
            }
            if (weapon == WeaponManagerScript.Weapons.RIFLE && ammo.currRifleAmmo > 0)
            {
                ammo.currRifleAmmo--;
                cooldown = ammo.rifleCooldown;

                if (Physics.Raycast(ray, out hit, 100, layerMask))
                {
                    Debug.Log("Hit object");
                    enemy = hit.transform.gameObject;
                    enemy.GetComponent<EnemyHealthScript>().DecreaseHealth(ammo.rifleDamage);
                }
            }
            if (weapon == WeaponManagerScript.Weapons.RPG && ammo.currRPGAmmo > 0)
            {
                ammo.currRPGAmmo--;
                cooldown = ammo.RPGCooldown;

                if (Physics.Raycast(ray, out hit, 60, layerMask))
                {
                    Debug.Log("Hit object");
                    enemy = hit.transform.gameObject;
                    enemy.GetComponent<EnemyHealthScript>().DecreaseHealth(ammo.RPGDamage);
                }
            }
        }
    }
}
