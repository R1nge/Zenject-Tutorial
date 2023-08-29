using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class Boot : MonoBehaviour
{
    private ZenjectSceneLoader _zenjectSceneLoader;

    [Inject]
    private void Inject(ZenjectSceneLoader zenjectSceneLoader) => _zenjectSceneLoader = zenjectSceneLoader;

    private void Awake() => _zenjectSceneLoader.LoadSceneAsync("SampleScene", LoadSceneMode.Additive);
}