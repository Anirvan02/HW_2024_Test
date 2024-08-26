using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulpit : MonoBehaviour
{
    bool isFalling = false;
    float downSpeed = 0;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Doofus")
        {
            StartCoroutine(StartFallingAfterDelay(2));
            ScoreManager.scoreCount += 1;
        }
    }

    IEnumerator StartFallingAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        isFalling = true;
        Destroy(gameObject, 5);
    }
    
    void Update()
    {
        if (isFalling)
        {
            downSpeed += Time.deltaTime / 10;
            transform.position = new Vector3(transform.position.x,
                transform.position.y - downSpeed,
                transform.position.z);
        }
    }
}
