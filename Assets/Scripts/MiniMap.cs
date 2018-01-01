using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniMap : MonoBehaviour
{
	public Transform Target;
	
	public Quaternion TransformRotation(Quaternion rotation)
	{
		Quaternion offset = Target.rotation;
		Quaternion newRotation = Quaternion.Euler(0,0,offset.z);
		return newRotation;
	}


	public Vector2 TransformPosition(Vector3 position)
	{
		Vector3 offset = position - Target.position;
		Vector2 newPosition = new Vector2(offset.x,offset.z);
		return newPosition;
	}
}
