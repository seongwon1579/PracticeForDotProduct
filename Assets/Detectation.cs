using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectation : MonoBehaviour, IHearable, ISightable
{
    IHearable hearable;
    ISightable sightable;

    [SerializeField]
    Transform targetTransform;

    [SerializeField, Range(1,89)]
    float angle;
    [SerializeField]
    float range;
    [SerializeField]
    LayerMask targetMask;



    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, range);
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, transform.forward * 10f);
        Vector3 RightDir = Dir(transform.eulerAngles.y + angle * 0.5f);
        Vector3 LeftDir = Dir(transform.eulerAngles.y - angle * 0.5f);
        Gizmos.DrawRay(transform.position, RightDir * 10f);
        Gizmos.DrawRay(transform.position, LeftDir * 10f);

    }

    private Vector3 Dir(float angle)
    {
        float radian = angle * Mathf.Deg2Rad;
        
        return new Vector3(Mathf.Sin(radian),0,Mathf.Cos(radian));
    }



    public bool IsInAngle()
    {
        // to be aware that an opponet is in angel
        bool InAngle = Vector3.Dot(transform.forward, targetTransform.position.normalized) > Mathf.Cos(angle * 0.5f * Mathf.Deg2Rad);

        return InAngle;
    }

    public bool IsInRange()
    {
        // to be aware that an opponet is in range
        Collider[] coll = Physics.OverlapSphere(transform.position, range, targetMask);

        return true;
    }

    public bool IsHearable()
    {
        return true;
    }
}
