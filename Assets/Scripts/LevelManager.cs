using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    // Initializing the required gameobjects
    public LevelObject Level;
    public Camera myCamera;
    public Text LevelNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        // Setting our main camera background color to our camera
        myCamera.backgroundColor = Level.camBackgroundColor;

        Instantiate(Level.LevelPrefab);

        LevelNumber.text = "Level " + Level.levelNumber.ToString();
    }


}
