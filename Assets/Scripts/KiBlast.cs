﻿using UnityEngine;

public class KiBlast : MonoBehaviour
{
    [SerializeField] private float speed = 0.0F;
    [SerializeField] private float damage = 1.0F;
    private Camera mainCamera = null;

    private void Start()
    {
        mainCamera = Camera.main;
    }
    private void Update()
    {
        Vector3 screenPoint = mainCamera.WorldToViewportPoint(transform.position);
        bool onScreen = screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1;
        if (onScreen == false)
        {
            Destroy(gameObject);
        }

        Vector3 newPosition = transform.position;
        Vector3 moveAmount = transform.up * speed * Time.deltaTime;
        newPosition.x += moveAmount.x;
        newPosition.y += moveAmount.y;
        newPosition.z += moveAmount.z;
        transform.position = newPosition;
    }
}