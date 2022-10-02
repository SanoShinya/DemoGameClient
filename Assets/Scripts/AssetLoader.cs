using Cysharp.Threading.Tasks;
using UnityEngine;

public class AssetLoader<T>
{
    private T _asset;
    public T Asset => _asset;

    public async UniTask<T> Load(string path)
    {
        var resource = await Resources.LoadAsync(path);
        var instance = GameObject.Instantiate(resource) as GameObject;
        _asset = instance.GetComponent<T>();

        return _asset;
    }
}