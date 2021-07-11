using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset; // �� ��ũ��Ʈ������ �����

    // Start is called before the first frame update
    void Start()
    {
        // ī�޶��� ��ġ���� ���� ��ġ�� ��
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        
    }
}
