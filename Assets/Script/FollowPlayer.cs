using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;

    void Start()
    {
        // 自分とtargetとの相対座標を求める.
        offset = GetComponent<Transform>().position - target.position;
    }

    void Update()
    {
        // 自分の座標に(targetの座標 + offfset)を代入する.
        GetComponent<Transform>().position = target.position + offset;
    }
}
