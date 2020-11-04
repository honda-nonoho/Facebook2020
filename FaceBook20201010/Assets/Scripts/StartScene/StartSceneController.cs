using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common;
using UnityEngine.SceneManagement;

namespace StartScene
{


    public class StartSceneController : MonoBehaviour
    {
        void Awake()
    {
        var globalObject = Resources.Load<GlobalController>("Prefab/Global/GlobalController");
        var gameObject = Instantiate<GlobalController>(globalObject , Vector3.zero, Quaternion.identity);

        DontDestroyOnLoad(gameObject);

    }
    void Start()
    {
         SceneManager.LoadScene("HomeScene");
    }
    }
}
