using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    public class Bot : MonoBehaviour
    {
       
        public GameObject weapon1, weapon2;
        private string Tag = "Awp";
        private string Tag2 = "Pistol";
        public static int k = 0;

        public State SearchingWeaponState;
        public State RandomMoveState;
        public State Attack;
        public State SawTarget;

        public State CurrentState;


        private void Start()
        {
            SetState(SearchingWeaponState);
        }

        private void Update()
        {
            if (!CurrentState.IsFinished)
            {
                CurrentState.Run();
            }
            else if(k == 0)
            {
                SetState(SearchingWeaponState);
            }
            else if(k > 0)
            {
                SetState(SawTarget);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (k == 0)
            {
                if (other.gameObject.tag == Tag)
                {           
                    weapon1.SetActive(true);
                    k++;
                    print(Tag);
                }
                if (other.gameObject.tag == Tag2)
                {
                   
                    k++;
                    weapon2.SetActive(true);
                    print(Tag2);
                }
            }
            else if (k > 0)
            {
                gameObject.tag = "Untagged";
            }
        }

        public void SetState(State state)
        {
            CurrentState = Instantiate(state);
            CurrentState.bot = this;
            CurrentState.Init();
        }
        public void MoveTo(Vector3 position)
        {
            position.y = transform.position.y;

            transform.position = Vector3.MoveTowards(transform.position, position, Time.deltaTime * 3);
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(position - transform.position), Time.deltaTime * 120f);
        }
    }
}
