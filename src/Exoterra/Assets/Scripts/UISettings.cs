using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISettings : MonoBehaviour
{
    public Toggle fullscreen;

    public Toggle vsync;

    public List<Resolution> resolutions;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApplyGraphics()
    {
        Screen.fullScreen = fullscreen;

        QualitySettings.vSyncCount = vsync ? 1 : 0;
    }
}

[System.Serializable]
public class Resolution
{
    public int horizontal;

    public int vertical;
}
