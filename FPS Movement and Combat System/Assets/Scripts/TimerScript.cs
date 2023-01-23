using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float timer;
    float min;
    float sec;
    public Text timerText;

    private static TimerScript timerInstance;
    // Start is called before the first frame update

    private void Awake()
    {
        if(timerInstance == null)
        {
            timerInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        timer = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    void Timer()
    {
        timer += Time.deltaTime;
        sec = (int)(timer % 60);
        min = (int)(timer / 60);
        timerText.text = min.ToString("00") + " : " + sec.ToString("00");

        timerText = GameObject.Find("Timer").GetComponent<Text>();
    }

    public void SetText()
    {
        //timerText = GameObject.Find("Timer").GetComponent<Text>();
    }
}
