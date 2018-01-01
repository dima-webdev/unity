using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blip2 : MonoBehaviour
{
	[SerializeField] private GameObject _blip;
	private MiniMap map;
	private RectTransform myRectTransform;
	private Lidar lidar;
	public Transform Target;
	
	private void Start()
	{
		map = GetComponentInParent<MiniMap>();
		myRectTransform = GetComponent<RectTransform>();
		lidar = GetComponent<Lidar>();
	}

	void Update()
	{
		//Debug.Log(_player.transform.position);
	}

	void LateUpdate()
	{
		Vector3 newpoint = _blip.transform.position;
		Vector2 newPosition = map.TransformPosition(newpoint);
		Debug.Log(newPosition);
		myRectTransform.localPosition = newPosition;
	}
}