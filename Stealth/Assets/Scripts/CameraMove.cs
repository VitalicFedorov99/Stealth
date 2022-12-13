using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private GameObject _objectFollow;
    [SerializeField] private Vector3 _vector;
    [SerializeField] private float _speed;
    private Vector3 pos;


    private void Start()
    {
        pos = transform.position - _objectFollow.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = _objectFollow.transform.position + pos;
        //if (Input.GetKey(KeyCode.Mouse1))
        //{
           // transform.Rotate(new Vector3(_vector.x, _vector.y, _vector.z) * Time.deltaTime * _speed);
        //}
    }


}
