using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWeapon : MonoBehaviour
{
    public GameObject deagle;

    private void Start()
    {
        StartCoroutine(Spawn());
        Instantiate(deagle, transform.position, Quaternion.identity);
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(4f);
            Instantiate(deagle, new Vector3(Random.Range(-18f, 20f), 0.1f, Random.Range(-18f, 18f)), Quaternion.identity);
        }
    }
}
