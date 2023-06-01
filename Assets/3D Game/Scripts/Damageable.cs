using JetBrains.Annotations;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

class Damageable : MonoBehaviour
{
    [SerializeField] int maxHP = 10;
    [SerializeField] TMP_Text healthText;
    [SerializeField] float invicibilityFrames = 1;
    [SerializeField] float flickTime = 0.1f;

    //[SerializeField] Color minHPColor = Color.red;
    //[SerializeField] Color maxHPColor = Color.green;
    [SerializeField] Gradient healthColor;
    [SerializeField] GameObject isDeadObject;

    int health;
    bool isInvincible = false;

    public int HealthLost 
    {
        get => maxHP - health;
        set => health = maxHP - value;
    }

    void Start()
    {
        health = maxHP;
        UpdateUI();

        Vector3 pos = transform.position;
    }

    public int GetHealth() => health;

    public bool IsAlive => health > 0;

    public void Damage(int n)
    {
        if (isInvincible)
        {
            return;
        }
        
        health -= n;
        health = Mathf.Max(health, 0);

        UpdateUI();

        StartCoroutine(InvincibilityCoroutine());
    }

    IEnumerator InvincibilityCoroutine()
    {
        isInvincible= true;

        float time = 0;
        bool enabled = true;

        while (time < invicibilityFrames)
        {
            enabled = !enabled;
            EnableAllRenderer(enabled);
            yield return new WaitForSeconds(flickTime);
            time += flickTime;
        }

        EnableAllRenderer(true);
        isInvincible = false;
    }

     void EnableAllRenderer(bool enabled)
    {
        foreach (var renderer in GetComponentsInChildren<Renderer>())
        {
            renderer.enabled = enabled;
        }
    }

    void UpdateUI()
    {
        float t = (float)health / maxHP;
        // Color c = Color.Lerp(minHPColor, maxHPColor, t);
        Color c = healthColor.Evaluate(t);

        healthText.color = c;
        healthText.text = health.ToString();

        isDeadObject.SetActive(!IsAlive);
    }
}