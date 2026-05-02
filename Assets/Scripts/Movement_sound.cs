using Unity.VisualScripting;
using UnityEngine;

public class Movement_sound : MonoBehaviour
{
    public AudioSource audi;
    public AudioClip wood_sound;
    public AudioClip grass_sound;
    private bool flag;
    public NightAudio scr;

    void Start()
    {   
        GameObject obj = GameObject.FindGameObjectWithTag("NA");
        scr = obj.GetComponent<NightAudio>();
    }

    void Update()
    {
        flag = scr.isAtHome;

        bool isMoving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || 
                        Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);
        
        if (isMoving && !audi.isPlaying)
        {
            if (flag)
            {
                audi.pitch = 0.5f;
                audi.clip = wood_sound;
                audi.PlayOneShot(wood_sound);
                Debug.Log("wood");
            }
            else if (flag == false)
            {
                Debug.Log("grass");
                audi.pitch = 0.5f;
                audi.clip = grass_sound;
                audi.PlayOneShot(grass_sound);
            }
        }

        if (isMoving && !audi.isPlaying && Input.GetKey(KeyCode.LeftShift))
        {
            if (flag)
            {
                audi.pitch = 1f;
                audi.clip = wood_sound;
                audi.PlayOneShot(wood_sound);
            }
            else
            {
                audi.pitch = 1f;
                audi.clip = grass_sound;
                audi.PlayOneShot(grass_sound);
            }
        }
    }
}
