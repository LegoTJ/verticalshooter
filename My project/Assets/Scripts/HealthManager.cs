using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthManager : MonoBehaviour {

	public int health;
	//public Slider healthBar;
	public bool isDead;
	public int life;
	public bool complete;
	//public float enemiesReactivationDelay;
	public GameObject Spawn;
	private Rigidbody2D rb;
	public GameObject enemies;
	public GameObject enemies2;
	public GameObject enemies3;
	public GameObject enemies4;
	public respawn Respawning;
    public Animator animator;
	public string animationStateName = "animation";
	public int animationStateID;
    public float time;
	public GameObject Powerup;
	public TextMeshProUGUI lifes;

	// Use this for initialization
	void Start () {
//		text = GetComponent<Text>();
		//healthBar = GetComponent<Slider> ();
		isDead = false;
		rb = GetComponent<Rigidbody2D>();
		animationStateID = Animator.StringToHash(animationStateName);
        if (!animator.GetCurrentAnimatorStateInfo(0).IsName(animationStateName))
        {
			
        }
		//Animator animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		lifes.text = life.ToString();
		if (health == 2)
        {
			Powerup.SetActive(true);
        }
		//float time = animator.clip.length;
		if(animator != null && !complete)
        {
			AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
			if (stateInfo.IsName(animationStateName))
            {
				float currentTime = stateInfo.normalizedTime * stateInfo.length;
				if(currentTime >= 230f)
                {
					animator.speed = 0f;
					complete = true;
                }
            }
        }
		if (complete && animator != null && animator.speed == 0f)
        {
			if(!complete)
            {
				animator.speed = 1f;
				animator.Play(animationStateID, 0, 0f);
            }
        }
		if (health <= 0 && !isDead)
		{
			if (life == 0)
			{
				health = 1;
				isDead = true;
				ScoreManager.GameOver = true;
				gameObject.SetActive(false);
				life = 3;
			}
			else
			{
				if (animator != null)
				{
					AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
					if (stateInfo.IsName(animationStateName))
					{
						//GetComponent<Animation>().time = 0.0f;
						//gameObject.transform.position = new Vector2(Spawn.transform.position.x, Spawn.transform.position.y);
						//health = 1;
						life = life - 1;
						//isDead = false;
						//enemies.SetActive(true);
						float currentTime = stateInfo.normalizedTime * stateInfo.length;
						RespawnPlayer(currentTime);
						//animator.Play("AnimationStateName", 0, 0.5f);
						//ScoreManager.GameOver = false;
						//gameObject.SetActive(true);
					}
					else { RespawnPlayer(0f); }
				}
				else
				{
					RespawnPlayer(0f);
				}
			}
		}




		//		text.text = "" + health;
		//healthBar.value = health;
	}



	private void RespawnPlayer(float currentAnimationTime)
    {
		float rewindTime = 0f;
		gameObject.transform.position = new Vector2(Spawn.transform.position.x, Spawn.transform.position.y);
		health = 1;
		//life = life - 1;
		//enemies.SetActive(true);
		ScoreManager.GameOver = false;
		gameObject.SetActive(true);

		//StartCoroutine(ReactiveEnemiesDelayed());
		if (currentAnimationTime >= 0f && currentAnimationTime < 60f)
		{
			rewindTime = 0f;
			enemies.SetActive(true);
		}
		else if (currentAnimationTime >= 60f && currentAnimationTime < 120f)
		{
			rewindTime = 60f;
			enemies2.SetActive(true);
		}
		else if (currentAnimationTime >= 120f && currentAnimationTime < 180f)
		{
			rewindTime = 120f;
			enemies3.SetActive(true);

		}
		else if (currentAnimationTime >= 180f && currentAnimationTime < 220f)
		{
			rewindTime = 180f;
			enemies4.SetActive(true);

		}
		else
		{
			rewindTime = 0f;
			enemies.SetActive(true);
		}
		if (animator != null)
        {
			AnimatorStateInfo stateInfo = animator.
			GetCurrentAnimatorStateInfo(0);
			float normalizedRewindTime = rewindTime / stateInfo.length;
			animator.Play(animationStateID, 0, normalizedRewindTime);
        }
	}

	/*private IEnumerator ReactiveEnemiesDelayed()
    {
		yield return new WaitForSeconds(enemiesReactivationDelay);
		if(enemies != null)
        {
			enemies.SetActive(true);
			//Debug.LogError("Enemies Reactivated.");
		}
        else
        {
			Debug.LogError("Enemies GameObject not assigned! Cannot reactivate enemies.");
		}
    }*/
	public void HurtPlayer (int damageToGive)
	{
		health -= damageToGive;
	}
	public void GiveLife (int lifeToGive)
    {
		life += lifeToGive;
    }
}
