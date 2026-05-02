using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class spawn_corpse : MonoBehaviour
{
    public GameObject corpse;
    public Collider coll;
    public Volume vol;
    public Movement mov;
    public AudioSource audi;
    private ChromaticAberration chrome;
    private bool fl = false;
    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 5;
            vol.profile.TryGet<ChromaticAberration>(out chrome);
            chrome.active = true;
            mov.speed /= 5;
            mov.sprint /= 5;
            corpse.SetActive(true);
            audi.Play();
            fl = true;
        }
    }

    void Update()
    {
        if (fl == true && !audi.isPlaying)
        {
            SceneManager.LoadScene(4);
        }
    }
}
