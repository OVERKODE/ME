using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class end_script : MonoBehaviour
{
    public Text txt;
    public GameObject t1,t2,t3,t4;
    void Start()
    {
        StartCoroutine(tick_tack());
    }

    IEnumerator tick_tack()
    {
        yield return new WaitForSeconds(5f);
        txt.enabled = false;
        t1.SetActive(true);
        t2.SetActive(true);
        t3.SetActive(true);
        t4.SetActive(true);
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(0);
    }
}
