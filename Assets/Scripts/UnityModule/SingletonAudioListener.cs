using UnityEngine;

namespace UnityModule {

    public class SingletonAudioListener : MonoBehaviour {

        private void Start() {
            if (FindObjectOfType<AudioListener>() == default(AudioListener)) {
                GameObject go = new GameObject(this.GetType().Name);
                go.AddComponent<AudioListener>();
                DontDestroyOnLoad(go);
            }
        }

    }

}