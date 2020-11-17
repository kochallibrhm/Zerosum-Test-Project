using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Create", menuName = "Random/FloatCollection")]
public class RandomFloatScript : ScriptableObject
{
    
    public float[] RandomFloatArray = new float[10];

    public void generateArray(float[] randomFloat)
    {
        // Generating the array.
        for(int i = 0; i < randomFloat.Length; i++)
        {
            randomFloat[i] = Random.Range(0f, 1f);
        }
    }
}
