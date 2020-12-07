using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace StatePattern
{
    public class Bullet : MonoBehaviour
    {
        public int Speed;
        Vector3 lastPos;
        public static float damage;
        void Start()
        {
            lastPos = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            RaycastHit hit;
            Debug.DrawLine(lastPos, transform.position);
            if (Physics.Linecast(lastPos, transform.position, out hit))
            {
                print(hit.transform.name);
                if (hit.transform.name == "Cube (1)") //проверка пули
                {
                    Health.numberHealth -= damage;
                    print(damage);
                }
                Destroy(gameObject);
            }
            lastPos = transform.position;
        }


    }
}
