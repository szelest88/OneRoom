using UnityEngine;
using System.Collections;

public class KeepPosition : MonoBehaviour
{

    private Vector3 offset;

    void Start()
    {
        offset = transform.localPosition;
    }

    void Update()
    {
        var posInParentSpace = transform.parent.position + offset;
        transform.position = posInParentSpace;
    }

}
