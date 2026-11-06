using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public Scene sceneToOpen;

    public void OpenScene()
    {
        OpenScene(sceneToOpen);
    }
    
}
