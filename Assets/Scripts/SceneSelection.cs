using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelection : MonoBehaviour
{
    
    
    public void SceneSelect(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
