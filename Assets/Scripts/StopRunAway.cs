using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StopRunAway : MonoBehaviour
{
    private SheepRandomPosAI pos;
    [SerializeField] NavMeshAgent agent;
    private void Start()
    {
         pos = transform.parent.parent.gameObject.GetComponent<SheepRandomPosAI>();
    }
    private void OnTriggerExit(Collider other)
    {
        if( other.gameObject.tag == "Wolf" ) 
        { 
        pos.enabled = true; 

        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Wolf" && !pos.enabled)
        {
            agent.gameObject.transform.Translate((agent.gameObject.transform.position - other.gameObject.transform.position).normalized * Time.deltaTime);
        }
    }
}
