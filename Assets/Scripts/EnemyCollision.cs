using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D objectCollideWith)
     {
        Debug.Log("Collision Enter");
        Transform transform = objectCollideWith.GetComponent<Transform>();
        transform.localScale += gameObject.GetComponentInParent<Enemy>().ScaleSizeVector;
        Destroy(gameObject.transform.parent.gameObject);
     }
}