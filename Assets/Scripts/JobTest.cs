using UnityEngine;
using Unity.Jobs;


/* GOALS
 *
 * JobTest scene runs very slow because of the repeated dummy math operation below. Implement the for loop below, using parallelized Unity jobs and Burst compiler to gain performance
 * If the 'count' is too large for your machine to handle, you can decrease it.
 * 
 */


struct myJob : IJobParallelFor
{
	//Creating a "Values" array to hold "values" array in our JobTest class. 
	public float[] Values;


	public void Execute(int a)
    {
		Values[a] = Mathf.Sqrt(Mathf.Pow(Values[a] + 1.75f, 2.5f + a)) * 5 + 2f;

	}
}

public class JobTest : MonoBehaviour
{
	// When we switch this value to true for using the job that we created above we will see how much performance that we gain
	[SerializeField]
	private bool useJob = false;
	


	private int count = 1000000;

	private float[] values;


	void Start()
	{
		values = new float[count];
		
	}


	void Update()
	{

		if (useJob)
		{
			// Initialazing the job struct that we created before
			var job = new myJob
			{
				Values = this.values,
			};

			// We are schedule the job for concurrent execution on a number of worker threads.
			JobHandle scheduleParallelJobHandle = job.Schedule(values.Length, 64);
			scheduleParallelJobHandle.Complete();
			

		}
		else
		{

			for (int i = 0; i < values.Length; i++)
			{
				
				values[i] = Mathf.Sqrt(Mathf.Pow(values[i] + 1.75f, 2.5f + i)) * 5 + 2f;
			}

		}

	}


}