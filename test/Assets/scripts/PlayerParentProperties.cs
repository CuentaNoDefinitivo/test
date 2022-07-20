using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParentProperties : MonoBehaviour
{
    [HideInInspector] public int childCount = 0; //NUMERO DE HIJOS QUE TIENE
    [HideInInspector] public Vector3 eulerAngles; //VALOR ROTATION
    public Vector3 forward;
    [HideInInspector] public bool hasChanged;
    [HideInInspector] public int hierarchyCapacity;
    [HideInInspector] public int hierarchyCount;
    Vector3 localScale;
    Vector3 lossyScale;
    [SerializeField, HideInInspector]public Quaternion rotation;
    [HideInInspector] public Vector3 right;
    public Matrix4x4 worldToLocalMatrix;
    public Matrix4x4 localToWorldMatrix;
    [HideInInspector]public Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        childCount = transform.childCount;      //NUMERO DE HIJOS QUE TIENE
        eulerAngles = transform.eulerAngles;    //VALOR ROTATION
        forward = transform.forward;
        hasChanged = transform.hasChanged;
        hierarchyCapacity = transform.hierarchyCapacity;
        hierarchyCount = transform.hierarchyCount;//numero de gameobject de esa estructura, todos los padres y todos los hijos
        /*localEulerAngles	
        localPosition 
        localRotation
        localScale*/
        localScale = transform.localScale; //escala ignorando al padre
        lossyScale = transform.lossyScale; //escala que se ve
        rotation = transform.rotation; //rotacion
        right = transform.right;
        worldToLocalMatrix = transform.worldToLocalMatrix;
        localToWorldMatrix = transform.localToWorldMatrix;
        parent = transform.parent;
        //up
        //forward, right, up, hasChanged, hierarchyCapacity, rotation, worldToLocalMatrix, localToWorldMatrix
        //transform.position += transform.forward * Time.deltaTime;
        //transform.position += Vector3.forward * Time.deltaTime;
    }
}
