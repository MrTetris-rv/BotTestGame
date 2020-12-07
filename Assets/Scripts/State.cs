﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    public abstract class State : ScriptableObject
    {
       public bool IsFinished { get; protected set; }
        [HideInInspector] public Bot bot;

        public virtual void Init() { }
        public abstract void Run();
    }
}
