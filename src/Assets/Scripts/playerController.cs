using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mainCamera.transform.position = mousePosition;
		Debug.Log($"Position x: {mousePosition.x} Position y: {mousePosition.y}");
    }
}
