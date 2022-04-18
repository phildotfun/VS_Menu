using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayMovement : MonoBehaviour
{
    [SerializeField] Transform from;
    [SerializeField] Transform to;
    [SerializeField] float speed = 0.01f;
    float timeCount = 0.0f;



    public void Update()
    {
        ButtonRotate();
    }

    public void ButtonRotate()
    {
        transform.rotation = Quaternion.Lerp(from.rotation, to.rotation, timeCount * speed);
        timeCount = timeCount + Time.deltaTime;
    }

}
