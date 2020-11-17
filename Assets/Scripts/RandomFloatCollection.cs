using UnityEngine;
using UnityEditor;
using System.Collections;


/*
 * 
 * A persistent type of asset, not living in any scene, is needed for a system.
 * It needs to be created inside the editor in the right-click context menu ("Create/Random/FloatCollection").
 * Item's inspector should show an array of floats, just like a regular behaviour's inspector.
 * There should be a button in the inspector that says "Generate" and it should populate the array shown, with random values between 0 and 1.
 * The generated values should persist between editor sessions, scene loads, etc. So make sure of that.
 * 
 * 
 * Code from UnityEditor namespace is not allowed in the build, but RandomFloatCollection class should make it to the build. 
 * Use preprocessor definitions to handle that. What would you do if for some reason you weren't allowed to use preprocessor definitions?
 * 
 * Continue implementing the class however you wish.
 * 
 * 
 */

[CustomEditor(typeof(RandomFloatScript))]


public class RandomFloatCollection : Editor{

    
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        RandomFloatScript rf = (RandomFloatScript)target;

        // We are checking if button pressed.
        if (GUILayout.Button("Generate"))
        {
            //Debug.Log("ButtonClicked");
            rf.generateArray(rf.RandomFloatArray);
        }
    }

}
