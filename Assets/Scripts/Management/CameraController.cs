using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Cinemachine;

public class CameraController : Singleton<CameraController>
{
    private CinemachineCamera cinemachineCamera;

    private void Start() {
        SetPlayerCameraFollow();
    }

    public void SetPlayerCameraFollow() {
        cinemachineCamera = FindObjectOfType<CinemachineCamera>();
        cinemachineCamera.Follow = PlayerController.Instance.transform;
    }
    
}
