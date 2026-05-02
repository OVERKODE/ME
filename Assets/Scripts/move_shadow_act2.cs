using System.Numerics;
using UnityEngine;

public class move_shadow_act2 : MonoBehaviour
{
    public Transform shadow;
    public Collider coll;
    public AudioSource audi;
    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            audi.Play();
            shadow.position = new UnityEngine.Vector3(470, 174, 680);
            shadow.rotation = new UnityEngine.Quaternion(0, 180, 0, 0);
        }
    }
}
