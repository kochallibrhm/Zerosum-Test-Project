using UnityEngine;
using System.Collections;


/*
 * 
 * Implement a scriptable object that can be created editor right-click context menu. The object should have the following properties:
 * Level number
 * Camera background color
 * Level prefab (You can use cubes, spheres, etc. placed randomly)
 * Win condition (Use an enum, "Clear all area" or "Clear specific area")
 * Write a level manager that loads the created level objects and initiates the level
 * Make the system testable in the scene LevelTest
 * 
 */

[CreateAssetMenu(fileName = "New Level", menuName = "Level")]

public class LevelObject : ScriptableObject {

    public int levelNumber;
    public Color camBackgroundColor;
    public GameObject LevelPrefab;
    enum WinConditions {DestroyObjects, KillEnemies}
    
}