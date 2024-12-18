using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quitting : MonoBehaviour
{
    // Start is called before the first frame update
    public void QuitScene()
    {
        Application.Quit();

        Debug.Log("Quit Game.");

    }
}
