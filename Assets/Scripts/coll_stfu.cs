using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Collider coll;
    public AudioSource audi;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            audi.Stop();
        }
    }
}
