using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    [CreateAssetMenu]
    public class NoWeaponState : State
    {
        public override void Run()
        {
            if (IsFinished) return;
            IsFinished = true;
        }
    }
}
