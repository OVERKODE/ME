using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coll_end : MonoBehaviour
{
    public Collider coll;
    public Animator anim;
    public GameObject obj;
    public GameObject shadow;

    void OnTriggerEnter(Collider coll)
    {
        shadow.SetActive(false);
        obj.SetActive(true);
        anim.Play("fadeout_anim");
        StartCoroutine(load_next());
    }

    IEnumerator load_next()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(8);
    }
}
