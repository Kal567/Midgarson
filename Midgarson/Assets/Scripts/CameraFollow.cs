using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    public float yOffset = 2.7f,settingsPosX = 4f,settingsPosY = 5.34f;
    public float MIN_LIM_X = -60, MAX_LIM_X = 130;
    public float FollowSpeed = 10f;
    

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }
    void Update()
    {
        Vector3 newPos = new Vector3(Mathf.Clamp(player.position.x, MIN_LIM_X, MAX_LIM_X), player.position.y + yOffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed*Time.deltaTime);
    }
}
