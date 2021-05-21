using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Where to teleport the collider to")]
    private Transform targetTransofrm;

    [SerializeField]
    [Tooltip("Only teleport things in this list, if empty teleport everything (including chickens)")]
    private List<Collider2D> teleportMeCollider;
    
    private void OnTriggerEnter2D(Collider2D collider) {          
        if(teleportMeCollider.Any() ? teleportMeCollider.Any(x=>x == collider) : true)
            collider.gameObject.transform.position = targetTransofrm.position;
    }
        
}
