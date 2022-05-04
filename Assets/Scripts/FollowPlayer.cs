using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Variables
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //transform.position = player.transform.position + new Vector3(3, 3.5f, -4.5f);
        transform.position = player.transform.position + new Vector3(-4, 10, -3);
    }
}
