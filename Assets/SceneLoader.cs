using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour {

    public void loadScene(int index)
    {
        SceneManager.LoadSceneAsync(index);
    }

    /*public RawImage loading;
    private MovieTexture load;
    private int scene;
    private bool triggeredLoading = false;
    private bool startedLoading = false;

    public void Start()
    {
        load = (MovieTexture)loading.texture;
    }

    public void Update()
    {
        if (!load.isPlaying)
        {
            if (triggeredLoading)
            {
                if (!startedLoading)
                {
                    startedLoading = true;
                    SceneManager.LoadSceneAsync(scene);
                }
            }
        }
    }

    public void loadScene(int index)
    {
        scene = index;
        loading.enabled = true;
        load.Play();
        triggeredLoading = true;
    }*/
}
