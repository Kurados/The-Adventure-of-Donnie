using UnityEngine.Audio;
using UnityEngine;


[CreateAssetMenu(fileName = "SceneInfo", menuName = "Persistence")]
public class SceneInfo : ScriptableObject
{
    public static int coin;

    public static int heart = 3;

    public static bool lvl_1_clear;
    public static bool lvl_2_clear;
    public static bool lvl_3_clear;
    public static bool lvl_4_clear;

    public AudioMixer audioMixer;
    public AudioMixer SFXMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        //Debug.Log(volume);
    }

    public void sFX(float sfxVolume)
    {
        SFXMixer.SetFloat("sfx", sfxVolume);
    }
}
