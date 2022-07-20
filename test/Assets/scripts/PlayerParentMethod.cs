using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParentMethod : MonoBehaviour
{
    public Vector3 a;
    public int gatillo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (gatillo >= 10)
        {
            
        }
        //transform.DetachChildren(); //todos los hijos libres!, sin sobrecarga
        //a = transform.Find("GameObject (5)"); //buscar hijos por nombre devuelve tal vez Transform
        //a = transform.GetChild(4);  //buscar hijos por index y devuelve transform
        //a = transform.GetSiblingIndex();  //index de este objeto, creo
        //a = transform.InverseTransformDirection(transform.position);  //ha?
        //a = transform.IsChildOf(transform.GetChild(0)) ; //?????
        //transform.Rotate();  //rotar, con varias sobrecargas
        //transform.RotateAround(new Vector3(7,2,2), Vector3.up, 1); //rotar alrededor de algo, sobrecarga obsoleto
        //transform.SetAsFirstSibling();
        //transform.SetAsLastSibling();
        //transform.SetParent();
        //transform.SetPositionAndRotation(transform.position + Vector3.up * 3, transform.rotation); //solo pide posición y rotation en quaternion
        //transform.SetSiblingIndex(1);
        //transform.Translate(new Vector3(1,0) * Time.deltaTime, transform.GetChild(5));
        //transform.LookAt(transform.GetChild(5),Vector3.up);
        transform.position = a;
    }
}
