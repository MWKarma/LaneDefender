using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DefendingWall : MonoBehaviour
{
    [SerializeField] private bool _enemyGotThrough;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyBehavior>() != null)
        {
            print("enemies distroyed");
            if (_enemyGotThrough == true)
            {
                GameManager GM = FindObjectOfType<GameManager>();
            }
        }
    }
}
