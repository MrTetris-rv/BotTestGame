using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StatePattern
{
    public abstract class Weapon : MonoBehaviour
    {
        public float damage;
        public int delay; //задержка между выстрелами
        public bool isBotDead;

        public abstract void Shoot();
        //private void OnTriggerEnter(Collider other)
        //{
        //    if (Bot.k == 0)
        //    {
        //        if (other.gameObject.tag == "Bot")
        //        {
        //            //Destroy(gameObject);
        //        }
        //    }
        //}
    }
}



