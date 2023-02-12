using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monosingeltonGeneric<T> : MonoBehaviour where T:monosingeltonGeneric<T>
{
    private static T instance;
    public static T Instance { get { return instance; } }

    protected virtual void Awake()
    {
        if(Instance == null)
        {
            instance = (T)this;
        }
        else
        {
            Destroy(this);
        }
    }

    public class playerTank : monosingeltonGeneric<playerTank>
    {
        protected override void Awake()
        {
            base.Awake();
        }
        public void Startattack()
        {
           
        }
    }

    public class enemyTank:MonoBehaviour
    {
        private void Start()
        {
            playerTank.Instance.Startattack();
        }
    }
}
