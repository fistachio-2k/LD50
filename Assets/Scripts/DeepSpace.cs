using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeepSpace : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Human"))
        {
            GamePlayManager.HumanFallToDeepSpace();
        }
    }
}