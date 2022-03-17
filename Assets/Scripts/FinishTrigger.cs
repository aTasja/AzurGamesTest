using System.Collections;
using System.Collections.Generic;
using Managers;
using UnityEngine;
using UnityEngine.Analytics;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) => GameManager.Finish();
    
}
