using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
