using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Lidar : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0,5,0);
        //Луч находится в том же положении и нацеливается в том же направлении, что и объект
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        //Испущенный луч заполняет информацией переменную, на которую имеется ссылка
        if (Physics.Raycast(ray, out hit))
        {
            //Загружаем в сообщение координаты точки, в которую попал луч
            Messenger<Vector3>.Broadcast(GameEvent.NEW_BLIP, hit.point);
            Debug.DrawLine(transform.position, hit.point, Color.green);
            //Debug.Log("Hit " + points);
            //StartCoroutine(SphereIndicator(hit.point));
        }
    }
    
    /*private IEnumerator SphereIndicator(Vector3 pos) 
    {
        _blip = Instantiate(_blipPrefab) as GameObject;
        _blip.transform.parent = _map.transform;
        _myRectTransform = _blip.GetComponent<RectTransform>();
        Vector3 offset = pos - Target.position;
        Vector2 newPosition = new Vector2(offset.x,offset.z);
        _myRectTransform.localPosition = newPosition;

        yield return new WaitForSeconds(1);

        Destroy(_blip);
    }*/
    
}