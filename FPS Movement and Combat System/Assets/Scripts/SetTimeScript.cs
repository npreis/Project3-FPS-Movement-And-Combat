using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTimeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject timer;
    public TimerScript tScript;
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;

        timer = GameObject.Find("TimeManager");
        tScript = timer.gameObject.GetComponent<TimerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
