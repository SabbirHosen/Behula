using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject[] MusicObject, MusicObjectButtonPress, MusicObjectButtonPressOver;

    private void Awake()
    {
        MusicObject = GameObject.FindGameObjectsWithTag("BGMusic");
        if (MusicObject.Length >= 2)
        {
            Destroy(MusicObject[1]);
        }

        MusicObjectButtonPress = GameObject.FindGameObjectsWithTag("ButtonPress");
        if (MusicObjectButtonPress.Length >= 4)
        {
            Destroy(MusicObjectButtonPress[0]);
        }

        MusicObjectButtonPressOver = GameObject.FindGameObjectsWithTag("ButtonPressOver");
        if (MusicObjectButtonPressOver.Length >= 4)
        {
            Destroy(MusicObjectButtonPressOver[0]);
        }
    }
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
