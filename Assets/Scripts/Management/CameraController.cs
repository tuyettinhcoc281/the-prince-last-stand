using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Cinemachine;

public class CameraController : Singleton<CameraController>
{
    private CinemachineCamera cinemachineVirtualCamera;

    private void Start()
    {
        SetPlayerCameraFollow();
    }
 

    protected override void Awake()
    {
        base.Awake();
        cinemachineVirtualCamera = FindObjectOfType<CinemachineCamera>();
        if (cinemachineVirtualCamera == null)
        {
            Debug.LogError("CinemachineVirtualCamera not found in the scene.");
        }
    }

    public void SetPlayerCameraFollow()
    {
        if (cinemachineVirtualCamera != null)
        {
            cinemachineVirtualCamera.Follow = PlayerController.Instance.transform;
        }
        else
        {
            Debug.LogError("CinemachineVirtualCamera is not initialized."); 
        }
    }
}
