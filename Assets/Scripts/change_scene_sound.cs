using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class change_scene_sound : MonoBehaviour
{
    private int count = 0;
    public Text phrase;
    public AudioSource audi;
    public AudioClip audi1;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            audi.Stop();
            audi.PlayOneShot(audi1);
            count++;
        }

        string curScene = SceneManager.GetActiveScene().name;

        if (curScene == "load_act1")
        {
            Cursor.lockState = CursorLockMode.Locked;
            if (count == 1)
            {
                phrase.text = "I feel lost and anxious.";
            } else if (count == 2)
            {
                phrase.text = "Me dreams have mixed with reality.";
            } else if (count == 3)
            {
                phrase.text = "My life has turned into half-real nightmare.";
            } else if (count == 4)
            {
                phrase.text = "I thought it would never end,";
            } else if (count == 5)
            {
                phrase.text = "but for some reason...";
            } else if (count == 6)
            {
                phrase.text = "something has changed.";
            } else if (count == 7)
            {
                SceneManager.LoadScene(1);
            }
        }
        if (curScene == "load_act2")
        {
            if (count == 1)
            {
                phrase.text = "Was you too scary?";
            } else if (count == 2)
            {
                phrase.text = "Or too slow?";
            } else if (count == 3)
            {
                SceneManager.LoadScene(3);
            }
        }

        if (curScene == "load_act3")
        {
            if (count == 1)
            {
                phrase.text = "He deserved this.";
            } else if (count == 2) {
                phrase.text = "Or he didn't?";
            } else if (count == 3)
            {
                SceneManager.LoadScene(5);
            }
        }

        if (curScene == "load_final_act")
        {
            if (count == 1)
            {
                phrase.text = "???:\nI can help you.";
            }
            else if (count == 2)
            {
                SceneManager.LoadScene(7);
            }
        }
    }
}
