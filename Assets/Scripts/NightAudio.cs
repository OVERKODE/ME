using UnityEngine;
using UnityEngine.Rendering;

public class NightAudio : MonoBehaviour
{
    public AudioSource zvuk;
    public Collider coll;
    public bool isAtHome = true;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player") && isAtHome)
        {
            isAtHome = false;
            Debug.Log("Player left");
        } else
        {
            isAtHome = true;
            Debug.Log("Player came back");
        }
    }

    void Update()
    {
        if (isAtHome)
        {
            zvuk.volume = Mathf.Clamp01(0.02f);
        } else
        {
            zvuk.volume = Mathf.Clamp01(0.05f);
        }
    }
}
