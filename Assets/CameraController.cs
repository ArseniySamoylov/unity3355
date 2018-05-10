using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    // расстояние от камеры до объекта
    private Vector3 offset;
    // Объект, за который следит камера
    // Указываем public для того, чтобы после появилось в редакторе
    public GameObject target;
    // Use this for initialization

    void Start () {
        offset = target.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = target.transform.position - offset;
	}
}
