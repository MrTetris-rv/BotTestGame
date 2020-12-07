using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    [CreateAssetMenu]
    public class SearchingWeaponState : State
    {
        public State NoWeaponState;
        //[SerializeField]public GameObject Awp;
        public static bool isAwp, isPistol;
        public Transform targetWeapon;

        public override void Init()
        {
            var weapons = GameObject.FindGameObjectsWithTag("Awp");
            var weapons2 = GameObject.FindGameObjectsWithTag("Pistol");
            if (weapons.Length == 0)
            {
                bot.SetState(NoWeaponState);
            }
            targetWeapon = weapons[Random.Range(0, weapons.Length)].transform;
            
        }

        public override void Run()
        {
            if (IsFinished) return;
            MoveToWeapon();
        }

        public void MoveToWeapon()
        {
                var distance = (targetWeapon.position - bot.transform.position).magnitude;
                if (distance > 0.5f)
                {
                    bot.MoveTo(targetWeapon.position);
                }
                else
                {
                 isAwp = true;
                Destroy(targetWeapon.gameObject);
                IsFinished = true;
                }
            }
        }
    }

