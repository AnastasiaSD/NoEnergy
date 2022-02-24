using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit2D
{
    public class testDelObjWhenDie : MonoBehaviour
    {
        //public GameObject curObj;
        public Damageable objCur;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (objCur.CurrentHealth == 0)
            {
                Destroy(gameObject);
            }
        }

    }
}