using UnityEngine;
using UnityEngine.UI;
using NUnit.Framework;
using System.IO;
using System.Collections;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

[TestFixture]
public class ScoreboardTests
{
    [Test]
    public void AddPointIncrementsScoreByOne()
    {
        // Arrange
        GameObject scoreboardObject = new GameObject();
        Scoreboard scoreboard = scoreboardObject.AddComponent<Scoreboard>();
        Text scoreText = scoreboardObject.AddComponent<Text>();
        scoreboard.Score = scoreText;

        int initialScore = 0;

        // Act
        scoreboard.AddPoint();

        // Assert
        Assert.AreEqual("Score: " + (initialScore + 1).ToString(), scoreText.text);
    }
}



[TestFixture]
public class DragAndDropTests
{
    [Test]
    public void Drag_Position_Test()
    {
        // Arrange
        GameObject dragObject = new GameObject(); 
        DragAndDrop dragAndDrop = dragObject.AddComponent<DragAndDrop>(); 
        Vector3 initialPosition = new Vector3(0, 0, 0); 
        dragObject.transform.position = initialPosition; 

        // Act
        dragAndDrop.Drag(); 

        // Assert
        Assert.AreNotEqual(initialPosition, dragObject.transform.position); 
    }

    /*[UnityTest]
    public void Snap_Test()
    {

    } */
}

[TestFixture]
public class SceneChangeTest
{
    [UnityTest]
    public IEnumerator A_MainToTutorial()
    {
        SceneManager.LoadScene("Main Menu");

        yield return null;

        GameObject button = GameObject.Find("matchingWords");
        Assert.IsNotNull(button, "matchingWords button not found in Main Menu scene.");

        UnityEngine.UI.Button buttonComponent = button.GetComponent<UnityEngine.UI.Button>();
        Assert.IsNotNull(buttonComponent, "matchingWords button in this scene does not work.");

        bool sceneLoaded = false;

        buttonComponent.onClick.AddListener(() => sceneLoaded = true);

        buttonComponent.onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.IsTrue(sceneLoaded, "MatchingWordsTutorial scene was not loaded after clicking matchingWords button.");
    }

    [UnityTest]
    public IEnumerator B_TutorialToGame()
    {
        SceneManager.LoadScene("MatchingWordsTutorial");

        yield return null;

        GameObject button = GameObject.Find("Button");
        Assert.IsNotNull(button, "button in this scene not found in Main Menu scene.");

        UnityEngine.UI.Button buttonComponent = button.GetComponent<UnityEngine.UI.Button>();
        Assert.IsNotNull(buttonComponent, "button in this scene does not work.");

        bool sceneLoaded = false;

        buttonComponent.onClick.AddListener(() => sceneLoaded = true);

        buttonComponent.onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.IsTrue(sceneLoaded, "Next scene was not loaded after clicking the button.");
    }

    [UnityTest]
    public IEnumerator C_ContinentsToStates()
    {
        SceneManager.LoadScene("MatchingWordsContinents");

        yield return null;

        GameObject button = GameObject.Find("Continents");
        Assert.IsNotNull(button, "button in this scene not found in Main Menu scene.");

        UnityEngine.UI.Button buttonComponent = button.GetComponent<UnityEngine.UI.Button>();
        Assert.IsNotNull(buttonComponent, "button in this scene does not work.");

        bool sceneLoaded = false;

        buttonComponent.onClick.AddListener(() => sceneLoaded = true);

        buttonComponent.onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.IsTrue(sceneLoaded, "Next scene was not loaded after clicking the button.");
    }

    [UnityTest]
    public IEnumerator D_StatesToContinents()
    {
        SceneManager.LoadScene("MatchingWordsStates");

        yield return null;

        GameObject button = GameObject.Find("Button");
        Assert.IsNotNull(button, "button in this scene not found in Main Menu scene.");

        UnityEngine.UI.Button buttonComponent = button.GetComponent<UnityEngine.UI.Button>();
        Assert.IsNotNull(buttonComponent, "button in this scene does not work.");

        bool sceneLoaded = false;

        buttonComponent.onClick.AddListener(() => sceneLoaded = true);

        buttonComponent.onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.IsTrue(sceneLoaded, "Next scene was not loaded after clicking the button.");
    }

