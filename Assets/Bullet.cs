using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject BulletPrefab;

    private Transform gun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(BulletPrefab, gun.position), Quaternion.identity);
            go.GetComponent<Rigidbody>(),AddForce(gun.forward * 1000f);
        }
    }
}
