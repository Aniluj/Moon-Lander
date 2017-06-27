using UnityEngine;

public class FollowCamera : MonoBehaviour 
{
	public Transform target;
	private Vector3 posDiff = Vector3.zero;

	void Start () {

		posDiff = transform.position - target.position;	

	}

	void LateUpdate () {

		transform.position = target.position + posDiff;

	}
}

