using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour {

	public Text AlphaText;

	private void Start()
	{
		AlphaText.text = Global.Instance.Number.ToString();
	}

	public void GoToUpgrades()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("Upgrades");
		Global.Instance.Number++;
	}

	public void GoToMain()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
		Global.Instance.Number++;
	}

	// Things in here are updated every frame
	void Update () {
		
	}
}
