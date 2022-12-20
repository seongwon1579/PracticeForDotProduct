using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectation : MonoBehaviour, IDetectation
{
    [SerializeField]
    Transform targetTransform;

    [SerializeField, Range(1,89)]
    float angle;
    [SerializeField]
    float range;
    [SerializeField]
    LayerMask targetMask;

    Vector3 targetPos;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
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

    public void Start()
    {
        StartCoroutine(DoWorkCo());
    }

    IEnumerator DoWorkCo()
    {
        yield return null;
        if (IsInAngle() && IsInRange())
        {
            Debug.Log("in sight of an opponet");
        }
    }

    public bool IsInAngle()
    {
        targetPos = (targetTransform.position - transform.position).normalized;
        
        // an opponet is in angel
        bool InAngle = Vector3.Dot(transform.forward, targetPos) > Mathf.Cos(angle * 0.5f * Mathf.Deg2Rad);

        return InAngle;
    }

    public bool IsInRange()
    {
        // an opponet is in range
        Collider[] coll = Physics.OverlapSphere(transform.position, range, targetMask);
        
        foreach(var target in coll)
        {            
            return true;
        }
        return false;
    }

    public bool IsHearable()
    {
        return true;
    }
}