using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    /*
    --- Menu Manager by Adrian Haga ---
    
        This menu manager is a simple tool to quickly access scenes for testing.


    */


    [Space(10)]
    [SerializeField][Tooltip("Key to show/hide menu")]
    private KeyCode menuKey = KeyCode.Escape;
    
    [Space(10)]
    
    [SerializeField][Tooltip("Add custom button here, leave empty for default")]
    private GameObject button;
    

    private GameObject panel;
    private GameObject canvas;
    private bool activeBool;

    [Space(10)]

    [SerializeField][Scene][Tooltip("Remember to add scenes to the build")]
    private string[] scenes;

    private void Awake()
    {
        //Destroys copies of the MenuManager in the scene
        var obj = FindObjectsOfType<MenuManager>();
        if (obj.Length > 1)
            Destroy(gameObject);
        
        DontDestroyOnLoad(gameObject);

        //Finds the panels and load the button prefab from Resources folder
        panel = GameObject.Find("prot_Panel").gameObject;
        canvas = GameObject.Find("prot_Canvas").gameObject;
        
        //If you don't add a custom button it allocate default button
        if(button == null)
        button = Resources.Load<GameObject>("Prefab/Button");
    }
    
    void Start()
    {
        //Find the back button and set the onClick event to return it to the scene you start at
        GameObject.Find("MainMenu").GetComponent<Button>().onClick.AddListener(() => MainMenu(0));
        
        //Add a button for each of the scenes in the scenes array
        for (int i = 0; i < scenes.Length; i++)
        {
            int copy = i;
            GameObject but = null;
            but = (GameObject)Instantiate(button, panel.transform);
            but.GetComponent<Button>().onClick.AddListener(() => SelectScene(copy));
            but.GetComponentInChildren<Text>().text = scenes[i];   
        }
    }

    //Select scene from array
    public void SelectScene(int _int)
    {
        SceneManager.LoadScene(scenes[_int]);
        canvas.SetActive(false);
    }

    //Return to scene with index 0
    public void MainMenu(int _sceneIndex)
    {
        SceneManager.LoadScene(_sceneIndex);
    }
    
    private void Update()
    {        
        if(Input.GetKeyDown(menuKey))
        {
            activeBool = !activeBool;

            canvas.SetActive(activeBool);

        }

    }
}
