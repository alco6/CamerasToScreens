
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSplitter : MonoBehaviour
{



    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < Display.displays.Length; i++) { 
            //Activate display at that size
            Display.displays[i].Activate(1920, 1080, 60);

            //Full Screen
            Screen.SetResolution(1920, 1080, true);
        }
        //  Screen.fullScreenMode = FullScreenMode.FullScreenWindow;

    }


}