using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody myRBD;
    [SerializeField] private float angulo;
    [SerializeField] private Quaternion q = Quaternion.identity;
    private float anguloSen;
    private float anguloCos;
    
    private void FixedUpdate()
    {
        anguloSen = Mathf.Sin(Mathf.Deg2Rad * angulo * 0.5f);
        anguloCos = Mathf.Cos(Mathf.Deg2Rad * angulo * 0.5f);

        q.Set(anguloSen, 0, 0, anguloCos);

        //transform.rotation = q;
        myRBD.rotation = q * myRBD.rotation;

    }
}
