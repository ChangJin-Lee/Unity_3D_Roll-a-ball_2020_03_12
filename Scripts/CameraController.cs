using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset; // 이 스크립트에서만 사용함

    // Start is called before the first frame update
    void Start()
    {
        // 카메라의 위치에서 공의 위치를 뺌
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        
    }
}
