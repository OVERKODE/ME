using UnityEngine;

public class coll_shadow_spawn : MonoBehaviour
{
    public Collider coll;
    public AudioSource audi;
    public AudioSource steps;
    public GameObject shadow;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            shadow.SetActive(true);
            steps.Play();
        }
    }
}
