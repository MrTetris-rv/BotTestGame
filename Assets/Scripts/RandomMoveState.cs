using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    [CreateAssetMenu]
    public class RandomMoveState : State
    {
        public float MaxDistance = 4.5f;
        Vector3 randomPosition;
        State SawTarget;
        public override void Init()
        {
            var randomed = new Vector3(Random.Range(-MaxDistance, MaxDistance), 0f, Random.Range(-MaxDistance, MaxDistance));
            randomPosition = bot.transform.position + randomed;

        }
        public override void Run()
        {
            var distance = (randomPosition - bot.transform.position).magnitude;

            if (distance > 0.5f)
            {
                bot.MoveTo(randomPosition);
            }
            else
            {
                IsFinished = true;
                SawTarget.Run();
            }
        }

    }
}