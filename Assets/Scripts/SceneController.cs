using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    //Создаем сериализованные переменные лидара и игрока
    /*[SerializeField] private GameObject _lidarPrefab;
    private GameObject _lidar;
    [SerializeField] private GameObject _playerPrefab;
    private GameObject _player;*/
    [SerializeField] private GameObject _blipPrefab;
    private GameObject _blip;
    private List<GameObject> _blips;
    [SerializeField] private GameObject _map;
    private RectTransform _myRectTransform;
    public Transform Target;

    void Awake()
    {
        Messenger<Vector3>.AddListener(GameEvent.NEW_BLIP, NewBlip);
    }

    public void NewBlip(Vector3 point)
    {
        _blip = Instantiate(_blipPrefab) as GameObject;
        _blip.transform.parent = _map.transform;
        _myRectTransform = _blip.GetComponent<RectTransform>();
        Vector3 offset = point - Target.position;
        Vector2 newPosition = new Vector2(offset.x,offset.z);
        _myRectTransform.localPosition = newPosition;
        StartCoroutine(SphereIndicator(_blip));
    }
    
    private IEnumerator SphereIndicator(GameObject blip) 
    {
       yield return new WaitForSeconds(1);
        Destroy(blip);
    }
} 

