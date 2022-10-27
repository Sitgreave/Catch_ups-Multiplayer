using UnityEngine;

namespace AbstractSingleton
{
	public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{

	private static T _instance = null;
	
	public static bool IsAwake { get { return (_instance != null); } }
	
	public static T Instance {
		get {
			if (_instance != null) return _instance;
			_instance = (T)FindObjectOfType (typeof(T));
			if (_instance != null) return _instance;
			
			string gameObjectName = typeof(T).ToString ();			
					
			GameObject go = GameObject.Find (gameObjectName);
			if (go == null) {
				go = new GameObject ();
				go.name = gameObjectName;
			}
					
			_instance = go.AddComponent<T> ();
			return _instance;
		}
	}
	

	public virtual void OnApplicationQuit ()
	{
		_instance = null;
	}
	
	protected void SetParent (string parentGOName)
	{
		if (parentGOName == null) return;
		GameObject parentGameObject = GameObject.Find (parentGOName);
		if (parentGameObject == null) {
			parentGameObject = new GameObject ();
			parentGameObject.name = parentGOName;
		}
		this.transform.parent = parentGameObject.transform;
	}
}
}