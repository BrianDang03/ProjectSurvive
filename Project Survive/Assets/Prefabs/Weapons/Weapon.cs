using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] float weaponDmg = 30f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range))
        {
            Debug.Log($"Hit: {hit.transform.name}");

            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();

            if (target)
            {
                target.TakeDamage(weaponDmg);
            }
        }

        return;
    }
}
