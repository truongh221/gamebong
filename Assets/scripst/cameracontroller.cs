using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset;
    void Start()
    {
        offset = new Vector3(-6.5f, 1.5f, 0f);  
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset ;
    }
}
