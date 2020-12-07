using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBots : MonoBehaviour
{
    //public List<GameObject> bots = new List<GameObject>();
    public GameObject Bot;
    public int seconds = 3;
    public void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(seconds);
            Instantiate(Bot, new Vector3(Random.Range(10f, 14.84f), 0.5f, Random.Range(5.05f, 9.83f)), Quaternion.identity);
            //bots.Add(Bot);
            }
       
        
    }
}
