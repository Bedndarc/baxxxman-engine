using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Bax : MonoBehaviour
{
  public int points = 10;

    protected virtual void Eat()
    {
        FindObjectOfType<GameManager>().BaxCollected(this);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Baxxxman")) {
            Eat();
        }
    }
}
