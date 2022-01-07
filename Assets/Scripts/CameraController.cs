using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary> The controller of the camara to follow the player</summary>
public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 distance;

    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - player.transform.position;    
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + distance;
    }
}
