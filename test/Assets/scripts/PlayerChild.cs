using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChild : MonoBehaviour
{
    public Vector3 localScale = Vector3.zero;
    public Vector3 lossyScale = Vector3.zero;
    // Start is called before the first frame update
    public Transform parent;
    public Vector3 position;
    public Transform root;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        localScale = transform.localScale;
        lossyScale = transform.lossyScale;
        parent = transform.parent;
        position = transform.position;
        root = transform.root;
    }
}
