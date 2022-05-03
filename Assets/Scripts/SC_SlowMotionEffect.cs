using UnityEngine;

public class SC_SlowMotionEffect : MonoBehaviour
{
    public float slowMotionTimeScale = 0.2f;
    public bool slowMotionEnabled = false;

    public float contatempo;

    [System.Serializable]
    public class AudioSourceData
    {
        public AudioSource audioSource;
        public float defaultPitch;
    }

    AudioSourceData[] audioSources;

    // Start is called before the first frame update
    void Start()
    {
        //Encontra os audios na cena e salva o valor do pitch
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        audioSources = new AudioSourceData[audios.Length];

        for (int i = 0; i < audios.Length; i++)
        {
            AudioSourceData tmpData = new AudioSourceData();
            tmpData.audioSource = audios[i];
            tmpData.defaultPitch = audios[i].pitch;
            audioSources[i] = tmpData;
        }

        SlowMotionEffect(slowMotionEnabled);
    }

    // Update is called once per frame
    void Update()
    {
        //ativa e desativa slow motion 
        if (Input.GetKeyDown(KeyCode.Q))
        {
            slowMotionEnabled = !slowMotionEnabled;
            SlowMotionEffect(slowMotionEnabled);
        }
        contatempo += Time.deltaTime;

    }

    void SlowMotionEffect(bool enabled)
    {
        Time.timeScale = enabled ? slowMotionTimeScale : 1;
        for (int i = 0; i < audioSources.Length; i++)
        {
            if (audioSources[i].audioSource)
            {
                audioSources[i].audioSource.pitch = audioSources[i].defaultPitch * Time.timeScale;
            }
        }
    }
}