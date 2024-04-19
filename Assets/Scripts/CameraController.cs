using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Archer
{

    public class CameraController : MonoBehaviour
    {
        private Vector3 newPos;
        // El objeto al que va a seguir la c�mara
        [SerializeField]
        private Transform target;

        // �ngulo de la c�mara
        [SerializeField]
        private float angle;

        // Distancia a la que se coloca la c�mara con respecto a la arquera
        [SerializeField]
        private float distance;

        // Desplazamiento con respecto al pivote de la arquera 
        // (para que la c�mara est� m�s orienta hacia la cabeza que a los pies)
        [SerializeField]
        private Vector3 offset;
        
        // Velocidad a la que se mueve la c�mara con Vector3.MoveTowards()
        //[SerializeField]
        //private float travelSpeed;

        // Tiempo que tarda la c�mara en moverse a la nueva ubicaci�n con Vector3.Lerp()
        [SerializeField]
        private float travelTime;

        private void Update()
        {

            newPos = target.position - target.forward * distance;
          
            
            this.transform.position = newPos + offset;
            transform.LookAt(target.position + offset);

            /*
            transform.LookAt(target.position + offset);
            transform.position = target.position - target.forward * distance + offset;
            */

        }

    }

}
