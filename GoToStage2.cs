using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class GoToStage2 : MonoBehaviour

{
    public void ChangeGameScene()

    {
        SceneManager.LoadScene("Stage2");
    }
}

