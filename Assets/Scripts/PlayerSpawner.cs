using UnityEngine;
using Zenject;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private Player prefab;
    private DiContainer _diContainer;

    [Inject]
    private void Inject(DiContainer diContainer) => _diContainer = diContainer;

    private void Awake() => Spawn();

    private void Spawn() => _diContainer.InstantiatePrefabForComponent<Player>(prefab);
}