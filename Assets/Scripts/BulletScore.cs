using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScore : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bullet")
        {
            ScoreSystem.instance.AddPoint();
        }
    }
}