    [UnityTest]
    public IEnumerator E_StatesToTutorial()
    {
        SceneManager.LoadScene("MatchingWordsStates");

        yield return null;

        GameObject button = GameObject.Find("Tutorial");
        Assert.IsNotNull(button, "button in this scene not found in Main Menu scene.");

        UnityEngine.UI.Button buttonComponent = button.GetComponent<UnityEngine.UI.Button>();
        Assert.IsNotNull(buttonComponent, "button in this scene does not work.");

        bool sceneLoaded = false;

        buttonComponent.onClick.AddListener(() => sceneLoaded = true);

        buttonComponent.onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.IsTrue(sceneLoaded, "Next scene was not loaded after clicking the button.");
    }

    [UnityTest]
    public IEnumerator F_CapitalsToTutorial()
    {
        SceneManager.LoadScene("MatchingWordsContinents");

        yield return null;

        GameObject button = GameObject.Find("Tutorial");
        Assert.IsNotNull(button, "button in this scene not found in Main Menu scene.");

        UnityEngine.UI.Button buttonComponent = button.GetComponent<UnityEngine.UI.Button>();
        Assert.IsNotNull(buttonComponent, "button in this scene does not work.");

        bool sceneLoaded = false;

        buttonComponent.onClick.AddListener(() => sceneLoaded = true);

        buttonComponent.onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.IsTrue(sceneLoaded, "Next scene was not loaded after clicking the button.");
    }

    [UnityTest]
    public IEnumerator G_CapitalsToMenu()
    {
        SceneManager.LoadScene("MatchingWordsContinents");

        yield return null;

        GameObject button = GameObject.Find("Main Menu");
        Assert.IsNotNull(button, "button in this scene not found in Main Menu scene.");

        UnityEngine.UI.Button buttonComponent = button.GetComponent<UnityEngine.UI.Button>();
        Assert.IsNotNull(buttonComponent, "button in this scene does not work.");

        bool sceneLoaded = false;

        buttonComponent.onClick.AddListener(() => sceneLoaded = true);

        buttonComponent.onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.IsTrue(sceneLoaded, "Next scene was not loaded after clicking the button.");
    }

    [UnityTest]
    public IEnumerator H_StatesToMenu()
    {
        SceneManager.LoadScene("MatchingWordsStates");

        yield return null;

        GameObject button = GameObject.Find("Main Menu");
        Assert.IsNotNull(button, "button in this scene not found in Main Menu scene.");

        UnityEngine.UI.Button buttonComponent = button.GetComponent<UnityEngine.UI.Button>();
        Assert.IsNotNull(buttonComponent, "button in this scene does not work.");

        bool sceneLoaded = false;

        buttonComponent.onClick.AddListener(() => sceneLoaded = true);

        buttonComponent.onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.IsTrue(sceneLoaded, "Next scene was not loaded after clicking the button.");
    }

    [UnityTest]
    public IEnumerator I_MainToScores()
    {
        SceneManager.LoadScene("Main Menu");

        yield return null;

        GameObject button = GameObject.Find("highScores");
        Assert.IsNotNull(button, "matchingWords button not found in Main Menu scene.");

        UnityEngine.UI.Button buttonComponent = button.GetComponent<UnityEngine.UI.Button>();
        Assert.IsNotNull(buttonComponent, "matchingWords button in this scene does not work.");

        bool sceneLoaded = false;

        buttonComponent.onClick.AddListener(() => sceneLoaded = true);

        buttonComponent.onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.IsTrue(sceneLoaded, "MatchingWordsTutorial scene was not loaded after clicking matchingWords button.");
    }

    [UnityTest]
    public IEnumerator J_ScoresToMain()
    {
        SceneManager.LoadScene("highScores");

        yield return null;

        GameObject button = GameObject.Find("Main Menu");
        Assert.IsNotNull(button, "matchingWords button not found in Main Menu scene.");

        UnityEngine.UI.Button buttonComponent = button.GetComponent<UnityEngine.UI.Button>();
        Assert.IsNotNull(buttonComponent, "matchingWords button in this scene does not work.");

        bool sceneLoaded = false;

        buttonComponent.onClick.AddListener(() => sceneLoaded = true);

        buttonComponent.onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.IsTrue(sceneLoaded, "MatchingWordsTutorial scene was not loaded after clicking matchingWords button.");
    }
}