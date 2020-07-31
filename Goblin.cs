using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject gameObject = otherCollider.gameObject;

        if (otherCollider.GetComponent<Spike>())
        {
            GetComponent<Animator>().SetTrigger("JumpTrigger");
        }

        else if (otherCollider.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(gameObject);
        }
    }
}
