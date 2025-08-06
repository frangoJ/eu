using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string NomeDaCena;


    public void Load()
    {
        SceneManager.LoadScene(NomeDaCena);
    }
    
    
    
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
