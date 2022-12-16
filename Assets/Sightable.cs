using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sightable : MonoBehaviour, ISightable
{
    public bool IsViewable()
    {


        return true;
    }

    private void OnDrawGizmos()
    {
        
    }
}
