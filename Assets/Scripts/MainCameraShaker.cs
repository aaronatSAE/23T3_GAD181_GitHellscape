using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Shakes the camera when space bar is held.
/// </summary>
public class MainCameraShaker : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Vector3 anchorPosition;
    [SerializeField] private float shakeDistanceInMeters = 0.1f;
    [SerializeField] private bool isShaking = false;

    private void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        anchorPosition = mainCamera.transform.position;
    }

    private void Update()
    {
        // If the player is holding the space bar...
        isShaking = Input.GetKey(KeyCode.Space);

        // ...shake the gameobject around a bit!
        if (isShaking)
        {
            mainCamera.transform.position = anchorPosition + new Vector3(Random.Range(-shakeDistanceInMeters, shakeDistanceInMeters),
                                                              Random.Range(-shakeDistanceInMeters, shakeDistanceInMeters),
                                                              Random.Range(-shakeDistanceInMeters, shakeDistanceInMeters));
        }
        else
        {
            mainCamera.transform.position = anchorPosition;
        }
    }
}
