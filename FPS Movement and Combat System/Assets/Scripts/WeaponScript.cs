using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public WeaponManagerScript.Weapons weapon;

    // Start is called before the first frame update
    void Start()
    {
        weapon = gameObject.GetComponent<WeaponManagerScript.Weapons>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    void CheckInput()
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
}
