using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

class Weapon : MonoBehaviour
{

    public Transform firepoint;
    public GameObject bulletPrefab;


    GameObject Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clone = (GameObject)Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
            return clone;
        }
        return null;
    }
    void Update()
    {
        GameObject clone = Shoot();
        Destroy(clone, 5f);


    }
}


