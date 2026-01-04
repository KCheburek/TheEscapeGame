using UnityEngine;

public class endOfBuildTrigger : MonoBehaviour
{
    public GameObject notification;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            notification.SetActive(true);
        }
    }
}
