
using UnityEngine;
using UnityEngine.AI;

public class BasicAi : MonoBehaviour
{
	public Transform Destination;

	private NavMeshAgent agent;
	// Use this for initialization
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Destination != null) agent.destination = Destination.position;
	}
}
