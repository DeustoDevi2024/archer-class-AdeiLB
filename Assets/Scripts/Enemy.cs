using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Archer
{

    public class Enemy : MonoBehaviour, IScoreProvider
    {

        // Cu�ntas vidas tiene el enemigo
        [SerializeField]
        private int hitPoints;

        private Animator animator;
        private GameObject sun = GameObject.Find("Directional Light");

        public event IScoreProvider.ScoreAddedHandler OnScoreAdded;

        private void Awake()
        {
            animator = GetComponent<Animator>();
        }

        // M�todo que se llamar� cuando el enemigo reciba un impacto
        public void Hit()
        {
            if (hitPoints <= 0)
            {
                Die();
            }
            else
            {
                hitPoints-=1;
            }
        }

        private void Die()
        {
            transform.rotation = Quaternion.Euler(90, 0, 0);
            //yield return new WaitForSeconds(3);
            transform.rotation = Quaternion.Euler(180, 0, 0);
            Destroy(this.gameObject);

        }

      
    }


}