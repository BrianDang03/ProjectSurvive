using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] GameObject fpsCamera;
    [SerializeField] float zoomOutFOV = 60f;
    [SerializeField] float zoomInFOV = 30f;

    bool zoomInToggle = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            zoomInToggle = !zoomInToggle;

            if (zoomInToggle)
            {
                fpsCamera.GetComponentInParent<CinemachineVirtualCamera>().m_Lens.FieldOfView = zoomInFOV;
            }
            else
            {
                fpsCamera.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView = zoomOutFOV;
            }
        }
    }

    void OnDisable()
    {
        fpsCamera.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView = zoomOutFOV;
    }

}
