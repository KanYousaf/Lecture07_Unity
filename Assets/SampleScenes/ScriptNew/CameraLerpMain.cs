using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLerpMain : MonoBehaviour {

    private Transform mTargetTransform;
    private Vector3 offset;
    private float smoothing = 3.0f;

    // Use this for initialization
    void Start()
    {
        offset = new Vector3(-5.0f, 0.0f, 0.0f);
        this.gameObject.SetActive(false);
        mTargetTransform = GameObject.Find("Character").transform;
    }


    void LateUpdate()
    {
        Vector3 targetVectorPosition = mTargetTransform.position + offset;
        transform.LookAt(mTargetTransform);
        transform.position = Vector3.Lerp(transform.position, targetVectorPosition, smoothing * Time.deltaTime);
    }
}
