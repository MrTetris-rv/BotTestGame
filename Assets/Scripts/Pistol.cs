using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace StatePattern
{
    public class Pistol : Weapon
    {
        public override void Shoot()
        {
            damage = 5f;
            Bullet.damage = damage;
        }

    }
}