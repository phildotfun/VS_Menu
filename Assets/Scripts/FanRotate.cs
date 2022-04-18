using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRotate : MonoBehaviour
{

    [SerializeField] float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate fan
        transform.Rotate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    }
}
