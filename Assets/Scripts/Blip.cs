using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blip : MonoBehaviour
{
	public Transform Target;
	private MiniMap _map;
	private RectTransform _myRectTransform;
	//private GameObject _player;
	
	private void Start()
	{
		_map = GetComponentInParent<MiniMap>();
		_myRectTransform = GetComponent<RectTransform>();
	}

	void Update()
	{
		//Debug.Log(_player.transform.position);
	}

	void LateUpdate()
	{
		_myRectTransform.rotation = Quaternion.Euler(0,0,-Target.localEulerAngles.y);
		Vector2 newPosition = _map.TransformPosition(Target.position);
		_myRectTransform.localPosition = newPosition;
	}
}
