using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerGitHub : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Empty"))
        {
            Destroy((collision.transform.parent.gameObject).transform.parent.gameObject);
        }

        if (collision.CompareTag("CenterPoint"))
        {
            Destroy(collision.gameObject);
        }

    }
}
