using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CharacterType
{
	Penguin,
	Knight
}

[System.Serializable]
public class Character
{
	public CharacterType CharacterType;
	public Sprite CharacterSprite;
	public RuntimeAnimatorController AnimationController;
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

	public List<Character> CharacterList = new List<Character>();

	public Animator PlayerAnimator;
	public Text PlayerName;

	private void Awake()
	{
		if(Instance == null)
			Instance = this;
		else
			Destroy(gameObject);
	}
}
