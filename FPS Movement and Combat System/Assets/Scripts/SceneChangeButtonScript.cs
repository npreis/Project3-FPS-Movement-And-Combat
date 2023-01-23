using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeButtonScript : MonoBehaviour
{
    public GameObject timer;
    public TimerScript timerReset;
    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("TimeManager");
        timerReset = timer.GetComponent<TimerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene(string sceneName)
    {
        timerReset.timer = 0;
        SceneManager.LoadScene(sceneName);
    }
}
