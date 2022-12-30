using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatusScript : MonoBehaviour
{
    public int currHP;
    public int currArmor;

    public int maxHP;
    public int maxArmor;

    public Text HPText;
    public Text armorText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HPText.text = currHP.ToString();
        armorText.text = currArmor.ToString();
    }
}
