using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldofView : MonoBehaviour
{

    public float viewRadius;
    [Range(0,360)]
    public float viewAngle;

    public LayerMask targetMask;
    public LayerMask obstacleMask;

    [HideInInspector]
    public List<Transform> visibleTargets = new List<Transform>();

    IEnumerator FindTargetWithDelay (float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            FindVisibleTargets();
        }
    }

    private void FindVisibleTargets()
    {
        throw new NotImplementedException();
    }

    public void FindVisibleTargets(float dstToTarget)
    {
        visibleTargets.Clear();
        Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, viewRadius, targetMask);

        for (int i = 0; i < targetsInViewRadius.Length; i++)
        {
            Transform target = targetsInViewRadius[i].transform;
            Vector3 dirToTarget = (target.position - transform.position).normalized;
            if (Vector3.Angle(transform.forward, dirToTarget) < viewAngle / 2)
            {
                float disToTarget = Vector3.Distance(transform.position, target.position);
                if (!Physics.Raycast (transform.position, dirToTarget, dstToTarget, obstacleMask))
                {
                    visibleTargets.Add(target);
                }
            }
        }
    }

    public Vector3 DirFromAngle(float angleinDegrees, bool angleIsGlobal) 
    {
        if (!angleIsGlobal)
        {
            angleinDegrees += transform.eulerAngles.y;
        }
        return new Vector3(Mathf.Sin(angleinDegrees * Mathf.Deg2Rad), 0, Mathf.Cos(angleinDegrees * Mathf.Deg2Rad));
    }


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("FindTargetWithDelay", 0.2f);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
