using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class tonv : MonoBehaviour
{
    public Volume vol;
    private ChromaticAberration chrome;
    void Start()
    {
        vol.profile.TryGet<ChromaticAberration>(out chrome);
        chrome.active = true;
    }
}
