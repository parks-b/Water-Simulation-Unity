using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameCapp : MonoBehaviour
{
    public int FPS = 30;

    void Start()

    {

        QualitySettings.vSyncCount = 0;

        Application.targetFrameRate = FPS;

    }
}
