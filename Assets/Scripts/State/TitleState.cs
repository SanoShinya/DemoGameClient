using UnityEngine;
using Arbor;
using Zenject;
using Cysharp.Threading.Tasks;

[AddComponentMenu("State/TitleState")]
public class TitleState : StateBehaviour {

	[Inject]
	private MainCanvas _mainCanvas;

	private AssetLoader<TitleView> _titleViewLoader = new AssetLoader<TitleView>();

	// Use this for initialization
	void Start () {
	
	}

	// Use this for awake state
	public override async void OnStateAwake() 
	{
		await UniTask.WhenAll(_titleViewLoader.Load("Prefabs/View/TitleView"));
		var view = _titleViewLoader.Asset;
		_mainCanvas.AddChild(view);
	}

	// Use this for enter state
	public override void OnStateBegin()
	{

	}

	// Use this for exit state
	public override void OnStateEnd()
	{
	}
	
	// OnStateUpdate is called once per frame
	public override void OnStateUpdate()
	{
	}

	// OnStateLateUpdate is called once per frame, after Update has finished.
	public override void OnStateLateUpdate()
	{
	}
}
