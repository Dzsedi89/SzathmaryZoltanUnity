using UnityEngine;

public class KalapSoundPlayer : MonoBehaviour
{
    [SerializeField] AudioSource source;
   public void Playsound()
    {
        source.Play();
    }
}
