using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManagerScript : MonoBehaviour
{
    public TutorialManagerScript instance;
    public GameObject tutorialCanvas;
    public List<TutorialScript> tutorials;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        tutorials.AddRange(GetComponents<TutorialScript>());
        instance.Unlock("Welcome");
    }

    // Update is called once per frame
    void Update()
    {
        if (tutorialCanvas.activeInHierarchy)
        {
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Time.timeScale = 1;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

    }

    public TutorialScript FindTutorialEntry(string str)
    {
        for (int i = 0; i < tutorials.Count; i++)
        {
            if (tutorials[i].title == str)
            {
                return tutorials[i];
            }
        }
        return null;
    }

    public void Unlock(string str)
    {
        TutorialScript tutorial = FindTutorialEntry(str);
        tutorial.TutorialActivate();
    }
}
