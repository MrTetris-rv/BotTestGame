using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace StatePattern
{
    [CreateAssetMenu]
    public class SawTarget : State
    {
        public Transform target;

        public override void Init(){
            var bots = GameObject.FindGameObjectsWithTag("Bot");
            for (int i = 0; i <= bots.Length; i++)
            {
                target = bots[i].transform;
            }
        }
        public override void Run()
        {
            if (target != null)
            {
                MoveToTarget();
            }
        }
        public void MoveToTarget() {
            var distance = (target.position - bot.transform.position).magnitude;
            if (distance > 0.5f)
            {
                bot.MoveTo(target.position);
            }
            else
            {
                Destroy(target.gameObject);
                IsFinished = true;
            }
        }
       
    }
}
