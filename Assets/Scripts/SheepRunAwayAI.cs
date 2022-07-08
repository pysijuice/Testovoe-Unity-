using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SheepRunAwayAI : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wolf")
        {
            transform.parent.gameObject.GetComponent<SheepRandomPosAI>().enabled = false;
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if( other.gameObject.tag == "Wolf")
        {
            agent.gameObject.transform.Translate((agent.gameObject.transform.position - other.gameObject.transform.position).normalized * Time.deltaTime);
        }
    }
   
}
