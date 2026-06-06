using System.Collections;
using UnityEngine;

public class CoinItem : MonoBehaviour
{
    [HideInInspector] public string id;

    [Tooltip("Seconds before this coin reappears after being collected. Set to 0 to disable respawning.")]
    public float respawnDelay = 10f;

    void Start()
    {
        id = transform.position.ToString();
        CoinManager.Instance.Register(this);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CoinManager.Instance.Collect(id, respawnDelay);
        }
    }
}
