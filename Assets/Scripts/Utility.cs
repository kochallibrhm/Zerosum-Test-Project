
using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

/*
 * 
 * 
 * Complete the functions below.  
 * For sure, they don't belong in the same class. This is just for the test so ignore that.
 * 
 * 
 */



public static class Utility 
{


	public static GameObject[] GetObjectsWithName(string name)
	{

		/*
		 * 
		 *	Return all objects in the scene with the specified name. Don't think about performance, do it in as few lines as you can. 
		 * 
		 */

		// Creating a GameObject list.
		List<GameObject> goList = new List<GameObject>();

		// Finding the all GameObjects
		foreach (GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
		{
			if (gameObj.name == name)
			{
				// Adding the object to the list if the objects' name is name
				goList.Add(gameObj);
			}
			
		}

		// Typecasting the list to an array
		GameObject[] gameObjects = goList.ToArray();

		return gameObjects;
	}


	public static bool CheckCollision(Ray ray, float maxDistance, int layer)
	{
		/*
		 * 
		 *	Perform a raycast using the ray provided, only to objects of the specified 'layer' within 'maxDistance' and return if something is hit. 
		 * 
		 */


		var isHit = false;
		// Initializing hit
		RaycastHit hit;

		if(Physics.Raycast(ray, out hit, maxDistance))
        {
			// If ray hitting something within 'maxDistance' setting isHit to true
			isHit = true;
        }

		return isHit;
		
	}





	public static Vector2[] GeneratePoints(int size)
	{
		/*
		 * Generate 'size' number of random points, making sure they are distributed as evenly as possible (Trying to achieve maximum distance between every neighbor).
		 * Boundary corners are (0, 0) and (1, 1). (Point (1.2, 0.45) is not valid because it's outside the boundaries. )
		 * Is there a known algorithm that achieves this?
		 */

		// We are setting 2 offsets for determine a random range and addition to provide the maximum distance as possible.
		var offset0 = 0.0f;
		var offset1 = 0.0f;
		var addition = 1.0f / size;

		// Creating a Vector2 array to hold points.
		Vector2[] points = null;

		for (int i = 0; i < size; i++)
        {

			offset1 += addition;
			Vector2 point = new Vector2(Random.Range(offset0, offset1), Random.Range(offset0, offset1));
			points[i] = point;
			offset0 = offset1;
        }

		return points;
	}


	public static Texture2D GenerateTexture(int width, int height, Color color)
	{
		/*
		 * Create a Texture2D object of specified 'width' and 'height', fill it with 'color' and return it. Do it as performant as possible.
		 */


		Texture2D myTexture = new Texture2D(width, height);
		
		for (int i = 0; i < width; i++)
        {
			for (int j = 0; j < height; j++)
            {
				myTexture.SetPixel(i, j, color);
            }
        }
		myTexture.Apply();


		return myTexture;
	}




}