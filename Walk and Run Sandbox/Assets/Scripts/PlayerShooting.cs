using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public int ammoCount =10;
    public int maxAmmo = 10;
    public GameObject prefab;
    public Transform instancer;
    public float reloadTime;
    public WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private bool canShoot = true;
    // Start is called before the first frame update
    void Start()
    {
        ammoCount = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammoCount > 0 && canShoot)
        {
            fire();
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(reload());
        }
    }

    private void fire()
    {

        Instantiate(prefab, instancer.position, instancer.rotation);
        ammoCount--;

        if (ammoCount == 0)
        {
            StartCoroutine(reload());

        }
    }
    
    private IEnumerator reload()
    {
        canShoot = false;
        var countDown = reloadTime;
        while (countDown > 0)
        {
            yield return wffu;
            countDown -= .01f;
            
        }
        
        ammoCount = maxAmmo;
        canShoot = true;
    }
}
