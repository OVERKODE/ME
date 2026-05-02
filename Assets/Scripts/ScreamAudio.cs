using UnityEngine;

public class ScreamAudio : MonoBehaviour
{
    public Collider coll;
    public AudioSource audioo;
    public AudioSource audi;

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            audi.Play();
            audioo.Play();
        }
    }
}
