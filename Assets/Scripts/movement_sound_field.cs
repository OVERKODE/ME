using UnityEngine;

public class movement_sound_field : MonoBehaviour
{
    public AudioClip audi;
    public AudioSource src;

    void Update()
    {
        bool isMoving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || 
                        Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);

        if (isMoving && !src.isPlaying)
        {
            src.pitch = 0.5f;
            src.PlayOneShot(audi);
        }
    }
}
