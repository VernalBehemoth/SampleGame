using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Tooltip("Required to track player movement")]
    [SerializeField]
    private Transform playerTransform;

    [Tooltip("Follow player instead of jumping to player position when the player is out of bounds")]
    [SerializeField]    
    private bool followPlayerWithCamera;    
    
    private bool outOfBounds;
    
    
    void Update()
    {
        if(!followPlayerWithCamera){
            var playerPos = this.GetComponent<Camera>().WorldToScreenPoint(playerTransform.position); 
            outOfBounds = !Screen.safeArea.Contains(playerPos);       
        }
    }

    private void FixedUpdate() {       
        MoveToPlayer();
    }

    void MoveToPlayer(){
        if(followPlayerWithCamera){
            this.gameObject.transform.position = new Vector3(playerTransform.position.x,playerTransform.position.y,this.transform.position.z);
        }
        else if(outOfBounds){
            this.gameObject.transform.position = new Vector3(playerTransform.position.x,playerTransform.position.y,this.transform.position.z);
        }        
    }
}
