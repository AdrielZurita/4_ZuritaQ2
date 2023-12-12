using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Updatedparallex : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.postion.x;
        length - GetComponet<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = (cam.transform.postion.x * paralaxEffect);
        transform.postion = newVector(startPos + dist, transform.postion.y, transform.postion.z);