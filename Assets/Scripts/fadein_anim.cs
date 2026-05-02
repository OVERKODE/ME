using UnityEngine;

public class fadein_anim : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim.Play("fadein_anim");
    }
}
