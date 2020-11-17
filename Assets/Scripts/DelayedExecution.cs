using System.Collections;
using UnityEngine;


public class DelayedExecution : MonoBehaviour
{

	/*
 * 
 * 
 * Implement the function 'Do' below so that it can be called from any context.
 * You want to pass it a function and a float 'delay'. After 'delay' seconds, the function is to be executed.
 * You can create as many additional functions as you need.
 * Assume that this class needs to be a 'MonoBehaviour', so don't change that.
 * 
 * 
 */


	private void Start()
    {
		StartCoroutine(DelayCoroutine());
    }

	IEnumerator DelayCoroutine()
    {
		// Print the time of when the function is first called.
		Debug.Log("Started Coroutine at timestamp : " + Time.time);

		// yield on a new YieldInstruction that waits for 5 seconds.
		yield return new WaitForSeconds(5);

		// Calling our Do function after delay.
		Do();

		// After we have waited 5 seconds print the time again.
		Debug.Log("Finished Coroutine at timestamp : " + Time.time);
	}

    public static void Do()
    {
		Debug.Log("HELLO WORLD FROM DO FUNCTION!!!");
    }


}

